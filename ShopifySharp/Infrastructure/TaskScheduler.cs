using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure;

internal interface ITaskScheduler
{
    /// <inheritdoc cref="Task.Delay(TimeSpan)"/>
    public Task DelayAsync(TimeSpan length, CancellationToken cancellationToken = default);
}

/// A tiny utility that wraps <seealso cref="Task.Delay(TimeSpan)"/> so that it can be mocked in unit tests.
internal class TaskScheduler : ITaskScheduler
{
    public Task DelayAsync(TimeSpan length, CancellationToken cancellationToken = default) =>
        Task.Delay(length, cancellationToken);
}
