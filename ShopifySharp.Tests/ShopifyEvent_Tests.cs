using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Event")]
    public class ShopifyEvent_Tests : IClassFixture<ShopifyEvent_Tests_Fixture>
    {
        private ShopifyEvent_Tests_Fixture Fixture { get; }

        public ShopifyEvent_Tests(ShopifyEvent_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Events()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Events()
        {
            var list = await Fixture.Service.ListAsync();

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
            var list = await Fixture.Service.ListAsync(orderId, subject);

            Assert.NotNull(list);
            Assert.All(list, e => Assert.Equal(subject, e.SubjectType));
        }

        [Fact]
        public async Task Gets_Events()
        {
            var list = await Fixture.Service.ListAsync(options: new EventListFilter()
            {
                Limit = 1
            });
            var evt = await Fixture.Service.GetAsync(list.First().Id.Value);

            Assert.NotNull(evt);
            Assert.NotNull(evt.Author);
            Assert.True(evt.CreatedAt.HasValue);
            Assert.NotNull(evt.Message);
            Assert.True(evt.SubjectId > 0);
            Assert.NotNull(evt.SubjectType);
            Assert.NotNull(evt.Verb);
        }
    }

    public class ShopifyEvent_Tests_Fixture
    {
        public EventService Service => new EventService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<ShopifyEvent> Created { get; } = new List<ShopifyEvent>();
    }
}
