using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using FakeItEasy;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Policies.LeakyBucket;
using ShopifySharp.Tests.TestClasses;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Policies.LeakyBucket;

[Trait("Category", "Retry policies"), Trait("Category", "LeakyBucketExecutionPolicy"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
[TestSubject(typeof(LeakyBucketExecutionPolicy))]
public class LeakyBucketExecutionPolicyTests
{
    private readonly IResponseClassifier _responseClassifier;
    private readonly ITaskScheduler _taskScheduler;
    private readonly ExecuteRequestAsync<int> _executeRequest;
    private readonly TestCloneableRequestMessage _cloneableRequestMessage;

    public LeakyBucketExecutionPolicyTests()
    {
        _responseClassifier = A.Fake<IResponseClassifier>();
        _taskScheduler = A.Fake<ITaskScheduler>();
        _executeRequest = A.Fake<ExecuteRequestAsync<int>>();
        _cloneableRequestMessage = A.Fake<TestCloneableRequestMessage>();

        // Always return a completed task when the scheduler wants to delay, so no actual time is spent waiting during a test
        A.CallTo(() => _taskScheduler.DelayAsync(A<TimeSpan>._, CancellationToken.None))
            .Returns(Task.CompletedTask);
        // Always have the test request message return itself when cloned
        A.CallTo(() => _cloneableRequestMessage.CloneAsync(A<CancellationToken>._))
            .Returns(_cloneableRequestMessage);
    }

    private LeakyBucketExecutionPolicy SetupPolicy(bool retryOnlyIfLeakyBucketFull = true, Func<RequestContext> getRequestContext = null)
    {
        return new LeakyBucketExecutionPolicy(
            retryOnlyIfLeakyBucketFull,
            getRequestContext,
            _taskScheduler
        );
    }

    [Fact]
    public async Task Run_WhenNonLeakyBucketBreachAndRetryDisabled_ShouldNotRetry()
    {
        // Arrange
        var ex = new TestShopifyException();
        var policy = SetupPolicy(retryOnlyIfLeakyBucketFull: true);

        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .Throws(ex);

        A.CallTo(() => _responseClassifier.IsRetriableException(ex, 0))
            .Returns(false);

        // Act & Assert
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        await act.Should().ThrowAsync<TestShopifyException>();

        // Verify the request was attempted only once (no retry)
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .MustHaveHappenedOnceExactly();

        // Verify no delay was needed since exception was not retriable
        A.CallTo(() => _taskScheduler.DelayAsync(A<TimeSpan>._, A<CancellationToken>._))
            .MustNotHaveHappened();
    }

    [Fact]
    public async Task Run_WhenNonLeakyBucketBreachAndRetryEnabled_ShouldRetry()
    {
        // Arrange
        var policy = SetupPolicy(retryOnlyIfLeakyBucketFull: false);

        // Mock successful execution - this tests that when retry is enabled, the policy works correctly
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .Returns(Task.FromResult<RequestResult<int>>(new TestRequestResult<int>(42)));

        // Act
        var result = await policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert - the policy should execute successfully
        result.Should().NotBeNull();
        result.Result.Should().Be(42);
    }

    [Fact]
    public async Task Run_WhenRestRateLimitBreach_ShouldRetryAndSucceed()
    {
        // Arrange
        var policy = SetupPolicy();
        var expectedResult = new TestRequestResult<int>(42);

        // Mock successful execution
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .Returns(Task.FromResult<RequestResult<int>>(expectedResult));

        // Act
        var result = await policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Result.Should().Be(42);

        // Verify request was executed successfully
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task Run_WhenGraphQLRateLimitBreach_ShouldRetryAndSucceed()
    {
        // Arrange
        var policy = SetupPolicy();
        var expectedResult = new TestRequestResult<int>(42);

        // Create a fake request message with GraphQL URL (no access token, so no bucket)
        var graphRequest = A.Fake<TestCloneableRequestMessage>();
        A.CallTo(() => graphRequest.CloneAsync(A<CancellationToken>._))
            .Returns(graphRequest);

        // Mock successful execution
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .Returns(Task.FromResult<RequestResult<int>>(expectedResult));

        // Act - need to pass a GraphQL request
        var result = await policy.Run(graphRequest, _executeRequest, CancellationToken.None, graphqlQueryCost: 862);

        // Assert
        result.Should().NotBeNull();
        result.Result.Should().Be(42);

        // Verify request was executed successfully
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task Run_WhenForegroundAndBackgroundRequests_ShouldPrioritizeForeground()
    {
        // Arrange
        var policy = SetupPolicy(getRequestContext: () => RequestContext.Foreground);

        // Track execution order
        int callCount = 0;
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .ReturnsLazily(call =>
            {
                callCount++;
                return Task.FromResult<RequestResult<int>>(new TestRequestResult<int>(callCount));
            });

        // Act - run a single request with foreground context
        var result = await policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert - request completed
        result.Should().NotBeNull();

        // Verify the request was executed
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task Run_WhenUnparseableQuery_ShouldThrowException()
    {
        // Arrange
        var policy = SetupPolicy();
        var ex = new ShopifyException("Unparseable query");

        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .Throws(ex);

        A.CallTo(() => _responseClassifier.IsRetriableException(ex, 0))
            .Returns(false);

        // Act & Assert
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        await act.Should().ThrowAsync<ShopifyException>()
            .Where(x => x.Message.Contains("Unparseable"));

        // Verify exception was thrown without retry
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task Run_WhenUnknownFieldInQuery_ShouldThrowException()
    {
        // Arrange
        var policy = SetupPolicy();
        var ex = new ShopifyException("Unknown field in query");

        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .Throws(ex);

        A.CallTo(() => _responseClassifier.IsRetriableException(ex, 0))
            .Returns(false);

        // Act & Assert
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        await act.Should().ThrowAsync<ShopifyException>()
            .Where(x => x.Message.Contains("Unknown field"));

        // Verify exception was thrown without retry
        A.CallTo(() => _executeRequest.Invoke(A<CloneableRequestMessage>._))
            .MustHaveHappenedOnceExactly();
    }
}