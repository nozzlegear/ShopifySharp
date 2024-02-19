using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    internal class LeakyBucket
    {
        private class Request
        {
            public int cost;
            public FifoSemaphore fifoSemaphore = new FifoSemaphore(0, 1);
            public CancellationToken cancelToken;

            public Request(int cost, CancellationToken cancelToken)
            {
                this.cost = cost;
                this.cancelToken = cancelToken;
            }
        }

        internal int MaximumAvailable { get; private set; }

        internal int RestoreRatePerSecond { get; private set; }

        internal double LastCurrentlyAvailable { get; private set; }

        internal DateTime LastUpdatedAt { get; private set; }

        internal double ComputedCurrentlyAvailable => Math.Min(MaximumAvailable,
                                                              LastCurrentlyAvailable + ((_getTime() - LastUpdatedAt).TotalSeconds * RestoreRatePerSecond));

        private readonly Func<DateTime> _getTime;

        private readonly ContextAwareQueue<Request> _waitingRequests;

        private object _lock = new object();

        private CancellationTokenSource _cancelNextSchedule;

        public LeakyBucket(int maximumAvailable, int restoreRatePerSecond, Func<RequestContext> getRequestContext)
            : this(maximumAvailable, restoreRatePerSecond, () => DateTime.UtcNow, getRequestContext)
        {
        }

        internal LeakyBucket(int maximumAvailable, int restoreRatePerSecond, Func<DateTime> getTime, Func<RequestContext> getRequestContext = null)
        {
            if (maximumAvailable <= 0 || restoreRatePerSecond <= 0)
                throw new ArgumentOutOfRangeException();

            _getTime = getTime;
            _waitingRequests = new ContextAwareQueue<Request>(getRequestContext ?? (new Func<RequestContext>(() => RequestContext.Foreground)));
            MaximumAvailable = maximumAvailable;
            RestoreRatePerSecond = restoreRatePerSecond;
            LastCurrentlyAvailable = maximumAvailable;
            LastUpdatedAt = _getTime();
        }

        public void SetState(int maximumAvailable, int restoreRatePerSecond, double currentlyAvailable)
        {
            if (maximumAvailable <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(maximumAvailable)} ({maximumAvailable}) must be greater than zero");

            if (currentlyAvailable < 0)
                throw new ArgumentOutOfRangeException($"{nameof(currentlyAvailable)} ({currentlyAvailable}) must be positive or zero.");

            if (restoreRatePerSecond <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(restoreRatePerSecond)} ({restoreRatePerSecond}) must be greater than zero");

            if (currentlyAvailable > maximumAvailable)
                throw new ArgumentOutOfRangeException($"{nameof(currentlyAvailable)} ({currentlyAvailable}) must not be greater than {nameof(maximumAvailable)} ({maximumAvailable})");

            lock (_lock)
            {
                MaximumAvailable = maximumAvailable;
                RestoreRatePerSecond = restoreRatePerSecond;
                LastCurrentlyAvailable = currentlyAvailable;
                LastUpdatedAt = _getTime();
            }
            TryGrantNextPendingRequest();
        }

        private void ConsumeAvailable(Request r)
        {
            lock (_lock)
            {
                LastCurrentlyAvailable = this.ComputedCurrentlyAvailable - r.cost;
                LastUpdatedAt = _getTime();
            }
        }

        public async Task WaitForAvailableAsync(int requestCost, CancellationToken cancellationToken = default)
        {
            if (requestCost > MaximumAvailable)
                throw new ShopifyException($"Requested query cost of {requestCost} is larger than maximum available {MaximumAvailable}");

            var r = new Request(requestCost, cancellationToken);

            lock (_lock)
            {
                if (ComputedCurrentlyAvailable >= requestCost && _waitingRequests.Count == 0)
                {
                    ConsumeAvailable(r);
                    return;
                }

                _waitingRequests.Enqueue(r);

                if (_waitingRequests.Count == 1)
                    ScheduleTryGrantNextPendingRequest(r);
            }
            await r.fifoSemaphore.WaitAsync(cancellationToken);
        }

        private void ScheduleTryGrantNextPendingRequest(Request r)
        {
            _cancelNextSchedule?.Cancel();
            _cancelNextSchedule = new CancellationTokenSource();
            var waitFor = TimeSpan.FromSeconds(Math.Max(0, (r.cost - ComputedCurrentlyAvailable) / (float)RestoreRatePerSecond));
            _ = Task.Delay(waitFor, _cancelNextSchedule.Token)
                                  .ContinueWith(_ => TryGrantNextPendingRequest(),
                                                     TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        private void TryGrantNextPendingRequest()
        {
            lock (_lock)
            {
                while (_waitingRequests.Count > 0 &&
                       (_waitingRequests.Peek().cancelToken.IsCancellationRequested || ComputedCurrentlyAvailable >= _waitingRequests.Peek().cost))
                {
                    var r = _waitingRequests.Dequeue();
                    if (!r.cancelToken.IsCancellationRequested)
                    {
                        r.fifoSemaphore.Release();
                        ConsumeAvailable(r);
                    }
                }

                if (_waitingRequests.Count > 0)
                    ScheduleTryGrantNextPendingRequest(_waitingRequests.Peek());
            }
        }
    }
}
