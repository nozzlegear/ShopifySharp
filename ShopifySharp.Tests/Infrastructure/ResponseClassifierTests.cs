using System.Net;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure;

[Trait("Category", "ResponseClassifier")]
[TestSubject(typeof(ResponseClassifier))]
public class ResponseClassifierTest
{
    #region IsRetriableStatusCode

#if NET8_0_OR_GREATER
    [Theory]
    [InlineData(HttpStatusCode.RequestTimeout, true)]
    [InlineData(HttpStatusCode.TooManyRequests, true)]
    [InlineData(HttpStatusCode.InternalServerError, true)]
    [InlineData(HttpStatusCode.BadGateway, true)]
    [InlineData(HttpStatusCode.ServiceUnavailable, true)]
    [InlineData(HttpStatusCode.GatewayTimeout, true)]
    [InlineData(HttpStatusCode.Accepted, false)]
    [InlineData(HttpStatusCode.BadRequest, false)]
    [InlineData(HttpStatusCode.Ambiguous, false)]
    [InlineData(HttpStatusCode.Redirect, false)]
    public void IsRetriableStatusCode_ShouldReturnCorrectResult(HttpStatusCode statusCode, bool expectedResult)
    {
        var subject = new ResponseClassifier(false, 0);

        subject.IsRetriableStatusCode(statusCode) .Should() .Be(expectedResult);
    }
#endif

    #endregion

    #region IsRetriableException

    [Fact]
    public void IsRetriableException_ReturnsTrueForRateLimitException_WhenBucketFull()
    {
        var ex = CreateRateLimitException(ShopifyRateLimitReason.BucketFull);
        var subject = new ResponseClassifier(false, 0);

        subject.IsRetriableException(ex, 0).Should().BeTrue();
    }

    [Fact]
    public void IsRetriableException_ReturnsTrueForRateLimitException_WhenOtherReasonAndRetryUnexpectedIsTrue()
    {
        var subject = new ResponseClassifier(true, 0);
        var ex = CreateRateLimitException(ShopifyRateLimitReason.Other);

        subject.IsRetriableException(ex, 0).Should().BeTrue();
    }

    [Fact]
    public void IsRetriableException_ReturnsFalseForRateLimitException_WhenOtherReasonAndRetryUnexpectedIsFalse()
    {
        var subject = new ResponseClassifier(false, 10);
        var ex = CreateRateLimitException(ShopifyRateLimitReason.Other);

        subject.IsRetriableException(ex, 0).Should().BeFalse();
    }

    [Fact]
    public void IsRetriableException_ReturnsFalseForHttpException_WhenStatusCodeIsNotRetriable()
    {
        var subject = new ResponseClassifier(false, 10);
        var ex = CreateHttpException((int) HttpStatusCode.BadRequest);

        subject.IsRetriableStatusCode(ex.HttpStatusCode).Should().BeFalse();
        subject.IsRetriableException(ex, 0).Should().BeFalse();
    }

    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void IsRetriableException_ReturnsFalseForHttpException_WhenStatusCodeIsRetriable_ButTotalRetriesAttemptedHaveReachedMaximumAllowed(int retry)
    {
        var maximumRetries = 3;
        var subject = new ResponseClassifier(false, maximumRetries);
        var ex = CreateHttpException((int) HttpStatusCode.ServiceUnavailable);

        subject.IsRetriableStatusCode(ex.HttpStatusCode).Should().BeTrue();
        subject.IsRetriableException(ex, retry).Should().BeFalse();
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public void IsRetriableException_ReturnsFalseForHttpException_WhenStatusCodeIsRetriable_ButMaximumRetriesAllowedIsZero(int retry)
    {
        var maximumRetries = 0;
        var subject = new ResponseClassifier(false, maximumRetries);
        var ex = CreateHttpException((int) HttpStatusCode.ServiceUnavailable);

        subject.IsRetriableStatusCode(ex.HttpStatusCode).Should().BeTrue();
        subject.IsRetriableException(ex, retry).Should().BeFalse();
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public void IsRetriableException_ReturnsTrueForHttpException_WhenStatusCodeIsRetriable_AndTotalRetriesAttemptedIsLessThanMaximumRetriesAllowed(int retry)
    {
        var maximumRetries = 3;
        var subject = new ResponseClassifier(false, maximumRetries);
        var ex = CreateHttpException((int) HttpStatusCode.ServiceUnavailable);

        subject.IsRetriableException(ex, retry).Should().BeTrue();
    }

    [Theory]
    [InlineData(0, true)]
    [InlineData(1, true)]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(4, false)]
    public void IsRetriableException_AllowsThreeRetriesForNonRateLimitedExceptions(int retry, bool expectedOutcome)
    {
        var maximumRetries = 3;
        var subject = new ResponseClassifier(false, maximumRetries);
        var ex = CreateHttpException((int) HttpStatusCode.ServiceUnavailable);

        subject.IsRetriableException(ex, retry).Should().Be(expectedOutcome);
    }

    private ShopifyRateLimitException CreateRateLimitException(ShopifyRateLimitReason reason)
    {
        return new ShopifyRateLimitException(string.Empty, (HttpStatusCode)429,
            [],
            "some-exception-message",
            "some-raw-response-body",
            "some-request-id",
            reason,
            0);
    }

    private ShopifyHttpException CreateHttpException(int statusCode)
    {
        return new ShopifyHttpException(string.Empty, (HttpStatusCode)statusCode,
            [],
            "some-exception-message",
            "some-raw-response-body",
            "some-request-id");
    }

    #endregion
}
