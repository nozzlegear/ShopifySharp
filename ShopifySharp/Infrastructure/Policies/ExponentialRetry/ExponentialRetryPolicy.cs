#nullable enable
using System;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;
using TaskScheduler = ShopifySharp.Infrastructure.TaskScheduler;

namespace ShopifySharp;

/// A request execution policy that retries failed requests with an exponentially increasing delay between each retry.
/// The policy can be configured with a maximum number of retries, a maximum time period before the request should be canceled,
/// or both.
public class ExponentialRetryPolicy : IRequestExecutionPolicy
{
    private readonly ExponentialRetryPolicyOptions _options;
    private readonly IResponseClassifier _responseClassifier;
    private readonly ITaskScheduler _taskScheduler = new TaskScheduler();

    // ReSharper disable once MemberCanBePrivate.Global
    public ExponentialRetryPolicy(ExponentialRetryPolicyOptions options)
    {
        options.Validate();
        _options = options;
        _responseClassifier = new ResponseClassifier(true, options.MaximumRetriesBeforeRequestCancellation ?? int.MaxValue);
    }

    internal ExponentialRetryPolicy(
        ExponentialRetryPolicyOptions options,
        IResponseClassifier responseClassifier,
        ITaskScheduler taskScheduler
    ) : this(options)
    {
        _responseClassifier = responseClassifier;
        _taskScheduler = taskScheduler;
    }

    public async Task<RequestResult<T>> Run<T>(
        CloneableRequestMessage requestMessage,
        ExecuteRequestAsync<T> executeRequestAsync,
        CancellationToken cancellationToken,
        int? graphqlQueryCost = null)
    {
        var currentTry = 1;
        var useMaximumDelayBetweenRetries = false;
        var clonedRequestMessage = requestMessage;
        var combinedCancellationToken = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

        if (_options.MaximumDelayBeforeRequestCancellation is not null)
            combinedCancellationToken.CancelAfter(_options.MaximumDelayBeforeRequestCancellation.Value);

        while (true)
        {
            combinedCancellationToken.Token.ThrowIfCancellationRequested();

            try
            {
                var value = await executeRequestAsync.Invoke(clonedRequestMessage);
                return value;
            }
            catch (ShopifyException ex)
            {
                if (!_responseClassifier.IsRetriableException(ex, currentTry))
                {
                    throw;
                }
            }

            if (_options.MaximumRetriesBeforeRequestCancellation is not null && currentTry + 1 > _options.MaximumRetriesBeforeRequestCancellation)
                throw new ShopifyExponentialRetryCanceledException(currentTry, _options);

            // We can quickly hit an overflow by using exponential math to calculate a delay and pass it to the timespan constructor.
            // To avoid that, we check to see if one of the previous loops' delays passed the maximum delay between retries. If so,
            // we use the maximum delay rather than calculating another one and potentially hitting that overflow.
            TimeSpan nextDelay;

            if (useMaximumDelayBetweenRetries)
            {
                nextDelay = _options.MaximumDelayBetweenRetries;
            }
            else
            {
                try
                {
                    nextDelay = TimeSpan.FromMilliseconds(Math.Pow(2, currentTry - 1) * _options.InitialBackoffInMilliseconds);

                    if (nextDelay > _options.MaximumDelayBetweenRetries)
                    {
                        nextDelay = _options.MaximumDelayBetweenRetries;
                    }
                }
                catch (OverflowException)
                {
                    // TODO: add logging here once ShopifySharp supports it
                    useMaximumDelayBetweenRetries = true;
                    nextDelay = _options.MaximumDelayBetweenRetries;
                }
            }

            currentTry++;

            // Delay and then try again
            await _taskScheduler.DelayAsync(nextDelay, combinedCancellationToken.Token);
            clonedRequestMessage = await requestMessage.CloneAsync();
        }
    }
}
