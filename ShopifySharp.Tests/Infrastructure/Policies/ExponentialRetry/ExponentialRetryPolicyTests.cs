using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using JetBrains.Annotations;
using NSubstitute;
using NSubstitute.Core;
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

    public ExponentialRetryPolicyTests()
    {
        _responseClassifier = Substitute.For<IResponseClassifier>();
        _taskScheduler = Substitute.For<ITaskScheduler>();
        _executeRequest = Substitute.For<ExecuteRequestAsync<int>>();

        // Always return a completed task when the scheduler wants to delay, so no actual time is spent waiting during a test
        _taskScheduler.DelayAsync(Arg.Any<TimeSpan>())
            .Returns(Task.CompletedTask);
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
        var request = new TestCloneableRequestMessage();
        var expectedResult = new TestRequestResult<int>(expectedValue);

        _executeRequest.Invoke(request)
            .Returns(expectedResult);

        var policy = SetupPolicy();
        var result = await policy.Run(request, _executeRequest, CancellationToken.None);

        result.Should().NotBeNull();
        result.Result.Should().Be(expectedValue);
    }

    [Fact]
    public async Task Run_ShouldDisposeClonedRequestMessages()
    {
        _cloneableRequestMessage.When(x => x.Dispose())
            .Throw<TestException>();

        var policy = SetupPolicy();
        var act = () => policy.Run(_cloneableRequestMessage, _executeRequest, CancellationToken.None);

        await act.Should().ThrowAsync<TestException>();
        _cloneableRequestMessage.Received(1).Dispose();
    }

    [Fact]
    public async Task Run_ShouldThrowWhenRequestIsNotRetriableAsync()
    {
        var ex = new TestShopifyException();
        var request = Substitute.For<TestCloneableRequestMessage>();

        _executeRequest.When(x => x.Invoke(request))
            .Throw(ex);
        _responseClassifier.IsRetriableException(ex, 1)
            .Returns(false);

        var policy = SetupPolicy();
        var act = () => policy.Run(request, _executeRequest, CancellationToken.None);

        await act.Should().ThrowAsync<TestShopifyException>();
        _responseClassifier.Received(1).IsRetriableException(ex, 1);
    }

    [Fact]
    public async Task Run_ShouldRetryWhenRequestIsRetriableAsync()
    {
        const int expectedValue = 5;
        var request = new TestCloneableRequestMessage();
        var expectedResult = new TestRequestResult<int>(expectedValue);
        var ex = new TestShopifyException();
        var iteration = 0;

        _executeRequest(Arg.Any<CloneableRequestMessage>())
            .Returns(expectedResult);
        _executeRequest.When(x => x.Invoke(Arg.Any<CloneableRequestMessage>()))
            .Do(_ =>
            {
                iteration++;
                if (iteration < 4)
                    throw ex;
            });

        _responseClassifier.IsRetriableException(ex, Arg.Is<int>(x => x < 4))
            .Returns(true);
        _responseClassifier.IsRetriableException(ex, Arg.Is<int>(x => x >= 4))
            .Returns(false);

        var policy = SetupPolicy();
        var act = () => policy.Run(request, _executeRequest, CancellationToken.None);

        var result = await act.Should().NotThrowAsync();
        result.Subject.Should().NotBeNull();
        result.Subject.Result.Should().Be(expectedValue);
        iteration.Should().Be(4);
        Received.InOrder(() =>
        {
            _executeRequest.Invoke(request);
            _responseClassifier.IsRetriableException(ex, 1);
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(100), Arg.Any<CancellationToken>());

            _executeRequest.Invoke(Arg.Any<CloneableRequestMessage>());
            _responseClassifier.IsRetriableException(ex, 2);
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(200), Arg.Any<CancellationToken>());

            _executeRequest.Invoke(Arg.Any<CloneableRequestMessage>());
            _responseClassifier.IsRetriableException(ex, 3);
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(400), Arg.Any<CancellationToken>());

            _executeRequest.Invoke(Arg.Any<CloneableRequestMessage>());
        });
    }

    [Fact(Timeout = 1000)]
    public async Task Run_ShouldHandleNullMaxRetries()
    {
        const int expectedIterations = 20;
        var ex = new TestShopifyException();
        var request = new TestCloneableRequestMessage();
        var iteration = 0;

        _executeRequest.When(x => x.Invoke(Arg.Any<CloneableRequestMessage>()))
            .Do(_ =>
            {
                iteration++;
                    // Cancel after 20 loops
                    if (iteration == expectedIterations)
                        throw new TestException();
                throw ex;
            });

        _responseClassifier.IsRetriableException(ex, Arg.Is<int>(x => x == iteration))
            .Returns(true);

        var policy = SetupPolicy(x =>
        {
            x.MaximumRetriesBeforeRequestCancellation = null;
            x.MaximumDelayBeforeRequestCancellation = TimeSpan.FromSeconds(5);
        });
        var act = () => policy.Run(request, _executeRequest, CancellationToken.None);

        await act.Should().ThrowAsync<TestException>();
        iteration.Should().Be(expectedIterations);
        await _executeRequest.Received(expectedIterations).Invoke(Arg.Any<CloneableRequestMessage>());
        // These will receive one less call, because TestException is not caught by the policy and crashes/exits the run
        _responseClassifier.Received(expectedIterations - 1).IsRetriableException(ex, Arg.Is<int>(x => x >= 1 && x <= expectedIterations));
        await _taskScheduler.Received(expectedIterations - 1).DelayAsync(Arg.Any<TimeSpan>(), Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Run_ShouldRetryUntilMaxRetriesIsReachedThenThrow()
    {
        const int maximumRetries = 2;
        var ex = new TestShopifyException();
        var request = new TestCloneableRequestMessage();
        var iteration = 0;

        _executeRequest.When(x => x.Invoke(Arg.Any<CloneableRequestMessage>()))
            .Do(_ =>
            {
                iteration++;
                throw ex;
            });

        _responseClassifier.IsRetriableException(ex, Arg.Is<int>(x => x == iteration))
            .Returns(true);

        var policy = SetupPolicy(x => x.MaximumRetriesBeforeRequestCancellation = maximumRetries);
        var act = () => policy.Run(request, _executeRequest, CancellationToken.None);

        await act.Should().ThrowAsync<ShopifyExponentialRetryCanceledException>()
            .Where(x => x.CurrentTry == maximumRetries)
            .Where(x => x.MaximumRetries == maximumRetries);
        iteration.Should().Be(maximumRetries);
        Received.InOrder(() =>
        {
            _executeRequest.Invoke(request);
            _responseClassifier.IsRetriableException(ex, 1);
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(100), Arg.Any<CancellationToken>());

            _executeRequest.Invoke(Arg.Any<CloneableRequestMessage>());
            _responseClassifier.IsRetriableException(ex, 2);
        });
        await _taskScheduler.Received(0)
            .DelayAsync(TimeSpan.FromMilliseconds(200), Arg.Any<CancellationToken>());
    }

    [Fact(Timeout = 1000)]
    public async Task Run_ShouldIncreaseDelayBetweenRetriesUntilItReachesMaximumDelayBetweenRetries_ThenUseMaximumDelayBetweenRetries()
    {
        const int backoffInMilliseconds = 50;
        const int expectedIterationsAfterReachingMaximum = 3;
        var ex = new TestShopifyException();
        var request = new TestCloneableRequestMessage();
        var maximumDelayBetweenRetries = TimeSpan.FromMilliseconds(777);
        var currentDelaySeenCount = 0;

        _executeRequest.When(x => x.Invoke(Arg.Any<CloneableRequestMessage>()))
            .Throw(ex);
        _responseClassifier.IsRetriableException(ex, Arg.Any<int>())
            .Returns(true);
        _taskScheduler.When(x => x.DelayAsync(Arg.Any<TimeSpan>(), Arg.Any<CancellationToken>()))
            .Do(x =>
            {
                var currentDelay = x.Arg<TimeSpan>();
                // Cancel once the policy starts using the maximum delay multiple times
                if (currentDelay == maximumDelayBetweenRetries)
                {
                    currentDelaySeenCount++;
                    if (currentDelaySeenCount == expectedIterationsAfterReachingMaximum)
                    {
                        throw new TestException();
                    }
                }
            });

        var policy = SetupPolicy(x =>
        {
            x.InitialBackoffInMilliseconds = backoffInMilliseconds;
            x.MaximumRetriesBeforeRequestCancellation = null;
            x.MaximumDelayBetweenRetries = maximumDelayBetweenRetries;
            x.MaximumDelayBeforeRequestCancellation = TimeSpan.FromMinutes(1);
        });
        var act = () => policy.Run(request, _executeRequest, CancellationToken.None);

        await act.Should().ThrowAsync<TestException>();
        Received.InOrder(() =>
        {
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(50), Arg.Any<CancellationToken>());
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(100), Arg.Any<CancellationToken>());
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(200), Arg.Any<CancellationToken>());
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(400), Arg.Any<CancellationToken>());
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(777), Arg.Any<CancellationToken>());
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(777), Arg.Any<CancellationToken>());
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(777), Arg.Any<CancellationToken>());
        });
    }

    [Fact]
    public async Task Run_ShouldRetryUntilMaximumDelayIsReachedThenThrow()
    {
        // TODO: this test could be improved by using the Microsoft.BCL.TimeProvider package,
        //       which includes System.Threading.Tasks.TimeProviderThreadingExtensions for creating
        //       cancellation token sources with a timeout using a TimeProvider.
        const int maximumDelayMilliseconds = 0;
        const int maximumRetries = 100;
        var ex = new TestShopifyException();
        var request = new TestCloneableRequestMessage();
        var timeout = new TimeSpan(maximumDelayMilliseconds);
        var inputCancellationToken = CancellationToken.None;

        _executeRequest.When(x => x.Invoke(Arg.Any<CloneableRequestMessage>()))
            .Throw(ex);

        _responseClassifier.IsRetriableException(ex, Arg.Any<int>())
            .Returns(true);

        var policy = SetupPolicy(x =>
        {
            x.MaximumDelayBeforeRequestCancellation = timeout;
            x.MaximumRetriesBeforeRequestCancellation = maximumRetries;
        });
        var act = () => policy.Run(request, _executeRequest, inputCancellationToken);

        await act.Should().ThrowAsync<OperationCanceledException>();
        // For now, we expect this test to execute the request, check the exception and wait. This
        // is because the cancellation token source puts the cancellation on a different thread when
        // cancellation is requested.
        Received.InOrder(() =>
        {
            _executeRequest.Invoke(request);
            _responseClassifier.IsRetriableException(ex, 1);
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(BackoffInMilliseconds), Arg.Any<CancellationToken>());
        });
    }

    [Fact]
    public async Task Run_ShouldThrowWhenCancellationTokenIsCanceled()
    {
        const int maximumRetries = 100;
        var ex = new TestShopifyException();
        var request = new TestCloneableRequestMessage();
        var inputCancellationToken = new CancellationTokenSource();
        var iteration = 0;

        _executeRequest.When(x => x.Invoke(Arg.Any<CloneableRequestMessage>()))
            .Do(_ =>
            {
                iteration++;
                if (iteration > 1)
                    inputCancellationToken.Cancel(true);
                throw ex;
            });
        _responseClassifier.IsRetriableException(ex, Arg.Any<int>())
            .Returns(true);

        var policy = SetupPolicy(x => x.MaximumRetriesBeforeRequestCancellation = maximumRetries);
        var act = () => policy.Run(request, _executeRequest, inputCancellationToken.Token);

        await act.Should().ThrowAsync<OperationCanceledException>();
        Received.InOrder(() =>
        {
            _executeRequest.Invoke(request);
            _responseClassifier.IsRetriableException(ex, 1);
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(100), Arg.Any<CancellationToken>());

            _executeRequest.Invoke(Arg.Any<CloneableRequestMessage>());
            _responseClassifier.IsRetriableException(ex, 2);
            _taskScheduler.DelayAsync(TimeSpan.FromMilliseconds(200), Arg.Any<CancellationToken>());
        });
        await _taskScheduler.Received(0).DelayAsync(TimeSpan.FromMilliseconds(400), Arg.Any<CancellationToken>());
    }
}
