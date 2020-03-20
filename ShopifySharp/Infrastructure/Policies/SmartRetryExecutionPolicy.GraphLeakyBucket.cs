using GlobalE.Shopify.Service.APIs.Models;
using GlobalE.Shopify.Service.APIs.ShopifyAPI.Infrastructure.Policies;
using GlobalE.Shopify.Service.APIs.ShopifyAPI.Tools;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Globale.Shopify.Service.APIs.ShopifyAPI.Infrastructure.Policies
{
    public partial class SmartRetryExecutionPolicy
    {
        private class GraphLeakyBucket : ILeakyBucket
        {
            ILogger _logger;
            private const int DEFAULT_BUCKET_CAPACITY = 1000;
            private const int AVG_QUERY_COST = 50;
            private int _bucketCapacity = DEFAULT_BUCKET_CAPACITY;
            private int _availableCapacity = DEFAULT_BUCKET_CAPACITY;
            private int _leakRate = 50;

            private static ConcurrentBag<GraphLeakyBucket> _allLeakyBuckets = new ConcurrentBag<GraphLeakyBucket>();

            private static Timer _dripAllBucketsTimer = new Timer(_ => DripAllBuckets(), null, THROTTLE_DELAY, THROTTLE_DELAY);

            private ConcurrentQueue<int> _recentQueriesCosts = new ConcurrentQueue<int>();
            private const int KEPP_RECENT_QUERIES_COUNT = 10;

            public GraphLeakyBucket(ILogger logger)
            {
                _logger = logger;
                _allLeakyBuckets.Add(this);
            }

            public class QueyeEntry {
                public int ExpectedQueryCost;
                public AsyncAutoResetEvent WaitHandle;
            }

            private static ConcurrentQueue<QueyeEntry> _queue = new ConcurrentQueue<QueyeEntry>();

            public async Task<int> GrantAsync(ShopifySharp.Infrastructure.CloneableRequestMessage request)
            {
                int myExpectedQueryCost = GetExpectedQueryCost(request);
                var entry = new QueyeEntry
                {
                    ExpectedQueryCost = myExpectedQueryCost, 
                    WaitHandle = new AsyncAutoResetEvent()
                };

                _queue.Enqueue(entry);
                RunQueye();    
                await entry.WaitHandle.WaitAsync();
                return entry.ExpectedQueryCost;
            }

            private void RunQueye()
            {
                lock (_queue)
                {
                    while (_queue.Any())
                    {

                        QueyeEntry entry;
                        _queue.TryPeek(out entry);

                        if (entry != null && _availableCapacity > (entry.ExpectedQueryCost + AverageQueryCost / 10))//SAFE MARGIN
                        {
                            Interlocked.Add(ref _availableCapacity, -entry.ExpectedQueryCost);
                            entry.WaitHandle.Set();
                            _queue.TryDequeue(out entry);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }

            private int GetExpectedQueryCost(ShopifySharp.Infrastructure.CloneableRequestMessage request)
            {
                return AverageQueryCost;
            }

            private void SetState(GraphQLResponseCost cost, int myExpectedQueryCost)
            {
                int r = 0;
                _recentQueriesCosts.Enqueue((int)(cost.actualQueryCost ?? cost.requestedQueryCost));
                if (_recentQueriesCosts.Count > KEPP_RECENT_QUERIES_COUNT)
                    _recentQueriesCosts.TryDequeue(out r);

                if (myExpectedQueryCost > 0 && myExpectedQueryCost != (int)(cost.actualQueryCost ?? 0)) {
                    //compensate query cost difference
                    Interlocked.Add(ref _availableCapacity, myExpectedQueryCost - (int)(cost.actualQueryCost ?? 0));
                }

                //Shopify Plus customers have a bucket that is twice the size (80) so we resize the bucket capacity accordingly
                //It is apparently possible to request the bucket size to be even larger
                //https://ecommerce.shopify.com/c/shopify-apis-and-technology/t/what-is-the-default-api-call-limit-on-shopify-stores-407292
                //Note that when the capacity doubles, the leak rate also doubles. So, not only can request bursts be larger, it is also possible to sustain a faster rate over the long term.
                if (cost.throttleStatus.maximumAvailable > this._bucketCapacity)
                {
                    lock (_queue)
                    {
                        if (cost.throttleStatus.maximumAvailable > this._bucketCapacity)
                        {
                            var toAdd = ((int)cost.throttleStatus.maximumAvailable - this._bucketCapacity);
                            Interlocked.Add(ref _availableCapacity, toAdd);
                            Trace.WriteLine("Released " + toAdd);
                            _bucketCapacity = (int)cost.throttleStatus.maximumAvailable;
                            _leakRate = (int)cost.throttleStatus.restoreRate;
                        }
                    }
                }
                //Corrects the grant capacity of the bucket based on the size returned by Shopify.
                //Shopify may know that the remaining capacity is less than we think it is (for example if multiple programs are using that same token)
                //Shopify may also think that the remaining capacity is more than we know, but we do not ever empty the bucket because Shopify is not
                //considering requests that we know are already in flight.
                while (_availableCapacity > cost.throttleStatus.currentlyAvailable)
                {
                    //We refill the virtual bucket accordingly.
                   Interlocked.Add(ref _availableCapacity, -(_availableCapacity - (int)cost.throttleStatus.currentlyAvailable));
                }

                RunQueye();
                Trace.WriteLine("From API Capacity " + cost.throttleStatus.maximumAvailable + " Available " + cost.throttleStatus.currentlyAvailable);
            }

            internal LeakyBucketStateModel GetState()
            {
                return new LeakyBucketStateModel(_bucketCapacity, _bucketCapacity - _availableCapacity);
            }

            private void Drip()
            {
                if (_availableCapacity < _bucketCapacity)
                {
                    lock (_queue)
                    {
                        int waitingOperationsCost = _bucketCapacity - _availableCapacity;
                        var toRelease = Math.Min(_leakRate, waitingOperationsCost);
                        toRelease = Math.Max(1, toRelease);
                        Interlocked.Add(ref _availableCapacity, toRelease);
                    }
                }

                RunQueye();

                //if (_semaphore.CurrentCount * DefaultExpectedQueryCost < _bucketCapacity)
                //{
                //    int waitingOperationsCost = _bucketCapacity - _semaphore.CurrentCount * DefaultExpectedQueryCost;
                //    var toRelease = Math.Min(_leakRate, waitingOperationsCost) / DefaultExpectedQueryCost;
                //    toRelease = Math.Max(1, toRelease);
                //    _semaphore.Release(toRelease);
                //    
                //}
            }

            private static void DripAllBuckets()
            {
                foreach (var bucket in _allLeakyBuckets)
                {
                    bucket.Drip();
                }
            }
            

            private int AverageQueryCost
            {
                get
                {
                    return _recentQueriesCosts.Count < KEPP_RECENT_QUERIES_COUNT
                        ? AVG_QUERY_COST 
                        : (int)_recentQueriesCosts.Average(); 
                }
            }

            public void UpdateState<T>(ShopifySharp.RequestResult<T> fullResult, int myExpectedQueryCost)
            {
                var cost = GraphQLResponseCost.Get(fullResult);
                if (cost != null)
                    SetState(cost, myExpectedQueryCost);
            }

        }
    }    
}
