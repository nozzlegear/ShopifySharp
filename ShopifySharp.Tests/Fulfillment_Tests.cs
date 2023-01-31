using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Fulfillment")]
    public class Fulfillment_Tests : IClassFixture<Fulfillment_Tests_Fixture>
    {
        private Fulfillment_Tests_Fixture Fixture { get; }

        public Fulfillment_Tests(Fulfillment_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Fulfillments()
        {
            long orderId = Fixture.Created.First().OrderId.Value;
            var count = await Fixture.Service.CountAsync(orderId);

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Counts_Fulfillments_With_A_Filter()
        {
            long orderId = Fixture.Created.First().OrderId.Value;
            var fromDate = DateTime.UtcNow.AddDays(-2);
            var count = await Fixture.Service.CountAsync(orderId, new FulfillmentCountFilter()
            {
                CreatedAtMin = fromDate
            });

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Fulfillments()
        {
            long orderId = Fixture.Created.First().OrderId.Value;
            var list = await Fixture.Service.ListAsync(orderId);

            Assert.True(list.Items.Count() > 0);
        }

        [Fact]
        public async Task Lists_Fulfillments_With_A_Filter()
        {
            long orderId = Fixture.Created.First().OrderId.Value;
            var fromDate = DateTime.UtcNow.AddDays(-2);
            var list = await Fixture.Service.ListAsync(orderId, new FulfillmentListFilter
            {
                CreatedAtMin = fromDate
            });

            Assert.True(list.Items.Count() > 0);
        }

        [Fact]
        public async Task Lists_Fulfillments_For_A_FulfillmentOrder()
        {
            long orderId = Fixture.Created.First().OrderId.Value;
            var fulfillmentOrder = await Fixture.GetFulfillmentOrder(orderId);
            long fulfillmentOrderId = fulfillmentOrder.Id.Value;
            var list = await Fixture.Service.ListForFulfillmentOrderAsync(fulfillmentOrderId);

            Assert.True(list.Items.Any());
        }

        [Fact]
        public async Task Gets_Fulfillments()
        {
            // Find an id 
            var created = Fixture.Created.First();
            var fulfillment = await Fixture.Service.GetAsync(created.OrderId.Value, created.Id.Value);

            Assert.NotNull(fulfillment);
        }

        [Fact]
        public async Task Creates_Fulfillments()
        {
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value);

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal("success", created.Status);
        }
        
        [Fact]
        public async Task Creates_Fulfillments_With_Tracking_Number()
        {
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value);
            
            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal("success", created.Status);
            Assert.NotEmpty(created.TrackingCompany);
            Assert.NotEmpty(created.TrackingNumber);
            Assert.NotEmpty(created.TrackingNumbers);
            Assert.NotEmpty(created.TrackingUrl);
            Assert.NotEmpty(created.TrackingUrls);
        }

        [Fact]
        public async Task Creates_Partial_Fulfillments()
        {
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value, partialFulfillment: true);

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal("success", created.Status);
        }

        [Fact]
        public async Task Updates_Tracking_Fulfillments()
        {
            string company = "Auntie Dot's Shipping Company";
            string trackingNum = "123456789";
            string trackingUrl = "https://example.com/123456789";
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value);
            long id = created.Id.Value;

            var update = new FulfillmentShipping()
            {
                NotifyCustomer = true,
                TrackingInfo = new TrackingInfo()
                {
                    Company = company,
                    Number = trackingNum,
                    Url = trackingUrl,
                }
            };

            var updated = await Fixture.Service.UpdateTrackingAsync(id, update);

            Assert.Equal(company, updated.TrackingCompany);
            Assert.Equal(trackingNum, updated.TrackingNumber);
            Assert.Equal(trackingUrl, updated.TrackingUrl);
            Assert.Single(updated.TrackingNumbers);
            Assert.Single(updated.TrackingUrls);
            Assert.Equal(trackingNum, updated.TrackingNumbers.First());
            Assert.Equal(trackingUrl, updated.TrackingUrls.First());
        }

        [Fact]
        public async Task Cancels_Fulfillments()
        {
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value);
            var cancelled = await Fixture.Service.CancelAsync(created.Id.Value);

            Assert.Equal("cancelled", cancelled.Status);
        }
    }

    public class Fulfillment_Tests_Fixture : IAsyncLifetime
    {
        public FulfillmentService Service { get; } = new FulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
        private OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        private FulfillmentOrderService FulfillmentOrderService { get; } = new FulfillmentOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        public long LocationId => 6226758;

        /// <summary>
        /// Fulfillments must be part of an order and cannot be deleted.
        /// </summary>
        public List<Order> CreatedOrders { get; } = new List<Order>();

        public List<Fulfillment> Created { get; } = new List<Fulfillment>();

        public async Task InitializeAsync()
        {
            // Fulfillment API has a stricter rate limit when on a non-paid store.
            var policy = new LeakyBucketExecutionPolicy(false);

            Service.SetExecutionPolicy(policy);
            OrderService.SetExecutionPolicy(policy);
            FulfillmentOrderService.SetExecutionPolicy(policy);

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
                    if ((int)ex.HttpStatusCode != 404)
                    {
                        Console.WriteLine($"Failed to delete order with id {obj.Id.Value}. {ex.Message}");
                    }
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

        public async Task<Fulfillment> Create(long orderId, bool partialFulfillment = false)
        {
            var fulfillmentOrders = await ListFulfillmentOrders(orderId);
            var lineItems = fulfillmentOrders.Select(o => new LineItemsByFulfillmentOrder
            {
                FulfillmentOrderId = o.Id.Value,
                FulfillmentRequestOrderLineItems = partialFulfillment == false
                    ? null
                    : o.FulfillmentOrderLineItems.Select(li => new FulfillmentRequestOrderLineItem
                    {
                        Id = li.Id,
                        Quantity = li.FulfillableQuantity - 1
                    })
            });
            var fulfillment = await Service.CreateAsync(new FulfillmentShipping
            {
                Message = "Items are shipping now!",
                FulfillmentRequestOrderLineItems = lineItems,
                NotifyCustomer = false,
                TrackingInfo = new TrackingInfo
                {
                    Company = "Jack Black's Pack, Stack and Track",
                    Url = "https://example.com/123456789",
                    Number = "123456789"
                }
            });

            Created.Add(fulfillment);

            return fulfillment;
        }

        public async Task<FulfillmentOrder> GetFulfillmentOrder(long orderId)
        {
            var list = await FulfillmentOrderService.ListAsync(orderId);
            return list.First();
        }
    }
}
