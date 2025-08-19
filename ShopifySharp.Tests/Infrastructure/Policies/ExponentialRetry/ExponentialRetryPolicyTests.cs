using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using JetBrains.Annotations;
using FakeItEasy;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;
using ShopifySharp.Tests.TestClasses;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Policies.ExponentialRetry;

[Trait("Category", "Retry policies"), Trait("Category", "ExponentialRetryPolicy"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
[TestSubject(typeof(ExponentialRetryPolicy))]
public class ExponentialRetryPolicyTests
{
    private const int BackoffInMilliseconds = 100;
    private const int MaximumRetries = 5;
    private readonly IResponseClassifier _responseClassifier;
    private readonly ITaskScheduler _taskScheduler;
    private readonly ExecuteRequestAsync<int> _executeRequest;
    private readonly TestCloneableRequestMessage _cloneableRequestMessage;

    public ExponentialRetryPolicyTests()
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

    private ExponentialRetryPolicy SetupPolicy([CanBeNull] Action<ExponentialRetryPolicyOptions> configure = null)
    {
        var options = new ExponentialRetryPolicyOptions
        {
            MaximumDelayBetweenRetries = TimeSpan.FromSeconds(1),
            InitialBackoffInMilliseconds = BackoffInMilliseconds,
            MaximumRetriesBeforeRequestCancellation = MaximumRetries,
            MaximumDelayBeforeRequestCancellation = null
        };
        configure?.Invoke(options);
        return new ExponentialRetryPolicy(
            options,
            _responseClassifier,
            _taskScheduler
        );
    }

    [Fact]
    public void PolicyConstructor_ShouldValidateOptionsBeforeRunning()
    {
        var act = () => SetupPolicy(x =>
        {
            // Null retries and null delay will cause the options Validate function to throw
            x.MaximumRetriesBeforeRequestCancellation = null;
            x.MaximumDelayBeforeRequestCancellation = null;
        });

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public async Task Run_ShouldReturnResult()
    {
        const int expectedValue = 5;
        var expectedResult = new TestRequestResult<int>(expectedValue);

        A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage))
            .Returns(expectedResult);

        var policy = SetupPolicy();
        var result = await policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        result.Should().NotBeNull();
        result.Result.Should().Be(expectedValue);
    }

    [Fact]
    public async Task Run_ShouldDisposeClonedRequestMessages()
    {
        // Setup
        var policy = SetupPolicy();

        var callToDispose = A.CallTo(() => _cloneableRequestMessage.Dispose());
        callToDispose.Throws<TestException>();

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<TestException>();
        callToDispose.MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task Run_ShouldThrowWhenRequestIsNotRetriableAsync()
    {
        // Setup
        var ex = new TestShopifyException();
        var policy = SetupPolicy();
        var callToClassify = A.CallTo(() => _responseClassifier.IsRetriableException(ex, 1));

        A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage))
            .Throws(ex);
        callToClassify.Returns(false);

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<TestShopifyException>();
        callToClassify.MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task Run_ShouldRetryWhenRequestIsRetriableAsync()
    {
        // Setup
        const int expectedValue = 5;
        var expectedResult = new TestRequestResult<int>(expectedValue);
        var ex = new TestShopifyException();
        var policy = SetupPolicy();
        var iteration = 0;

        var callToInvokeRequest = A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage));
        callToInvokeRequest.Returns(expectedResult);
        callToInvokeRequest.Invokes(_ =>
        {
            iteration++;
            if (iteration < 4)
                throw ex;
        });

        A.CallTo(() => _responseClassifier.IsRetriableException(ex, An<int>._))
            .ReturnsLazily(call => call.Arguments.Get<int>(1) < 4);

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert
        var result = await act.Should().NotThrowAsync();
        result.Subject.Should().NotBeNull();
        result.Subject.Result.Should().Be(expectedValue);
        iteration.Should().Be(4);

        callToInvokeRequest.MustHaveHappened()
            .Then(A.CallTo(() => _responseClassifier.IsRetriableException(ex, 1)).MustHaveHappenedOnceExactly())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(100.ms(), A<CancellationToken>._)).MustHaveHappenedOnceExactly())
            .Then(callToInvokeRequest.MustHaveHappened())
            .Then(A.CallTo(() => _responseClassifier.IsRetriableException(ex, 2)).MustHaveHappenedOnceExactly())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(200.ms(), A<CancellationToken>._)).MustHaveHappenedOnceExactly())
            .Then(callToInvokeRequest.MustHaveHappened())
            .Then(A.CallTo(() => _responseClassifier.IsRetriableException(ex, 3)).MustHaveHappenedOnceExactly())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(400.ms(), A<CancellationToken>._)).MustHaveHappenedOnceExactly())
            .Then(callToInvokeRequest.MustHaveHappened());
    }

    [Fact]
    public async Task Run_ShouldRetryImmediatelyWhenConfigured()
    {
        // Setup
        const bool firstRetryIsImmediate = true;
        var policy = SetupPolicy(x => x.FirstRetryIsImmediate = firstRetryIsImmediate);
        var ex = new TestShopifyException();
        var iteration = 0;

        A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage))
            .Invokes(_ =>
            {
                if (iteration >= 3) throw new TestException();
                iteration++;
                throw ex;
            });
        A.CallTo(() => _responseClassifier.IsRetriableException(ex, An<int>._))
            .Returns(true);

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<TestException>();
        iteration.Should().Be(3);

        A.CallTo(() => _taskScheduler.DelayAsync(TimeSpan.Zero, A<CancellationToken>._)).MustHaveHappenedOnceExactly()
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(100.ms(), A<CancellationToken>._)).MustHaveHappenedOnceExactly())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(200.ms(), A<CancellationToken>._)).MustHaveHappenedOnceExactly());
    }

    [Fact(Timeout = 1000)]
    public async Task Run_ShouldHandleNullMaxRetries()
    {
        // Setup
        const int expectedIterations = 20;
        var policy = SetupPolicy(x =>
        {
            x.MaximumRetriesBeforeRequestCancellation = null;
            x.MaximumDelayBeforeRequestCancellation = TimeSpan.FromSeconds(5);
        });
        var ex = new TestShopifyException();
        var iteration = 0;

        var callToExecute = A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage));
        callToExecute.Invokes(_ =>
        {
            iteration++;
            // Cancel after 20 loops
            if (iteration == expectedIterations)
                throw new TestException();
            throw ex;
        });

        A.CallTo(() => _responseClassifier.IsRetriableException(ex, An<int>.That.Matches(x => x == iteration)))
            .Returns(true);

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<TestException>();
        iteration.Should().Be(expectedIterations);

        callToExecute.MustHaveHappened(expectedIterations, Times.Exactly);
        // These will receive one less call, because TestException is not caught by the policy and crashes/exits the run
        A.CallTo(() => _responseClassifier.IsRetriableException(ex, An<int>.That.Matches(x => x >= 1 && x <= iteration)))
            .MustHaveHappened(expectedIterations - 1, Times.Exactly);
        A.CallTo(() => _taskScheduler.DelayAsync(A<TimeSpan>._, A<CancellationToken>._))
            .MustHaveHappened(expectedIterations - 1, Times.Exactly);
    }

    [Fact]
    public async Task Run_ShouldRetryUntilMaxRetriesIsReachedThenThrow()
    {
        // Setup
        const int maximumRetries = 2;
        var policy = SetupPolicy(x => x.MaximumRetriesBeforeRequestCancellation = maximumRetries);
        var ex = new TestShopifyException();
        var iteration = 0;

        var callToExecute = A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage));
        callToExecute.Invokes(_ =>
        {
            iteration++;
            throw ex;
        });

        A.CallTo(() => _responseClassifier.IsRetriableException(ex, An<int>.That.Matches(x => x == iteration)))
            .Returns(true);

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<ShopifyExponentialRetryCanceledException>()
            .Where(x => x.CurrentTry == maximumRetries)
            .Where(x => x.MaximumRetries == maximumRetries);

        iteration.Should().Be(maximumRetries);

        callToExecute.MustHaveHappened()
            .Then(A.CallTo(() => _responseClassifier.IsRetriableException(ex, 1)).MustHaveHappenedOnceExactly())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(100.ms(), A<CancellationToken>._)).MustHaveHappenedOnceExactly())
            .Then(callToExecute.MustHaveHappened())
            .Then(A.CallTo(() => _responseClassifier.IsRetriableException(ex, 2)).MustHaveHappenedOnceExactly());

        A.CallTo(() => _taskScheduler.DelayAsync(200.ms(), A<CancellationToken>._))
            .MustNotHaveHappened();
    }

    [Fact(Timeout = 1000)]
    public async Task Run_ShouldIncreaseDelayBetweenRetriesUntilItReachesMaximumDelayBetweenRetries_ThenUseMaximumDelayBetweenRetries()
    {
        // Setup
        const int backoffInMilliseconds = 50;
        const int expectedIterationsAfterReachingMaximum = 3;
        var ex = new TestShopifyException();
        var maximumDelayBetweenRetries = 777.ms();
        var policy = SetupPolicy(x =>
        {
            x.InitialBackoffInMilliseconds = backoffInMilliseconds;
            x.MaximumRetriesBeforeRequestCancellation = 100;
            x.MaximumDelayBetweenRetries = maximumDelayBetweenRetries;
            x.MaximumDelayBeforeRequestCancellation = TimeSpan.FromMinutes(1);
        });
        var currentDelaySeenCount = 0;

        A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage))
            .Throws(ex);
        A.CallTo(() => _responseClassifier.IsRetriableException(ex, An<int>._))
            .Returns(true);
        A.CallTo(() => _taskScheduler.DelayAsync(A<TimeSpan>._, A<CancellationToken>._))
            .Invokes(call =>
            {
                var currentDelay = call.Arguments.Get<TimeSpan>(0);
                // Cancel once the policy starts using the maximum delay multiple times
                if (currentDelay != maximumDelayBetweenRetries)
                    return;
                currentDelaySeenCount++;
                if (currentDelaySeenCount == expectedIterationsAfterReachingMaximum)
                    throw new TestException();
            });

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        // Assert
        await act.Should().ThrowAsync<TestException>();

        A.CallTo(() => _taskScheduler.DelayAsync(50.ms(), A<CancellationToken>._)).MustHaveHappened()
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(100.ms(), A<CancellationToken>._)).MustHaveHappened())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(200.ms(), A<CancellationToken>._)).MustHaveHappened())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(400.ms(), A<CancellationToken>._)).MustHaveHappened())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(777.ms(), A<CancellationToken>._)).MustHaveHappened(3, Times.Exactly));
    }

    [Fact(Skip = "Due to flakiness, this test should be rewritten to use the TimeProvider before running again in CI/CD")]
    public async Task Run_ShouldRetryUntilMaximumDelayIsReachedThenThrow()
    {
        // TODO: this test could be improved by using the Microsoft.BCL.TimeProvider package,
        //       which includes System.Threading.Tasks.TimeProviderThreadingExtensions for creating
        //       cancellation token sources with a timeout using a TimeProvider.
        // Setup
        const int maximumDelayMilliseconds = 0;
        const int maximumRetries = 100;
        var ex = new TestShopifyException();
        var timeout = new TimeSpan(maximumDelayMilliseconds);
        var policy = SetupPolicy(x =>
        {
            x.MaximumDelayBeforeRequestCancellation = timeout;
            x.MaximumRetriesBeforeRequestCancellation = maximumRetries;
        });
        var inputCancellationToken = CancellationToken.None;

        A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage))
            .Throws(ex);
        A.CallTo(() => _responseClassifier.IsRetriableException(ex, An<int>._))
            .Returns(true);

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, inputCancellationToken);

        // Assert
        await act.Should().ThrowAsync<OperationCanceledException>();
        // For now, we expect this test to execute the request, check the exception and wait. This
        // is because the cancellation token source puts the cancellation on a different thread when
        // cancellation is requested.
        // TODO: This seems to be a little bit flaky due to the comment above, sometimes the test receives a second _executeRequest before cancelling
        A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage)).MustHaveHappenedOnceExactly()
            .Then(A.CallTo(() => _responseClassifier.IsRetriableException(ex, 1)).MustHaveHappenedOnceExactly())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(BackoffInMilliseconds), A<CancellationToken>._)).MustHaveHappenedOnceExactly());
    }

    [Fact]
    public async Task Run_ShouldThrowWhenCancellationTokenIsCanceled()
    {
        // Setup
        const int maximumRetries = 100;
        var ex = new TestShopifyException();
        var inputCancellationToken = new CancellationTokenSource();
        var iteration = 0;
        var policy = SetupPolicy(x => x.MaximumRetriesBeforeRequestCancellation = maximumRetries);

        var callToExecute = A.CallTo(() => _executeRequest.Invoke(_cloneableRequestMessage));
        callToExecute.Invokes(() =>
        {
            iteration++;
            if (iteration > 1)
                inputCancellationToken.Cancel(true);
            throw ex;
        });

        A.CallTo(() => _responseClassifier.IsRetriableException(ex, An<int>._))
            .Returns(true);

        // Act
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, inputCancellationToken.Token);

        // Assert
        await act.Should().ThrowAsync<OperationCanceledException>();

        callToExecute.MustHaveHappened()
            .Then(A.CallTo(() => _responseClassifier.IsRetriableException(ex, 1)).MustHaveHappened())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(100.ms(), A<CancellationToken>._)).MustHaveHappened())
            .Then(callToExecute.MustHaveHappened())
            .Then(A.CallTo(() => _responseClassifier.IsRetriableException(ex, 2)).MustHaveHappened())
            .Then(A.CallTo(() => _taskScheduler.DelayAsync(200.ms(), A<CancellationToken>._)).MustHaveHappened());

        A.CallTo(() => _taskScheduler.DelayAsync(400.ms(), A<CancellationToken>._))
            .MustNotHaveHappened();
    }
}
