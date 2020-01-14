using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Refund")]
    public class Refund_Tests : IClassFixture<Refund_Tests_Fixture>
    {
        private Refund_Tests_Fixture Fixture { get; }

        public Refund_Tests(Refund_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        ///<summary>
        ///A test designed to validate the ShopifySharp Refund Methods.
        ///Please note: An <see cref="OrderId"/> tied to a manually created, active order is required to be able to use this test.
        ///This is because it seems API refunds cannot be applied against orders created via the API.
        ///These four method tests are consolidated into one because they are reliant upon each other:
        ///*GetAsync & ListForOrderAsync: To be able to list a refund, a refund must be created (via PrepareRefund).
        ///*PrepareRefund: In order to create a Refund, a transaction Id must have been retrieved (via CalculateAsync).
        ///</summary>
        [Fact]
        public async Task Get_Refund_And_List()
        {
            //CalculateAsync
            var order = await Fixture.OrderService.GetAsync(Fixture.Created.First().Id.Value);
            var requestedRefund = Prepare_Calculate(order);
            var calculateResponse = await Fixture.Service.CalculateAsync(order.Id.Value, requestedRefund);
            Assert.True(calculateResponse.Transactions.Count<Transaction>() > 0, "No transactions for order!"); //Perhaps something is unexpected with the order, or call/response was malformed."

            //RefundAsync
            var fullRefundForAnOrder = Prepare_Refund(calculateResponse);
            var refundResponse = await Fixture.Service.RefundAsync(order.Id.Value, fullRefundForAnOrder);
            Assert.True(refundResponse.ProcessedAt.HasValue && refundResponse.ProcessedAt > DateTime.UtcNow.AddDays(-1), "Refund was not processed"); //Order was not processed, thus was not successfully refunded"

            //ListForOrderAsync
            var getRefundsForOrder = await Fixture.Service.ListForOrderAsync(order.Id.Value);
            Assert.True(getRefundsForOrder.First().Id.HasValue, "No refunds received!"); //Likely the creation of a refund or the retrieval of refunds weren't successful"

            //GetAsync
            var getSpecificRefund = await Fixture.Service.GetAsync(order.Id.Value, getRefundsForOrder.First().Id.Value);
            Assert.True(getSpecificRefund.Id.HasValue, "No refund received!"); //Either refund wasn't successful or Refund Id may be incorrect."
        }

        /// <summary>
        /// A helper function designed to construct a refund object that will be accepted by Shopify Refund "/orders/#{order_id}/refunds/calculate.json" endpoint
        /// </summary>
        public Refund Prepare_Calculate(Order order)
        {
            var RequestedRefund = new Refund()
            {
                Currency = "USD",
                Shipping = new Shipping()
                {
                    FullRefund = true,
                },
                RefundLineItems = new List<ShopifySharp.RefundLineItem>(),
            };
            var liList = new List<RefundLineItem>();
            foreach (var li in order.LineItems)
            {
                var newLi = new ShopifySharp.RefundLineItem()
                {
                    LineItemId = li.Id,
                    Quantity = li.Quantity,
                    RestockType = "no_restock",
                };
                liList.Add(newLi);
            }
            RequestedRefund.RefundLineItems = liList;
            return RequestedRefund;
        }

        /// <summary>
        /// A helper function designed to construct a refund object that will be accepted by Shopify Refund "/orders/#{order_id}/refunds.json" endpoint
        /// </summary>
        public Refund Prepare_Refund(Refund calculateRefundResponse)
        {
            var fullRefundForAnOrder = new Refund()
            {
                Currency = "USD",
                Notify = true,
                Note = "Shopify Sharp Test",
                Shipping = new Shipping()
                {
                    FullRefund = true,
                },
                RefundLineItems = new List<ShopifySharp.RefundLineItem>(),
                Transactions = new List<ShopifySharp.Transaction>(),
            };
            var liList = new List<RefundLineItem>();
            foreach (var orderLi in calculateRefundResponse.RefundLineItems)
            {
                var lineItem = new ShopifySharp.RefundLineItem()
                {
                    LineItemId = orderLi.LineItemId,
                    Quantity = orderLi.Quantity,
                    RestockType = orderLi.RestockType,
                };
                liList.Add(lineItem);
            };
            fullRefundForAnOrder.RefundLineItems = liList;
            var transactionList = new List<Transaction>();
            foreach (var shopifyTransaction in calculateRefundResponse.Transactions)
            {
                var transactionLi = new ShopifySharp.Transaction()
                {
                    ParentId = shopifyTransaction.ParentId,
                    Amount = shopifyTransaction.Amount,
                    Kind = "refund",
                    Gateway = "ShopifySharp Test",
                };
                transactionList.Add(transactionLi);
            }
            fullRefundForAnOrder.Transactions = transactionList;
            return fullRefundForAnOrder;
        }
    }

    public class Refund_Tests_Fixture : IAsyncLifetime
    {
        /// <summary>
        /// An id tied to an order.
        /// Requires that the order be manually created and set before testing.
        /// </summary>
        public long? OrderId = null; 

        public Refund_Tests_Fixture()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());
        }

        public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        public RefundService Service { get; } = new RefundService(Utils.MyShopifyUrl, Utils.AccessToken);

        public string Note => "This order was created while testing ShopifySharp!";

        public List<Order> Created { get; } = new List<Order>();

        public async Task InitializeAsync()
        {
            if (!OrderId.HasValue)
                return;
            // Retrieve an order for count, list, get, etc. orders.
            await Retrieve(OrderId.Value);
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
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created Order with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Retrieves an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Order> Retrieve(long orderId, bool skipAddToCreateList = false)
        {
            var obj = await OrderService.GetAsync(orderId);

            if (!skipAddToCreateList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
