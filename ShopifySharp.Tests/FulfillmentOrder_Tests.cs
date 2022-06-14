using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "FulfillmentOrder")]
    public class FulfillmentOrder_Tests : IClassFixture<FulfillmentOrder_Tests_Fixture>
    {
        private FulfillmentOrder_Tests_Fixture Fixture { get; }

        public FulfillmentOrder_Tests(FulfillmentOrder_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Lists_FulfillmentOrders()
        {
            var order = Fixture.CreatedOrders.First();
            var result = await Fixture.Service.ListAsync(order.Id.Value);
            
            Assert.NotNull(result);
        }
    }

    public class FulfillmentOrder_Tests_Fixture : IAsyncLifetime
    {
        public FulfillmentOrderService Service { get; } = new FulfillmentOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        
        public FulfillmentService FulfillmentService { get; } = new FulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);

        public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        public long LocationId => 6226758;

        /// <summary>
        /// Fulfillments must be part of an order and cannot be deleted.
        /// </summary>
        public List<Order> CreatedOrders { get; } = new List<Order>();

        public List<Fulfillment> CreatedFulfillments { get; } = new List<Fulfillment>();

        public async Task InitializeAsync()
        {
            // Fulfillment API has a stricter rate limit when on a non-paid store.
            var policy = new LeakyBucketExecutionPolicy();

            FulfillmentService.SetExecutionPolicy(policy);
            OrderService.SetExecutionPolicy(policy);

            // Create an order and fulfillment for count, list, get, etc. tests.
            var order = await CreateOrder();
            var fulfillment = await CreateFulfillment(order.Id.Value);
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in CreatedFulfillments)
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

        public async Task<Fulfillment> CreateFulfillment(long orderId, bool multipleTrackingNumbers = false, IEnumerable<LineItem> items = null)
        {
            Fulfillment fulfillment;

            if (multipleTrackingNumbers)
            {
                fulfillment = new Fulfillment()
                {
                    TrackingCompany = "Jack Black's Pack, Stack and Track",
                    TrackingUrls = new string[]
                    {
                        "https://example.com/da10038ee679f9afc93a785cafdd8d52",
                        "https://example.com/6349a40313ae3c7544331ff9fb44f28c",
                        "https://example.com/ca0b2d7bcccec4b58a94a24fa04101d3"
                    },
                    TrackingNumbers = new string[]
                    {
                        "da10038ee679f9afc93a785cafdd8d52",
                        "6349a40313ae3c7544331ff9fb44f28c",
                        "ca0b2d7bcccec4b58a94a24fa04101d3"
                    }
                };
            }
            else
            {
                fulfillment = new Fulfillment()
                {
                    TrackingCompany = "Jack Black's Pack, Stack and Track",
                    TrackingUrl = "https://example.com/123456789",
                    TrackingNumber = "123456789",
                };
            }

            if (items != null)
            {
                fulfillment.LineItems = items;
            }

            fulfillment.NotifyCustomer = false;
            fulfillment.LocationId = LocationId;
            fulfillment = await FulfillmentService.CreateAsync(orderId, fulfillment);

            CreatedFulfillments.Add(fulfillment);

            return fulfillment;
        }
    }
}
