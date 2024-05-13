#nullable enable
using System;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;

namespace ShopifySharp;

[Serializable]
public class ShopifyExponentialRetryCanceledException(
    int currentTry,
    ExponentialRetryPolicyOptions options
) : ShopifyException
{
    public int CurrentTry { get; } = currentTry;
    public int BackoffInMilliseconds { get; } = options.InitialBackoffInMilliseconds;
    public int? MaximumRetries { get; } = options.MaximumRetriesBeforeRequestCancellation;
    public TimeSpan? MaximumDelayBeforeTimeout { get; } = options.MaximumDelayBeforeRequestCancellation;
}
