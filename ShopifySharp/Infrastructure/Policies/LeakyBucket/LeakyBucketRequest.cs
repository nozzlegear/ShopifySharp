using System;
using System.Threading;

namespace ShopifySharp.Infrastructure.Policies.LeakyBucket;

internal sealed class LeakyBucketRequest(int cost, CancellationToken cancellationToken) : IDisposable
{
    public readonly int Cost = cost;
    public readonly SemaphoreSlim Semaphore = new(0, 1);
    public readonly CancellationToken CancellationToken = cancellationToken;

    public void Dispose()
    {
        Semaphore?.Dispose();
    }
}
