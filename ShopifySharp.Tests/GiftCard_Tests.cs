using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "GiftCard")]
    public class GiftCard_Tests : IClassFixture<GiftCard_Tests_Fixture>
    {
        public static decimal GiftCardValue = 100;
        private GiftCard_Tests_Fixture Fixture { get; }

        public GiftCard_Tests(GiftCard_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Counts_GiftCards()
        {
            var count = await Fixture.Service.CountAsync();
            Assert.True(count > 0);
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Counts_GiftCards_With_A_Filter()
        {
            var enabledCount = await Fixture.Service.CountAsync(new GiftCardCountFilter { Status = "enabled" });
            Assert.True(enabledCount > 0);
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Lists_GiftCards()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Items.Any());
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Lists_GiftCards_With_A_Filter()
        {
            var list = await Fixture.Service.ListAsync(new GiftCardListFilter()
            {
                Status = "enabled"
            });

            Assert.True(list.Items.Any());
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Gets_GiftCards()
        {
            // Find an id 
            var created = Fixture.Created.First();
            var giftCard = await Fixture.Service.GetAsync(created.Id.Value);

            Assert.NotNull(giftCard);
            Assert.Equal(GiftCardValue, giftCard.InitialValue);
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Creates_GiftCards()
        {
            var created = await Fixture.Create(GiftCardValue);

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Creates_GiftCards_With_Code()
        {
            var customCode = Guid.NewGuid().ToString();
            var lastFour = customCode.Substring(customCode.Length - 4);
            var created = await Fixture.Create(GiftCardValue, customCode);

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal(lastFour, created.LastCharacters);
        }


        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Updates_GiftCards()
        {
            string note = "Updates_GiftCards note";
            var created = await Fixture.Create(GiftCardValue);
            long id = created.Id.Value;

            created.Note = note;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(note, updated.Note);
        }


        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Disable_GiftCards()
        {
            var created = await Fixture.Create(GiftCardValue);
            var disabled = await Fixture.Service.DisableAsync(created.Id.Value);

            Assert.True(disabled.DisabledAt.HasValue);
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Searches_For_GiftCards()
        {

            var customCode = Guid.NewGuid().ToString();
            customCode = customCode.Substring(customCode.Length - 20);
            await Fixture.Create(GiftCardValue, customCode);
            var search = await Fixture.Service.SearchAsync(new GiftCardSearchFilter { Query = "code:" + customCode });

            Assert.True(search.Items.Any());
        }
    }

    public class GiftCard_Tests_Fixture : IAsyncLifetime
    {
        public GiftCardService Service => new GiftCardService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<GiftCard> Created { get; } = new List<GiftCard>();

        public async Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());

            // Create an giftCard.
            var giftCard = await Create(GiftCard_Tests.GiftCardValue);
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in Created)
            {
                try
                {
                    await Service.DisableAsync(obj.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    Console.WriteLine($"Failed to delete gift card with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
        public async Task<GiftCard> Create(decimal value, string code = null)
        {
            var giftCardRequest = new GiftCard() { InitialValue = value };
            if (!string.IsNullOrEmpty(code))
            {
                giftCardRequest.Code = code;
            }
            if (giftCardRequest.Code != null && giftCardRequest.Code.Length > 20)
            {
                giftCardRequest.Code = giftCardRequest.Code.Substring(giftCardRequest.Code.Length - 20);
            }
            var giftCard = await Service.CreateAsync(giftCardRequest);

            Created.Add(giftCard);

            return giftCard;
        }
    }
}
