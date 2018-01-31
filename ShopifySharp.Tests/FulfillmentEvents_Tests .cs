using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "FulfillmentEvent")]
    public class FulfillmentEvents_Tests : IClassFixture<FulfillmentEvents_Tests_Fixture>
    {
        private FulfillmentEvents_Tests_Fixture Fixture { get; }

        public FulfillmentEvents_Tests(FulfillmentEvents_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Lists_FulfillmentEvents()
        {
            long orderId = Fixture.Created.First().OrderId.Value;
            long fulfillmentId = Fixture.Created.First().Id.Value;
            var list = await Fixture.Service.ListAsync(orderId, fulfillmentId);
            Assert.True(list != null);
        }
    }

    public class FulfillmentEvents_Tests_Fixture : IAsyncLifetime
    {
        public FulfillmentEventService Service { get; } = new FulfillmentEventService(Utils.MyShopifyUrl, Utils.AccessToken);

        public FulfillmentService FulfillmentService { get; } = new FulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);

        public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        /// <summary>
        /// Fulfillments must be part of an order and cannot be deleted.
        /// </summary>
        public List<Order> CreatedOrders { get; } = new List<Order>();

        public List<Fulfillment> Created { get; } = new List<Fulfillment>();

        public async Task InitializeAsync()
        {
            // Fulfillment API has a stricter rate limit when on a non-paid store.
            FulfillmentService.SetExecutionPolicy(new SmartRetryExecutionPolicy());

            // Create an order and fulfillment for count, list, get, etc. tests.
            var order = await CreateOrder();
            var fulfillment = await Create(order.Id.Value);
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in Created)
            {
                try
                {
                    await OrderService.DeleteAsync(obj.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    Console.WriteLine($"Failed to delete order with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }

        public async Task<Order> CreateOrder()
        {
            var obj = await OrderService.CreateAsync(new Order()
            {
                CreatedAt = DateTime.UtcNow,
                BillingAddress = new Address()
                {
                    Address1 = "123 4th Street",
                    City = "Minneapolis",
                    Province = "Minnesota",
                    ProvinceCode = "MN",
                    Zip = "55401",
                    Phone = "555-555-5555",
                    FirstName = "John",
                    LastName = "Doe",
                    Company = "Tomorrow Corporation",
                    Country = "United States",
                    CountryCode = "US",
                    Default = true,
                },
                LineItems = new List<LineItem>()
                {
                    new LineItem()
                    {
                        Name = "Test Line Item",
                        Title = "Test Line Item Title",
                        Quantity = 2,
                        Price = 5
                    },
                    new LineItem()
                    {
                        Name = "Test Line Item 2",
                        Title = "Test Line Item Title 2",
                        Quantity = 2,
                        Price = 5
                    }
                },
                FinancialStatus = "paid",
                TotalPrice = 5.00m,
                Email = Guid.NewGuid().ToString() + "@example.com",
                Note = "Test note about the customer.",
            }, new OrderCreateOptions()
            {
                SendReceipt = false,
                SendFulfillmentReceipt = false
            });

            CreatedOrders.Add(obj);

            return obj;
        }

        public async Task<Fulfillment> Create(long orderId, bool multipleTrackingNumbers = false, IEnumerable<LineItem> items = null)
        {
            Fulfillment fulfillment = new Fulfillment()
            {
                TrackingCompany = "Jack Black's Pack, Stack and Track",
                TrackingUrl = "https://example.com/123456789",
                TrackingNumber = "123456789",
                LineItems = CreatedOrders.First().LineItems
            };

            fulfillment = await FulfillmentService.CreateAsync(orderId, fulfillment, false);

            Created.Add(fulfillment);

            return fulfillment;
        }
    }
}
