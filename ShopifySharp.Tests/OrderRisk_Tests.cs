using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "OrderRisk")]
    public class OrderRisk_Tests : IAsyncLifetime
    {
        private OrderRiskService _Service => new OrderRiskService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<OrderRisk> _Created { get; } = new List<OrderRisk>();

        private string _Message => "This looks risky!";

        private decimal _Score => (decimal)0.85;

        private string _Recommendation => "cancel";

        private string _Source => "External";

        private bool _CauseCancel => false;

        private bool _Display => true;

        private long _OrderId { get; set; }

        public async Task InitializeAsync()
        {
            _OrderId = (await new OrderService(Utils.MyShopifyUrl, Utils.AccessToken).ListAsync(new OrderFilter()
            {
                Limit = 1
            })).First().Id.Value;
            
            // Create a risk for count, list, get, etc. tests.
            await Create(_OrderId);
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in _Created)
            {
                try
                {
                    await _Service.DeleteAsync(_OrderId, obj.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created OrderRisk with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }


        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<OrderRisk> Create(long orderId, bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(orderId, new OrderRisk()
            {
                Message = _Message,
                Score = _Score,
                Recommendation = _Recommendation,
                Source = _Source,
                CauseCancel = _CauseCancel,
                Display = _Display,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Lists_Risks()
        {
            var list = await _Service.ListAsync(_OrderId);

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Risks()
        {
            var created = await Create(_OrderId, true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(_OrderId, created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Risks)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Risks()
        {
            long id = _Created.First().Id.Value;
            var risk = await _Service.GetAsync(_OrderId, id);

            Assert.NotNull(risk);
            Assert.Equal(_OrderId, risk.OrderId);
            Assert.Equal(_Message, risk.Message);
            Assert.Equal(_Score, risk.Score);
            Assert.Equal(_Recommendation, risk.Recommendation);
            Assert.Equal(_Source, risk.Source);
            Assert.Equal(_CauseCancel, risk.CauseCancel);
            Assert.Equal(_Display, risk.Display);
        }

        [Fact]
        public async Task Creates_Risks()
        {
            var created = await Create(_OrderId);

            Assert.NotNull(created);
            Assert.Equal(_OrderId, created.OrderId);
            Assert.Equal(_Message, created.Message);
            Assert.Equal(_Score, created.Score);
            Assert.Equal(_Recommendation, created.Recommendation);
            Assert.Equal(_Source, created.Source);
            Assert.Equal(_CauseCancel, created.CauseCancel);
            Assert.Equal(_Display, created.Display);
        }

        [Fact]
        public async Task Updates_Risks()
        {
            string message = "An updated risk message.";
            var created = await Create(_OrderId);
            created.Message = message;

            var updated = await _Service.UpdateAsync(_OrderId, created);

            Assert.Equal(message, updated.Message);
        }
    }
}
