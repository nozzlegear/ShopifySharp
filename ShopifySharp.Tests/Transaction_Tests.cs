using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Transaction")]
    public class Transaction_Tests : IAsyncLifetime
    {
        private TransactionService _Service => new TransactionService(Utils.MyShopifyUrl, Utils.AccessToken);

        private OrderService _OrderService => new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Transaction> _Created => new List<Transaction>();

        private List<Order> _CreatedOrders => new List<Order>();

        private double _Amount => 10.00;

        private string _Currency => "USD";

        private string _Gateway => "bogus";

        private string _Status => "success";

        private long _OrderId { get; set; }

        public async Task InitializeAsync()
        {
            // Create one collection for use with count, list, get, etc. tests.
            var order = await CreateOrder();
            await Create(order.Id.Value);
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in _CreatedOrders)
            {
                try
                {
                    await _OrderService.DeleteAsync(obj.Id.Value);
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

        private async Task<Order> CreateOrder()
        {
            var obj = await _OrderService.CreateAsync(new Order()
            {

            }, new OrderCreateOptions()
            {
                SendFulfillmentReceipt = false,
                SendReceipt = false
            });

            _CreatedOrders.Add(obj);

            return obj;
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<Transaction> Create(long orderId, string kind = "authorization", bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(orderId, new Transaction()
            {
                Amount = _Amount,
                Currency = _Currency,
                Gateway = _Gateway,
                Status = _Status,
                Test = true,
                Kind = kind
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Transactions()
        {
            var count = await _Service.CountAsync(_Created.First().OrderId);

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Transactions()
        {
            var list = await _Service.ListAsync(_Created.First().OrderId);

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Gets_Transactions()
        {
            var obj = await _Service.GetAsync(_Created.First().OrderId, _Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Null(obj.ErrorCode);
            Assert.Equal(_Amount, obj.Amount);
            Assert.Equal(_Currency, obj.Currency);
            Assert.Equal(_Status, obj.Status);
            Assert.Equal(_Gateway, obj.Gateway);
        }

        [Fact]
        public async Task Creates_Transactions()
        {
            var order = await CreateOrder();
            var obj = await Create(order.Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Null(obj.ErrorCode);
            Assert.Equal(_Amount, obj.Amount);
            Assert.Equal(_Currency, obj.Currency);
            Assert.Equal(_Status, obj.Status);
            Assert.Equal(_Gateway, obj.Gateway);
        }

        [Fact]
        public async Task Creates_Capture_Transactions()
        {
            string kind = "capture";
            var order = await CreateOrder();
            var obj = await Create(order.Id.Value, kind);

            Assert.Equal("success", obj.Status);
            Assert.Equal(kind, obj.Kind);
            Assert.Null(obj.ErrorCode);
        }

        [Fact(Skip = "This test returns the error 'Order cannot be refunded'. Orders that were created via API, not using a Shopify transaction gateway, cannot be refunded. Therefore, refunds are untestable.")]
        public async Task Creates_Refund_Transactions()
        {
            string kind = "refund";
            var order = await CreateOrder();
            var obj = await Create(order.Id.Value, kind);

            Assert.Equal("success", obj.Status);
            Assert.Equal(kind, obj.Kind);
            Assert.Null(obj.ErrorCode);
        }

        [Fact]
        public async Task Creates_A_Void_Transaction()
        {
            string kind = "void";
            var order = await CreateOrder();
            var obj = await Create(order.Id.Value, kind);

            Assert.Equal("success", obj.Status);
            Assert.Equal(kind, obj.Kind);
            Assert.Null(obj.ErrorCode);
        }
    }
}