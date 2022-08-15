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
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task Get_FulfillmentOrders()
        {
            var order = Fixture.CreatedOrders.First();
            var fulfillmentOrders = await Fixture.Service.ListAsync(order.Id.Value);
            var fulfillmentOrder = fulfillmentOrders.First();

            var result = await Fixture.Service.GetAsync(fulfillmentOrder.Id.Value);

            Assert.Equal(fulfillmentOrder.Id.Value, result.Id.Value);
        }
        }

    }

    public class FulfillmentOrder_Tests_Fixture : IAsyncLifetime
    {
        public FulfillmentOrderService Service { get; } = new FulfillmentOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        
        public FulfillmentService FulfillmentService { get; } = new FulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
        public FulfillmentServiceService FulfillmentServiceService { get; } = new FulfillmentServiceService(Utils.MyShopifyUrl, Utils.AccessToken);

        public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        public FulfillmentRequestService FulfillmentRequestService { get; } = new FulfillmentRequestService(Utils.MyShopifyUrl, Utils.AccessToken);


        public long? LocationId => FulfillmentServiceEntity?.LocationId;

        /// <summary>
        /// Fulfillments must be part of an order and cannot be deleted.
        /// </summary>
        public List<Order> CreatedOrders { get; } = new List<Order>();

        public List<Fulfillment> CreatedFulfillments { get; } = new List<Fulfillment>();

        public FulfillmentServiceEntity FulfillmentServiceEntity { get; private set; }

        public async Task InitializeAsync()
        {
            // Fulfillment API has a stricter rate limit when on a non-paid store.
            var policy = new LeakyBucketExecutionPolicy(false);

            Service.SetExecutionPolicy(policy);
            FulfillmentService.SetExecutionPolicy(policy);
            OrderService.SetExecutionPolicy(policy);

            await CreateFulfillmentService();
            // Create an order and fulfillment for count, list, get, etc. tests.
            var order = await CreateOrder();
            //var fulfillmentOrder = await GetFulfillmentOrder(order.Id.Value);
            //var fulfillment = await CreateFulfillment(fulfillmentOrder.Id.Value, fulfillmentOrder.FulfillmentOrderLineItems);
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in CreatedOrders)
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
                        Price = 5,
                    },
                    new LineItem()
                    {
                        Name = "Test Line Item 2",
                        Title = "Test Line Item Title 2",
                        Quantity = 2,
                        Price = 5,
                    }
                },
                FinancialStatus = "paid",
                TotalPrice = 5.00m,
                Email = Guid.NewGuid().ToString() + "@example.com",
                Note = "Test note about the customer.",
                Test = true,
            }, new OrderCreateOptions()
            {
                SendReceipt = false,
                SendFulfillmentReceipt = false,
                SendWebhooks = false,
            });

            CreatedOrders.Add(obj);

            return obj;
        }

        public async Task<FulfillmentOrder> GetFulfillmentOrder(long orderId)
        {
            var list = await Service.ListAsync(orderId);
            return list.First();
        }

        public async Task<Fulfillment> CreateFulfillment(long fulfillmentOrderId, IEnumerable<FulfillmentOrderLineItem> items = null)
        {
            Fulfillment fulfillment;

            var fulfillmentShipping = new FulfillmentShipping()
            {
                TrackingInfo = new TrackingInfo()
                {
                    Company = "Jack Black's Pack, Stack and Track",
                    Url = "https://example.com/6349a40313ae3c7544331ff9fb44f28c",
                    Number = "da10038ee679f9afc93a785cafdd8d52",
                },
            };

            var fulfillmentLineItems = new LineItemsByFulfillmentOrder()
            {
                FulfillmentOrderId = fulfillmentOrderId,
                FulfillmentRequestOrderLineItems = new List<FulfillmentRequestOrderLineItem>(),
            };

            if (items != null)
            {
                var requestLines = items.Select(i => new FulfillmentRequestOrderLineItem()
                {
                    Id = i.Id,
                    Quantity = i.FulfillableQuantity,
                });
                fulfillmentLineItems.FulfillmentRequestOrderLineItems = requestLines;
            }
            fulfillmentShipping.FulfillmentRequestOrderLineItems = new List<LineItemsByFulfillmentOrder>() { fulfillmentLineItems };

            fulfillmentShipping.NotifyCustomer = false;
            //fulfillment.LocationId = LocationId;
            fulfillment = await FulfillmentService.CreateForFulfillmentAsync(fulfillmentShipping);

            CreatedFulfillments.Add(fulfillment);

            return fulfillment;
        }

        public async Task<FulfillmentServiceEntity> CreateFulfillmentService()
        {
            var fulfillmentServiceName = "ShopifySharpTesting";

            var fulfillmentServiceEntities = await FulfillmentServiceService.ListAsync(new Filters.FulfillmentServiceListFilter());
            FulfillmentServiceEntity fulfillmentServiceEntity = fulfillmentServiceEntities.FirstOrDefault(x=>x.Name == fulfillmentServiceName);

            if(fulfillmentServiceEntity == null)
            {
                fulfillmentServiceEntity = await FulfillmentServiceService.CreateAsync(new FulfillmentServiceEntity()
                {
                    Name = fulfillmentServiceName,
                    //CallbackUrl = "https://example.com/fulfillmentService",
                    InventoryManagement = false,
                    TrackingSupport = false,
                    RequiresShippingMethod = false,
                    Format = "json",
                });
            }

            FulfillmentServiceEntity = fulfillmentServiceEntity;
            return fulfillmentServiceEntity;
        }

    }
}
