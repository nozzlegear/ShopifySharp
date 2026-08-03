using ShopifySharp.Filters;

namespace ShopifySharp.Tests.Integration.Rest;

[Trait("Category", "Event")]
public class EventTests(EventTestsFixture fixture) : IClassFixture<EventTestsFixture>
{
    private EventTestsFixture Fixture { get; } = fixture;

    [Fact]
    public async Task Counts_Events()
    {
        // Act
        var count = await Fixture.Service.CountAsync(cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        count.Should().BeGreaterThan(0);
    }

    [Fact]
    public async Task Lists_Events()
    {
        // Act
        var list = await Fixture.Service.ListAsync(cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        list.Items.Should().NotBeEmpty();
    }

    [Fact]
    public async Task Lists_Events_For_Subjects()
    {
        // Setup
        const string subject = "Order";
        var orders = await Fixture.OrderService.ListAsync(new OrderListFilter
        {
            Limit = 1
        }, TestContext.Current.CancellationToken);
        var orderId = orders.Items.First().Id!.Value;

        // Act
        var list = await Fixture.Service.ListAsync(orderId, subject, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        list.Should().NotBeNull();
        list.Items.Should().AllSatisfy(e => e.SubjectType.Should().Be(subject));
    }

    [Fact]
    public async Task Gets_Events()
    {
        // Setup
        var list = await Fixture.Service.ListAsync(filter: new EventListFilter()
        {
            Limit = 1
        }, cancellationToken: TestContext.Current.CancellationToken);

        // Act
        var evt = await Fixture.Service.GetAsync(list.Items.First().Id!.Value, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        evt.Should().NotBeNull();
        evt.Author.Should().NotBeNullOrEmpty();
        evt.CreatedAt.Should().HaveValue().And.NotBe(DateTimeOffset.MinValue);
        evt.SubjectId.Should().BeGreaterThan(0);
        evt.SubjectType.Should().NotBeNullOrEmpty();
        evt.Verb.Should().NotBeNullOrEmpty();

        // Depending on the type, events may not always have a message
        // Assert.NotNull(evt.Message);
    }
}

public class EventTestsFixture : IAsyncLifetime
{
    public EventService Service { get; } = new(Utils.MyShopifyUrl, Utils.AccessToken);

    public OrderService OrderService { get; } = new(Utils.MyShopifyUrl, Utils.AccessToken);

    public ValueTask InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy(false);

        Service.SetExecutionPolicy(policy);
        OrderService.SetExecutionPolicy(policy);

        return ValueTask.CompletedTask;
    }

    public ValueTask DisposeAsync()
    {
        return ValueTask.CompletedTask;
    }
}
