using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public partial class SmartRetryExecutionPolicy
    {
        private class LeakyBucket
        {
            private const int BUCKET_MAX_SIZE = 40;

            private static ConcurrentBag<LeakyBucket> _allLeakyBuckets = new ConcurrentBag<LeakyBucket>();
            private static Timer _dripAllBucketsTimer = new Timer(_ => DripAllBuckets(), null, THROTTLE_DELAY, THROTTLE_DELAY);

            private SemaphoreSlim _semaphore = new SemaphoreSlim(BUCKET_MAX_SIZE, BUCKET_MAX_SIZE);

            public LeakyBucket()
            {
                _allLeakyBuckets.Add(this);
            }

            public Task GrantAsync()
            {
                return _semaphore.WaitAsync();
            }

            public void SetContentSize(int contentSize)
            {
                //Corrects the grant capacity of the bucket based on the size returned by Shopify.
                //Shopify may know that the remaining capacity is less than we think it is (for example if multiple programs are using that same token)
                //Shopify may also think that the remaining capacity is more than we know, but we do not ever empty the bucket because Shopify is not
                //considering requests that we know are already in flight.
                int grantCapacity = BUCKET_MAX_SIZE - contentSize;
                while (_semaphore.CurrentCount > grantCapacity)
                {
                    //We refill the virtual bucket accordingly.
                    _semaphore.Wait();
                }
            }

            private void ReleaseOne()
            {
                if (_semaphore.CurrentCount < BUCKET_MAX_SIZE)
                {
                    _semaphore.Release();
                }
            }

            private static void DripAllBuckets()
            {
                foreach (var bucket in _allLeakyBuckets)
                {
                    bucket.ReleaseOne();
                }
            }
        }
    }
}
