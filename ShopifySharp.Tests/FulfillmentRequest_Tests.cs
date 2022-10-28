using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "FulfillmentRequest")]
    public class FulfillmentRequest_Tests : IClassFixture<FulfillmentRequest_Tests_Fixture>
    {
        private FulfillmentRequest_Tests_Fixture Fixture { get; }

        public FulfillmentRequest_Tests(FulfillmentRequest_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact(Skip = "Fulfillment Orders/Requests cannot be used until the app migrates from fulfillments to fulfillment orders. https://shopify.dev/apps/fulfillment/migrate")]
        public async Task Accept_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.ListFulfillmentOrders(order.Id.Value);
            var fulfillmentOrder = fulfillmentOrders.First();
            var result = await Fixture.Service.AcceptAsync(fulfillmentOrder.Id.Value, "Unit Test: Accepted", CancellationToken.None);

            Assert.NotNull(result);
        }

        [Fact(Skip = "Fulfillment Orders/Requests cannot be used until the app migrates from fulfillments to fulfillment orders. https://shopify.dev/apps/fulfillment/migrate")]
        public async Task Reject_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.ListFulfillmentOrders(order.Id.Value);
            var fulfillmentOrder = fulfillmentOrders.First();
            var result = await Fixture.Service.RejectAsync(fulfillmentOrder.Id.Value, "Unit Test: Rejected", CancellationToken.None);

            Assert.NotNull(result);
        }
    }
    public class FulfillmentRequest_Tests_Fixture : IAsyncLifetime
    {
        public readonly FulfillmentRequestService Service = new FulfillmentRequestService(Utils.MyShopifyUrl, Utils.AccessToken);

        public readonly FulfillmentService FulfillmentService = new FulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);

        public readonly FulfillmentOrderService FulfillmentOrderService = new FulfillmentOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        public readonly OrderService OrderService = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        public readonly LocationService LocationService = new LocationService(Utils.MyShopifyUrl, Utils.AccessToken);

        public long LocationId { get; private set; }

        /// <summary>
        /// Fulfillments must be part of an order and cannot be deleted.
        /// </summary>
        public List<Order> CreatedOrders { get; } = new List<Order>();

        public List<Fulfillment> CreatedFulfillments { get; } = new List<Fulfillment>();

        public async Task InitializeAsync()
        {
            // Fulfillment API has a stricter rate limit when on a non-paid store.
            var policy = new LeakyBucketExecutionPolicy();

            Service.SetExecutionPolicy(policy);
            FulfillmentService.SetExecutionPolicy(policy);
            FulfillmentOrderService.SetExecutionPolicy(policy);
            OrderService.SetExecutionPolicy(policy);
            LocationService.SetExecutionPolicy(policy);

            // Get a location id to use in these tests
            var locations = await LocationService.ListAsync();
            LocationId = locations.First().Id.Value;
        }

        public async Task DisposeAsync()
        {
            foreach (var order in CreatedOrders)
            {
                try
                {
                    await OrderService.DeleteAsync(order.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    Console.WriteLine($"Failed to delete order with id {order.Id.Value}. {ex.Message}");
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
                Test = true
            }, new OrderCreateOptions()
            {
                SendReceipt = false,
                SendFulfillmentReceipt = false
            });

            CreatedOrders.Add(obj);

            return obj;
        }

        public async Task<IEnumerable<FulfillmentOrder>> ListFulfillmentOrders(long orderId)
        {
            var orders = await FulfillmentOrderService.ListAsync(orderId);

            return orders;
        }

        public async Task<Fulfillment> CreateFulfillment(long orderId)
        {
            var fulfillmentOrders = await ListFulfillmentOrders(orderId);
            var fulfillment = await FulfillmentService.CreateAsync(new FulfillmentShipping
            {
                Message = "Items are shipping now!",
                FulfillmentRequestOrderLineItems = fulfillmentOrders.Select(o => new LineItemsByFulfillmentOrder
                {
                    FulfillmentOrderId = o.Id.Value
                }),
                NotifyCustomer = false,
                TrackingInfo = new TrackingInfo
                {
                    Company = "Jack Black's Pack, Stack and Track",
                    Url = "https://example.com/123456789",
                    Number = "123456789"
                }
            });

            CreatedFulfillments.Add(fulfillment);

            return fulfillment;
        }
    }
}
