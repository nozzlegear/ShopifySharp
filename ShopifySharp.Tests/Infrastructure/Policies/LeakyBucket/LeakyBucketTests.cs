using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Xunit;
using Bucket = ShopifySharp.Infrastructure.Policies.LeakyBucket.LeakyBucket;

namespace ShopifySharp.Tests.Infrastructure.Policies.LeakyBucket;

[Trait("Category", "LeakyBucket"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
[TestSubject(typeof(Bucket))]
public class LeakyBucketTests
{
    private DateTime _now;

    [Fact]
    public void RunSynchronouslyIfEnoughAvailable()
    {
        _now = DateTime.UtcNow;

        var b = new Bucket(40, 2, () => _now);
        Assert.Equal(40, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(1).IsCompleted);
        Assert.Equal(39, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(1).IsCompleted);
        Assert.Equal(38, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(1).IsCompleted);
        Assert.Equal(37, b.ComputedCurrentlyAvailable);

        _now = _now.AddSeconds(1);
        Assert.Equal(39, b.ComputedCurrentlyAvailable);
    }

    [Fact]
    public void WaitIfNotEnoughAvailable()
    {
        _now = DateTime.UtcNow;

        var b = new Bucket(10, 2, () => _now);
        Assert.Equal(10, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(9).IsCompleted);
        Assert.Equal(1, b.ComputedCurrentlyAvailable);

        Assert.False(b.WaitForAvailableAsync(4).IsCompleted);
        Assert.Equal(1, b.ComputedCurrentlyAvailable);

        Assert.False(b.WaitForAvailableAsync(5).IsCompleted);
        Assert.Equal(1, b.ComputedCurrentlyAvailable);
    }

    [Fact]
    public void ReplenishUpToMaximum()
    {
        _now = DateTime.UtcNow;

        var b = new Bucket(10, 2, () => _now);
        Assert.Equal(10, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(5).IsCompleted);
        Assert.Equal(5, b.ComputedCurrentlyAvailable);

        _now = _now.AddSeconds(1);
        Assert.Equal(7, b.ComputedCurrentlyAvailable);

        _now = _now.AddSeconds(1);
        Assert.Equal(9, b.ComputedCurrentlyAvailable);

        _now = _now.AddSeconds(1);
        Assert.Equal(10, b.ComputedCurrentlyAvailable);

        b.SetState(20, 3, b.ComputedCurrentlyAvailable);
        _now = _now.AddSeconds(1);
        Assert.Equal(13, b.ComputedCurrentlyAvailable);

        _now = _now.AddSeconds(2);
        Assert.Equal(19, b.ComputedCurrentlyAvailable);

        _now = _now.AddSeconds(1);
        Assert.Equal(20, b.ComputedCurrentlyAvailable);
    }

    [Fact]
    public async Task BlockedSingleCallsCompleteAfterEnoughTime()
    {
        _now = DateTime.UtcNow;

        var b = new Bucket(10, 2, () => _now);
        Assert.Equal(10, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(5).IsCompleted);
        Assert.Equal(5, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(4).IsCompleted);
        Assert.Equal(1, b.ComputedCurrentlyAvailable);

        Task task = b.WaitForAvailableAsync(3);
        Assert.False(task.IsCompleted);
        Assert.Equal(1, b.ComputedCurrentlyAvailable);

        await PassSeconds(2);
        Assert.True(task.IsCompleted);
        Assert.Equal(2, b.ComputedCurrentlyAvailable);
    }

    [Fact]
    public async Task BlockedMultipleCallsCompleteAfterEnoughTime()
    {
        _now = DateTime.UtcNow;

        var b = new Bucket(10, 2, () => _now);
        Assert.Equal(10, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(9).IsCompleted);
        Assert.Equal(1, b.ComputedCurrentlyAvailable);

        var task1 = b.WaitForAvailableAsync(3);
        Assert.False(task1.IsCompleted);

        var task2 = b.WaitForAvailableAsync(3);
        Assert.False(task2.IsCompleted);

        var task3 = b.WaitForAvailableAsync(3);
        Assert.False(task3.IsCompleted);

        Assert.Equal(1, b.ComputedCurrentlyAvailable);

        await PassSeconds(1);
        Assert.True(task1.IsCompleted);
        Assert.False(task2.IsCompleted);
        Assert.False(task3.IsCompleted);
        Assert.Equal(0, b.ComputedCurrentlyAvailable);

        await PassSeconds(2);
        Assert.True(task2.IsCompleted);
        Assert.False(task3.IsCompleted);
        Assert.Equal(1, b.ComputedCurrentlyAvailable);

        await PassSeconds(1);
        Assert.True(task3.IsCompleted);
        Assert.Equal(0, b.ComputedCurrentlyAvailable);

        _now = _now.AddSeconds(5);
        Assert.Equal(10, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(4).IsCompleted);
        Assert.Equal(6, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(4).IsCompleted);
        Assert.Equal(2, b.ComputedCurrentlyAvailable);

        var task4 = b.WaitForAvailableAsync(4);
        Assert.False(task4.IsCompleted);
        Assert.Equal(2, b.ComputedCurrentlyAvailable);

        await PassSeconds(1);
        Assert.True(task4.IsCompleted);
        Assert.Equal(0, b.ComputedCurrentlyAvailable);
    }

    private async Task PassSeconds(int seconds)
    {
        _now = _now.AddSeconds(seconds);
        await Task.Delay(TimeSpan.FromSeconds(seconds * 1.2));
    }
}
