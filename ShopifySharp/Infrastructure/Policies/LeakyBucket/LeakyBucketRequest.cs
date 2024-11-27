using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure.Policies.LeakyBucket;

internal sealed class LeakyBucketRequest(int cost, CancellationToken cancellationToken) : IDisposable
{
    public readonly int Cost = cost;

    public readonly CancellationToken CancellationToken = cancellationToken;

    public bool IsDisposed { get; private set; }

    private readonly SemaphoreSlim Semaphore = new(0, 1);

    public void Dispose()
    {
        if (IsDisposed)
            return;

        Semaphore.Dispose();
        IsDisposed = true;
    }

    public void Release()
    {
        if (!IsDisposed)
            Semaphore.Release();
    }

    public Task WaitAsync(CancellationToken t)
    {
        return Semaphore.WaitAsync(t);
    }
}
