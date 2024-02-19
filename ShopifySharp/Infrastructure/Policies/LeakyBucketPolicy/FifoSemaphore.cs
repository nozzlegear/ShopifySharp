using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    internal class FifoSemaphore
    {
        private SemaphoreSlim _semaphore;

        private ConcurrentQueue<TaskCompletionSource<bool>> queue = new ();

        public int QueueCount => queue.Count;

        public FifoSemaphore(int initialCount, int maxConcurrency)
        {
            _semaphore = new SemaphoreSlim(initialCount, maxConcurrency);
        }

        public Task WaitAsync(CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<bool>();
            queue.Enqueue(tcs);
            _semaphore.WaitAsync(cancellationToken).ContinueWith(t =>
            {
                if (queue.TryDequeue(out var popped))
                    popped.SetResult(true);
            });
            return tcs.Task;
        }

        public void Release()
        {
            _semaphore.Release();
        }
    }
}
