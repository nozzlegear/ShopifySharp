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

        [Fact]
        public async Task Cancel_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.Service.ListAsync(order.Id.Value);
            Assert.NotEmpty(fulfillmentOrders);
            var fulfillmentOrder = fulfillmentOrders.First();
            //for canceling, RequestStatus must be unsubmitted
            var result = await Fixture.Service.CancelAsync(fulfillmentOrder.Id.Value);
            Assert.NotNull(result);
            Assert.Equal("closed", result.Status);
        }

        [Fact]
        public async Task Close_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.Service.ListAsync(order.Id.Value);
            Assert.NotEmpty(fulfillmentOrders);
            var fulfillmentOrder = fulfillmentOrders.First();
            fulfillmentOrder = await Fixture.FulfillmentRequestService.CreateAsync(fulfillmentOrder.Id.Value, new FulfillmentRequest() 
            {
                Message = "Testing Fulfillment Order",
            });
            fulfillmentOrder = await Fixture.FulfillmentRequestService.AcceptAsync(fulfillmentOrder.Id.Value, "Testing");
            var result = await Fixture.Service.CloseAsync(fulfillmentOrder.Id.Value, "Testing Done");
            Assert.NotNull(result);
            Assert.Equal("incomplete", result.Status);
        }

        [Fact]
        public async Task Hold_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.Service.ListAsync(order.Id.Value);
            Assert.NotEmpty(fulfillmentOrders);
            var fulfillmentOrder = fulfillmentOrders.First();
            var result = await Fixture.Service.HoldAsync(fulfillmentOrder.Id.Value, new FulfillmentHold()
            {
                Reason = "other",
                ReasonNotes = "Testing Hold",
            });
            Assert.NotNull(result);
            Assert.Equal("on_hold", result.Status);
        }

        [Fact(Skip = "Requires api upgrade to 2022-07 for requires_sku_sharing on FulfillmentService.")]
        public async Task Move_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.Service.ListAsync(order.Id.Value);
            Assert.NotEmpty(fulfillmentOrders);
            var fulfillmentOrder = fulfillmentOrders.First();
            fulfillmentOrder = await Fixture.FulfillmentRequestService.CreateAsync(fulfillmentOrder.Id.Value, new FulfillmentRequest()
            {
                Message = "Testing Fulfillment Order",
            });
            fulfillmentOrder = await Fixture.FulfillmentRequestService.AcceptAsync(fulfillmentOrder.Id.Value, "Testing");
            Assert.Equal(Fixture.LocationId.Value, fulfillmentOrder.AssignedLocationId.Value);
            var result = await Fixture.Service.MoveAsync(fulfillmentOrder.Id.Value,  Fixture.OtherLocationId);
            Assert.NotNull(result);
            Assert.Equal(Fixture.OtherLocationId, result.AssignedLocationId.Value);
        }

        [Fact(Skip = "Requires Subscription setup.")]
        public async Task Open_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.Service.ListAsync(order.Id.Value);
            Assert.NotEmpty(fulfillmentOrders);
            var fulfillmentOrder = fulfillmentOrders.First();
            fulfillmentOrder = await Fixture.FulfillmentRequestService.CreateAsync(fulfillmentOrder.Id.Value, new FulfillmentRequest()
            {
                Message = "Testing Fulfillment Order",
            });
            fulfillmentOrder = await Fixture.FulfillmentRequestService.AcceptAsync(fulfillmentOrder.Id.Value, "Testing");
            var result = await Fixture.Service.OpenAsync(fulfillmentOrder.Id.Value);
            Assert.NotNull(result);
            Assert.Equal("scheduled", result.Status);
        }

        [Fact]
        public async Task Release_Hold_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.Service.ListAsync(order.Id.Value);
            Assert.NotEmpty(fulfillmentOrders);
            var fulfillmentOrder = fulfillmentOrders.First();
            fulfillmentOrder = await Fixture.Service.HoldAsync(fulfillmentOrder.Id.Value, new FulfillmentHold()
            {
                Reason = "other",
                ReasonNotes = "Testing Hold",
            });
            Assert.NotNull(fulfillmentOrder);
            Assert.Equal("on_hold", fulfillmentOrder.Status);

            var result = await Fixture.Service.ReleaseHoldAsync(fulfillmentOrder.Id.Value);
            Assert.NotNull(result);
            Assert.Equal("open", result.Status);
        }

        [Fact(Skip = "Requires Subscription setup.")]
        public async Task Reschedule_FulfillmentOrders()
        {
            var order = await Fixture.CreateOrder();
            var fulfillmentOrders = await Fixture.Service.ListAsync(order.Id.Value);
            Assert.NotEmpty(fulfillmentOrders);
            var fulfillmentOrder = fulfillmentOrders.First();
            fulfillmentOrder = await Fixture.FulfillmentRequestService.CreateAsync(fulfillmentOrder.Id.Value, new FulfillmentRequest()
            {
                Message = "Testing Fulfillment Order",
            });
            fulfillmentOrder = await Fixture.FulfillmentRequestService.AcceptAsync(fulfillmentOrder.Id.Value, "Testing");
            var result = await Fixture.Service.RescheduleAsync(fulfillmentOrder.Id.Value, DateTimeOffset.UtcNow.AddDays(1));
            Assert.NotNull(result);
            Assert.Equal("scheduled", result.Status);
        }

    }

    public class FulfillmentOrder_Tests_Fixture : IAsyncLifetime
    {
        public FulfillmentOrderService Service { get; } = new FulfillmentOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        
        public FulfillmentService FulfillmentService { get; } = new FulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
        public FulfillmentServiceService FulfillmentServiceService { get; } = new FulfillmentServiceService(Utils.MyShopifyUrl, Utils.AccessToken);

        public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        public ProductService ProductService { get; } = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
        public FulfillmentRequestService FulfillmentRequestService { get; } = new FulfillmentRequestService(Utils.MyShopifyUrl, Utils.AccessToken);

        public long? LocationId => FulfillmentServiceEntities[0]?.LocationId;
        public long OtherLocationId => 62885986369;//6226758;

        public string FulfillmentServiceName { get; } = "ShopifySharpTesting4";

        /// <summary>
        /// Fulfillments must be part of an order and cannot be deleted.
        /// </summary>
        public List<Order> CreatedOrders { get; } = new List<Order>();
        public List<Product> Products { get; } = new List<Product>();

        public List<Fulfillment> CreatedFulfillments { get; } = new List<Fulfillment>();

        public List<FulfillmentServiceEntity> FulfillmentServiceEntities { get; } = new List<FulfillmentServiceEntity>();

        public async Task InitializeAsync()
        {
            // Fulfillment API has a stricter rate limit when on a non-paid store.
            var policy = new LeakyBucketExecutionPolicy(false);

            Service.SetExecutionPolicy(policy);
            FulfillmentService.SetExecutionPolicy(policy);
            FulfillmentServiceService.SetExecutionPolicy(policy);
            OrderService.SetExecutionPolicy(policy);
            ProductService.SetExecutionPolicy(policy);
            FulfillmentRequestService.SetExecutionPolicy(policy);

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
            var product = Products.FirstOrDefault();
            if(product == null)
            {
                var products = await ProductService.ListAsync(new Filters.ProductListFilter() { Title = "Test Item Title" });
                product = products.Items.FirstOrDefault();
                if (product == null)
                {
                    product = await ProductService.CreateAsync(new Product()
                    {
                        Title = "Test Item Title",
                        Variants = new List<ProductVariant>()
                        {
                            new ProductVariant()
                            {
                                SKU = "Test-Item",
                                InventoryManagement = FulfillmentServiceName,
                                FulfillmentService = FulfillmentServiceName,
                            }
                        },
                    }, new ProductCreateOptions() { Published = true, });
                }
            }

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
                        VariantId = product.Variants.First().Id,
                    },
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

            var fulfillmentServiceEntities = await FulfillmentServiceService.ListAsync(new Filters.FulfillmentServiceListFilter());
            FulfillmentServiceEntity fulfillmentServiceEntity = fulfillmentServiceEntities.FirstOrDefault(x=>x.Name == FulfillmentServiceName);

            if(fulfillmentServiceEntity == null)
            {
                fulfillmentServiceEntity = await FulfillmentServiceService.CreateAsync(new FulfillmentServiceEntity()
                {
                    Name = FulfillmentServiceName,
                    CallbackUrl = "https://test.test/fulfillmentService",
                    InventoryManagement = true,
                    TrackingSupport = true,
                    RequiresShippingMethod = false,
                    Format = "json",
                    FulfillmentOrdersOptIn = true,
                });
            }

            FulfillmentServiceEntities.Add(fulfillmentServiceEntity);

            return fulfillmentServiceEntity;
        }

    }
}
