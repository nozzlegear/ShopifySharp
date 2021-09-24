using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    internal class LeakyBucket
    {
        private class Request
        {
            public int cost;
            public SemaphoreSlim semaphore = new SemaphoreSlim(0, 1);
            public CancellationToken cancelToken;

            public Request(int cost, CancellationToken cancelToken)
            {
                this.cost = cost;
                this.cancelToken = cancelToken;
            }
        }

        internal int MaximumAvailable { get; private set; }

        internal int RestoreRatePerSecond { get; private set; }

        internal int LastCurrentlyAvailable { get; private set; }

        internal DateTime LastUpdatedAt { get; private set; }

        internal int ComputedCurrentlyAvailable => Math.Min(MaximumAvailable,
                                                          LastCurrentlyAvailable + ((int)(_getTime() - LastUpdatedAt).TotalSeconds * RestoreRatePerSecond));

        private Func<DateTime> _getTime;

        private Queue<Request> _waitingRequests = new Queue<Request>();

        private object _lock = new object();

        private CancellationTokenSource _cancelNextSchedule;

        public LeakyBucket(int maximumAvailable, int restoreRatePerSecond)
            : this(maximumAvailable, restoreRatePerSecond, () => DateTime.UtcNow)
        {
        }

        internal LeakyBucket(int maximumAvailable, int restoreRatePerSecond, Func<DateTime> getTime)
        {
            if (maximumAvailable <= 0 || restoreRatePerSecond <= 0)
                throw new ArgumentOutOfRangeException();

            _getTime = getTime;
            MaximumAvailable = maximumAvailable;
            RestoreRatePerSecond = restoreRatePerSecond;
            LastCurrentlyAvailable = maximumAvailable;
            LastUpdatedAt = _getTime();
        }

        public void SetState(int maximumAvailable, int restoreRatePerSecond, int currentlyAvailable)
        {
            if (maximumAvailable <= 0 || currentlyAvailable < 0 || restoreRatePerSecond <= 0 || currentlyAvailable > maximumAvailable)
                throw new ArgumentOutOfRangeException();

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
                if (ComputedCurrentlyAvailable > requestCost && _waitingRequests.Count == 0)
                {
                    ConsumeAvailable(r);
                    return;
                }

                _waitingRequests.Enqueue(r);

                if (_waitingRequests.Count == 1)
                    ScheduleTryGrantNextPendingRequest(r);
            }
            await r.semaphore.WaitAsync(cancellationToken);
        }

        private void ScheduleTryGrantNextPendingRequest(Request r)
        {
            _cancelNextSchedule?.Cancel();
            _cancelNextSchedule = new CancellationTokenSource();
            var waitFor = TimeSpan.FromSeconds(Math.Max(0, (r.cost - ComputedCurrentlyAvailable) / (float)RestoreRatePerSecond));
            _ = Task.Delay(waitFor, _cancelNextSchedule.Token)
                                  .ContinueWith(_ => TryGrantNextPendingRequest(), TaskContinuationOptions.OnlyOnRanToCompletion);
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
                        r.semaphore.Release();
                        ConsumeAvailable(r);
                    }
                }

                if (_waitingRequests.Count > 0)
                    ScheduleTryGrantNextPendingRequest(_waitingRequests.Peek());
            }
        }
    }
}
