using System.Threading;

namespace ShopifySharp.Infrastructure.Policies.LeakyBucketPolicy;

internal sealed class LeakyBucketRequest(int cost, CancellationToken cancellationToken)
{
    public readonly int Cost = cost;
    public readonly SemaphoreSlim Semaphore = new(0, 1);
    public readonly CancellationToken CancellationToken = cancellationToken;
}
