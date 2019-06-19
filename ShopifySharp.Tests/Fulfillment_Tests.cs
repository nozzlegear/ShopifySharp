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
            var count = await Fixture.Service.CountAsync(orderId, new CountFilter()
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

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Lists_Fulfillments_With_A_Filter()
        {
            long orderId = Fixture.Created.First().OrderId.Value;
            var fromDate = DateTime.UtcNow.AddDays(-2);
            var list = await Fixture.Service.ListAsync(orderId, new ListFilter()
            {
                CreatedAtMin = fromDate
            });

            Assert.True(list.Count() > 0);
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
        public async Task Creates_Fulfillments_With_Tracking_Numbers()
        {
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value, true);

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal("success", created.Status);
            Assert.True(created.TrackingNumbers.Count() > 1);
        }

        [Fact]
        public async Task Creates_Partial_Fulfillments()
        {
            var order = await Fixture.CreateOrder();
            var lineItem = order.LineItems.First();

            // A partial fulfillment does not fulfill the entire line item quantity
            lineItem.Quantity -= 1;

            var created = await Fixture.Create(order.Id.Value, false, new LineItem[] { lineItem });

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal("success", created.Status);
        }

        [Fact]
        public async Task Updates_Fulfillments()
        {
            string company = "Auntie Dot's Shipping Company";
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value, false);
            long id = created.Id.Value;

            created.TrackingCompany = company;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(created.OrderId.Value, id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(company, updated.TrackingCompany);
        }

        [Fact(Skip = "Can't complete/cancel/open a fulfillment whose status is not 'pending'. It's not clear how to create a fulfillment that's pending.")]
        public async Task Opens_Fulfillments()
        {
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value);
            var opened = await Fixture.Service.OpenAsync(order.Id.Value, created.Id.Value);

            Assert.Equal("open", opened.Status);
        }

        [Fact(Skip = "Can't complete/cancel/open a fulfillment whose status is not 'pending'. It's not clear how to create a fulfillment that's pending.")]
        public async Task Cancels_Fulfillments()
        {
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value);
            var cancelled = await Fixture.Service.CancelAsync(order.Id.Value, created.Id.Value);

            Assert.Equal("cancelled", cancelled.Status);
        }

        [Fact(Skip = "Can't complete/cancel/open a fulfillment whose status is not 'pending'. It's not clear how to create a fulfillment that's pending.")]
        public async Task Completes_Fulfillments()
        {
            var order = await Fixture.CreateOrder();
            var created = await Fixture.Create(order.Id.Value);
            var cancelled = await Fixture.Service.CancelAsync(order.Id.Value, created.Id.Value);

            Assert.Equal("success", cancelled.Status);
        }
    }

    public class Fulfillment_Tests_Fixture : IAsyncLifetime
    {
        public FulfillmentService Service { get; } = new FulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);

        public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        /// <summary>
        /// Fulfillments must be part of an order and cannot be deleted.
        /// </summary>
        public List<Order> CreatedOrders { get; } = new List<Order>();

        public List<Fulfillment> Created { get; } = new List<Fulfillment>();

        public async Task InitializeAsync()
        {
            // Fulfillment API has a stricter rate limit when on a non-paid store.
            var policy = new SmartRetryExecutionPolicy();
            Service.SetExecutionPolicy(policy);
            OrderService.SetExecutionPolicy(policy);

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

            fulfillment = await Service.CreateAsync(orderId, fulfillment, false);

            Created.Add(fulfillment);

            return fulfillment;
        }
    }
}
