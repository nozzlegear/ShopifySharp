using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using ShopifySharp.Infrastructure.Policies.LeakyBucketPolicy;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "LeakyBucket"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
public class LeakyBucket_Tests
{
    private DateTime now;

    [Fact]
    public void RunSynchronouslyIfEnoughAvailable()
    {
        now = DateTime.UtcNow;

        var b = new LeakyBucket(40, 2, () => now);
        Assert.Equal(40, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(1).IsCompleted);
        Assert.Equal(39, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(1).IsCompleted);
        Assert.Equal(38, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(1).IsCompleted);
        Assert.Equal(37, b.ComputedCurrentlyAvailable);

        now = now.AddSeconds(1);
        Assert.Equal(39, b.ComputedCurrentlyAvailable);
    }

    [Fact]
    public void WaitIfNotEnoughAvailable()
    {
        now = DateTime.UtcNow;

        var b = new LeakyBucket(10, 2, () => now);
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
        now = DateTime.UtcNow;

        var b = new LeakyBucket(10, 2, () => now);
        Assert.Equal(10, b.ComputedCurrentlyAvailable);

        Assert.True(b.WaitForAvailableAsync(5).IsCompleted);
        Assert.Equal(5, b.ComputedCurrentlyAvailable);

        now = now.AddSeconds(1);
        Assert.Equal(7, b.ComputedCurrentlyAvailable);

        now = now.AddSeconds(1);
        Assert.Equal(9, b.ComputedCurrentlyAvailable);

        now = now.AddSeconds(1);
        Assert.Equal(10, b.ComputedCurrentlyAvailable);

        b.SetState(20, 3, b.ComputedCurrentlyAvailable);
        now = now.AddSeconds(1);
        Assert.Equal(13, b.ComputedCurrentlyAvailable);

        now = now.AddSeconds(2);
        Assert.Equal(19, b.ComputedCurrentlyAvailable);

        now = now.AddSeconds(1);
        Assert.Equal(20, b.ComputedCurrentlyAvailable);
    }

    [Fact]
    public async Task BlockedSingleCallsCompleteAfterEnoughTime()
    {
        now = DateTime.UtcNow;

        var b = new LeakyBucket(10, 2, () => now);
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
        now = DateTime.UtcNow;

        var b = new LeakyBucket(10, 2, () => now);
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

        now = now.AddSeconds(5);
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
        now = now.AddSeconds(seconds);
        await Task.Delay(TimeSpan.FromSeconds(seconds * 1.2));
    }
}
