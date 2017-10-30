using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public partial class SmartRetryExecutionPolicy
    {
        private class LeakyBucket
        {
            private const int DEFAULT_BUCKET_CAPACITY = 40;

            private int _bucketCapacity = DEFAULT_BUCKET_CAPACITY;

            private int _leakRate = 1;

            private static ConcurrentBag<LeakyBucket> _allLeakyBuckets = new ConcurrentBag<LeakyBucket>();

            private static Timer _dripAllBucketsTimer = new Timer(_ => DripAllBuckets(), null, THROTTLE_DELAY, THROTTLE_DELAY);

            private SemaphoreSlim _semaphore = new SemaphoreSlim(DEFAULT_BUCKET_CAPACITY, 1000);

            public LeakyBucket()
            {
                _allLeakyBuckets.Add(this);
            }

            public Task GrantAsync()
            {
                return _semaphore.WaitAsync();
            }

            public void SetState(LeakyBucketState bucketInfo)
            {
                //Shopify Plus customers have a bucket that is twice the size (80) so we resize the bucket capacity accordingly
                //It is apparently possible to request the bucket size to be even larger
                //https://ecommerce.shopify.com/c/shopify-apis-and-technology/t/what-is-the-default-api-call-limit-on-shopify-stores-407292
                //Note that when the capacity doubles, the leak rate also doubles. So, not only can request bursts be larger, it is also possible to sustain a faster rate over the long term.
                if (bucketInfo.Capacity > this._bucketCapacity)
                {
                    lock (_semaphore)
                    {
                        if (bucketInfo.Capacity > this._bucketCapacity)
                        {
                            _semaphore.Release(bucketInfo.Capacity - this._bucketCapacity);
                            _bucketCapacity = bucketInfo.Capacity;
                            _leakRate = bucketInfo.Capacity / DEFAULT_BUCKET_CAPACITY;
                        }
                    }
                }
                //Corrects the grant capacity of the bucket based on the size returned by Shopify.
                //Shopify may know that the remaining capacity is less than we think it is (for example if multiple programs are using that same token)
                //Shopify may also think that the remaining capacity is more than we know, but we do not ever empty the bucket because Shopify is not
                //considering requests that we know are already in flight.
                int grantCapacity = this._bucketCapacity - bucketInfo.CurrentFillLevel;

                while (_semaphore.CurrentCount > grantCapacity)
                {
                    //We refill the virtual bucket accordingly.
                    _semaphore.Wait();
                }
            }

            private void Drip()
            {
                if (_semaphore.CurrentCount < _bucketCapacity)
                {
                    int waitingOperations = _bucketCapacity - _semaphore.CurrentCount;
                    _semaphore.Release(Math.Min(_leakRate, waitingOperations));
                }
            }

            private static void DripAllBuckets()
            {
                foreach (var bucket in _allLeakyBuckets)
                {
                    bucket.Drip();
                }
            }
        }
    }
}
