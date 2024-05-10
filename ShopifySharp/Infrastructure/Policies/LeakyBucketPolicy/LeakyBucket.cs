using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure.Policies.LeakyBucketPolicy;

internal class LeakyBucket
{
    internal int MaximumAvailable { get; private set; }

    internal int RestoreRatePerSecond { get; private set; }

    internal double LastCurrentlyAvailable { get; private set; }

    internal DateTime LastUpdatedAt { get; private set; }

    internal double ComputedCurrentlyAvailable => Math.Min(MaximumAvailable,
        LastCurrentlyAvailable + ((_getTime() - LastUpdatedAt).TotalSeconds * RestoreRatePerSecond));

    private readonly Func<DateTime> _getTime;

    private readonly ContextAwareQueue<LeakyBucketRequest> _waitingRequests;

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
        _waitingRequests = new ContextAwareQueue<LeakyBucketRequest>(getRequestContext ?? (new Func<RequestContext>(() => RequestContext.Foreground)));
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

    private void ConsumeAvailable(LeakyBucketRequest r)
    {
        lock (_lock)
        {
            LastCurrentlyAvailable = this.ComputedCurrentlyAvailable - r.Cost;
            LastUpdatedAt = _getTime();
        }
    }

    public async Task WaitForAvailableAsync(int requestCost, CancellationToken cancellationToken = default)
    {
        if (requestCost > MaximumAvailable)
            throw new ShopifyException($"Requested query cost of {requestCost} is larger than maximum available {MaximumAvailable}");

        using var r = new LeakyBucketRequest(requestCost, cancellationToken);

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

        try
        {
            await r.Semaphore.WaitAsync(cancellationToken);
        }
        catch (OperationCanceledException)
        {
            // TODO: log here once ShopifySharp supports logging
            lock (_lock)
            {
                _waitingRequests.RemoveAndUpdateQueue(r);
            }

            throw;
        }
    }

    private void ScheduleTryGrantNextPendingRequest(LeakyBucketRequest r)
    {
        _cancelNextSchedule?.Cancel();
        _cancelNextSchedule = new CancellationTokenSource();
        var waitFor = TimeSpan.FromSeconds(Math.Max(0, (r.Cost - ComputedCurrentlyAvailable) / (float)RestoreRatePerSecond));
        _ = Task.Delay(waitFor, _cancelNextSchedule.Token)
            .ContinueWith(_ => TryGrantNextPendingRequest(),
                TaskContinuationOptions.OnlyOnRanToCompletion);
    }

    private void TryGrantNextPendingRequest()
    {
        lock (_lock)
        {
            while (_waitingRequests.Count > 0)
            {
                var nextRequest = _waitingRequests.Peek();

                if (nextRequest.CancellationToken.IsCancellationRequested)
                {
                    _waitingRequests.Dequeue();
                    // TODO: dispose the request here? Is the HttpRequestMessage still sitting in memory?
                    continue;
                }

                if (ComputedCurrentlyAvailable >= nextRequest.Cost)
                {
                    // Proceed with current request
                    _waitingRequests.Dequeue();
                    nextRequest.Semaphore.Release();
                    ConsumeAvailable(nextRequest);
                }
                else
                {
                    // Not enough capacity, exit the loop
                    break;
                }
            }

            if (_waitingRequests.Count > 0)
            {
                ScheduleTryGrantNextPendingRequest(_waitingRequests.Peek());
            }
        }
    }
}
