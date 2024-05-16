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
    /// <summary>
    /// Indicates whether the policy should immediately retry the first failure per request before applying the
    /// exponential backoff strategy.
    /// </summary>
    /// <value>
    /// <c>true</c> if the first retry should be immediate; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Setting this property to <c>true</c> can be useful in scenarios where transient failures are likely and
    /// immediate retry might resolve the failure. If set to <c>false</c>, all retries including the first one
    /// will follow the exponential backoff intervals.
    /// </remarks>
    public bool FirstRetryIsImmediate { get; set; }

#if NET8_0_OR_GREATER
    public required int InitialBackoffInMilliseconds { get; set; }

    /// <summary>
    /// The maximum amount of time that can be spent waiting before retrying a request. This is an effective cap on the
    /// exponential growth of the policy's retry delay, which could eventually lead to an overflow without it.
    /// </summary>
    public required TimeSpan MaximumDelayBetweenRetries { get; set; }
#else
    public int InitialBackoffInMilliseconds { get; set; }
    /// <summary>
    /// The maximum amount of time that can be spent waiting before retrying a request. This is an effective cap on the
    /// exponential growth of the policy's retry delay, which could eventually lead to an overflow without it.
    /// </summary>
    public TimeSpan MaximumDelayBetweenRetries { get; set; }
#endif
    public int? MaximumRetriesBeforeRequestCancellation { get; set; }
    public TimeSpan? MaximumDelayBeforeRequestCancellation { get; set; }

    /// <summary>
    /// Validates this instance and throws <see cref="ArgumentException"/> if misconfigured.
    /// </summary>
    /// <throws>
    /// <see cref="ArgumentException"/> when the options are misconfigured.
    /// </throws>
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
            FirstRetryIsImmediate = false,
            MaximumRetriesBeforeRequestCancellation = 10,
            MaximumDelayBetweenRetries = TimeSpan.FromSeconds(1),
            MaximumDelayBeforeRequestCancellation = TimeSpan.FromSeconds(5),
            InitialBackoffInMilliseconds = 100,
        };
}
