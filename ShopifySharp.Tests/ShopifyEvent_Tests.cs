using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Event")]
    public class ShopifyEvent_Tests
    {
        private EventService _Service => new EventService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<ShopifyEvent> _Created { get; } = new List<ShopifyEvent>();

        [Fact]
        public async Task Counts_Events()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Events()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Lists_Events_For_Subjects()
        {
            // Get an order id
            long orderId = (await new OrderService(Utils.MyShopifyUrl, Utils.AccessToken).ListAsync(new OrderFilter()
            {
                Limit = 1
            })).First().Id.Value;
            string subject = "Order";
            var list = await _Service.ListAsync(orderId, subject);

            Assert.NotNull(list);
            Assert.All(list, e => Assert.Equal(subject, e.SubjectType));
        }

        [Fact]
        public async Task Gets_Events()
        {
            var list = await _Service.ListAsync(options: new EventListFilter()
            {
                Limit = 1
            });
            var evt = await _Service.GetAsync(list.First().Id.Value);

            Assert.NotNull(evt);
            Assert.NotNull(evt.Author);
            Assert.True(evt.CreatedAt.HasValue);
            Assert.NotNull(evt.Message);
            Assert.True(evt.SubjectId > 0);
            Assert.NotNull(evt.SubjectType);
            Assert.NotNull(evt.Verb);
        }
    }
}
