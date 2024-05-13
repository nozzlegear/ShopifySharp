#nullable enable
using System;

namespace ShopifySharp.Infrastructure.Policies.ExponentialRetry;

/// <summary>
/// Options for configuring the <see cref="ExponentialRetryPolicy"/>. Note: you must set at least one of either
/// <see cref="MaximumRetriesBeforeRequestCancellation"/> or <see cref="MaximumDelayBeforeRequestCancellation"/>.
/// If both values are null, the policy will throw an exception when it calls <see cref="ExponentialRetryPolicyOptions.Validate()"/>.
/// </summary>
public record ExponentialRetryPolicyOptions
{
#if NET8_0_OR_GREATER
    public required int InitialBackoffInMilliseconds { get; set; }
    /// The maximum amount of time that can be spent waiting before retrying a request. This is an effective cap on the
    /// exponential growth of the policy's retry delay, which could eventually lead to an overflow without it.
    public required TimeSpan MaximumDelayBetweenRetries { get; set; }
#else
    public int InitialBackoffInMilliseconds { get; set; }
    /// The maximum amount of time that can be spent waiting before retrying a request. This is an effective cap on the
    /// exponential growth of the policy's retry delay, which could eventually lead to an overflow without it.
    public TimeSpan MaximumDelayBetweenRetries { get; set; }
#endif
    public int? MaximumRetriesBeforeRequestCancellation { get; set; }
    public TimeSpan? MaximumDelayBeforeRequestCancellation { get; set; }

    /// <summary>
    /// Validates this instance and throws an <see cref="ArgumentException"/> if misconfigured.
    /// </summary>
    public void Validate()
    {
        if (InitialBackoffInMilliseconds <= 0)
            throw new ArgumentException($"You must specify a value greater than zero for {nameof(InitialBackoffInMilliseconds)}.");

        if (MaximumDelayBetweenRetries <= TimeSpan.Zero)
            throw new ArgumentException($"You must specify a {nameof(TimeSpan)} value greater than zero for {nameof(MaximumDelayBetweenRetries)}.");

        if (MaximumRetriesBeforeRequestCancellation is null && MaximumDelayBeforeRequestCancellation is null)
            throw new ArgumentException($"You must specify at least one of {nameof(MaximumRetriesBeforeRequestCancellation)} or {nameof(MaximumDelayBeforeRequestCancellation)}.");
    }

    public static ExponentialRetryPolicyOptions Default() =>
        new()
        {
            MaximumRetriesBeforeRequestCancellation = 10,
            MaximumDelayBetweenRetries = TimeSpan.FromSeconds(1),
            MaximumDelayBeforeRequestCancellation = TimeSpan.FromSeconds(5),
            InitialBackoffInMilliseconds = 100,
        };
}
