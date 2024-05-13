#nullable enable
using System;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Policies.ExponentialRetry;

[Trait("Category", "Retry policies"), Trait("Category", "ExponentialRetryPolicyOptions"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
[TestSubject(typeof(ExponentialRetryPolicyOptions))]
public class ExponentialRetryPolicyOptionsTests
{
    [Fact]
    public void DefaultFactoryMethod_ShouldCreateOptionsThatPassValidation()
    {
        var options = ExponentialRetryPolicyOptions.Default();

        var act = options.Validate;

        act.Should().NotThrow().And.Subject.Should().NotBeNull();
    }

    [Theory]
    [InlineData(null, null, true)]
    [InlineData(null, 1, false)]
    [InlineData(1, null, false)]
    [InlineData(1, 1, false)]
    public void Validate_ShouldValidateMaxRetriesAndMaxDelayBeforeTimeout(int? maxRetries, int? maxDelay, bool shouldThrow)
    {
        var options = new ExponentialRetryPolicyOptions
        {
            MaximumDelayBetweenRetries = TimeSpan.FromSeconds(1),
            InitialBackoffInMilliseconds = 100,
            MaximumRetriesBeforeRequestCancellation = maxRetries,
            MaximumDelayBeforeRequestCancellation = maxDelay is null ? null : TimeSpan.FromSeconds(maxDelay.Value),
        };

        var act = () => options.Validate();

        if (shouldThrow)
            act.Should().Throw<ArgumentException>();
        else
            act.Should().NotThrow().And.Subject.Should().NotBeNull();
    }

    [Theory]
    [InlineData(-1, true)]
    [InlineData(0, true)]
    [InlineData(1, false)]
    public void Validate_ShouldValidateBackoffInMilliseconds(int backoffInMilliseconds, bool shouldThrow)
    {
        var options = new ExponentialRetryPolicyOptions
        {
            MaximumDelayBetweenRetries = TimeSpan.FromSeconds(1),
            InitialBackoffInMilliseconds = backoffInMilliseconds,
            MaximumRetriesBeforeRequestCancellation = 1,
            MaximumDelayBeforeRequestCancellation = null,
        };

        var act = () => options.Validate();

        if (shouldThrow)
            act.Should().Throw<ArgumentException>();
        else
            act.Should().NotThrow().And.Subject.Should().NotBeNull();
    }

    [Theory]
    [InlineData(-1, true)]
    [InlineData(0, true)]
    [InlineData(1, false)]
    public void Validate_ShouldValidateMaximumDelayBetweenRetries(int maximumDelayBetweenRetries, bool shouldThrow)
    {
        var options = new ExponentialRetryPolicyOptions
        {
            MaximumDelayBetweenRetries = TimeSpan.FromSeconds(maximumDelayBetweenRetries),
            InitialBackoffInMilliseconds = 100,
            MaximumRetriesBeforeRequestCancellation = 1,
            MaximumDelayBeforeRequestCancellation = null,
        };

        var act = () => options.Validate();

        if (shouldThrow)
            act.Should().Throw<ArgumentException>();
        else
            act.Should().NotThrow().And.Subject.Should().NotBeNull();
    }
}
