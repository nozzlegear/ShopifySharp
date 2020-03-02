using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "GiftCardAdjustment")]
    public class GiftCardAdjustment_Tests : IClassFixture<GiftCardAdjustment_Tests_Fixture>
    {
        private GiftCardAdjustment_Tests_Fixture Fixture { get; }

        public GiftCardAdjustment_Tests(GiftCardAdjustment_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account and without permissions set on gift card adjustments.")]
        public async Task Lists_GiftCardAdjustments()
        {
            var list = await Fixture.Service.ListAsync(Fixture.GiftCardId);

            Assert.True(list.Count() > 0);
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account and without permissions set on gift card adjustments.")]
        public async Task Gets_GiftCardAdjustments()
        {
            var obj = await Fixture.Service.GetAsync(Fixture.GiftCardId, Fixture.Created.FirstOrDefault().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
        }

        [Fact(Skip = "Cannot run without a Shopify Plus account and without permissions set on gift card adjustments.")]
        public async Task Creates_GiftCardAdjustments()
        {
            var obj = await Fixture.Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
        }
    }

    public class GiftCardAdjustment_Tests_Fixture: IAsyncLifetime
    {
        public GiftCardAdjustmentService Service => new GiftCardAdjustmentService(Utils.MyShopifyUrl, Utils.AccessToken);

        public GiftCardService GiftCardService { get; } = new GiftCardService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<GiftCardAdjustment> Created { get; } = new List<GiftCardAdjustment>();

        public long GiftCardId { get; set; }

        public async Task InitializeAsync()
        {
            
            var policy = new SmartRetryExecutionPolicy();

            Service.SetExecutionPolicy(policy);
            GiftCardService.SetExecutionPolicy(policy);

            // Get a gift card id to use with these tests.
            GiftCardId = (await GiftCardService.ListAsync(new Filters.GiftCardListFilter()
            {
                Limit = 1
            })).Items.First().Id.Value;

            // Create one for use with count, list, get, etc. tests.
            await Create();
        }

        public async Task DisposeAsync()
        {
            // There is no delete endpoint on gift card adjustments
            await Task.CompletedTask;
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<GiftCardAdjustment> Create(bool skipAddToCreateList = false)
        {
            var obj = await Service.CreateAsync(GiftCardId, new GiftCardAdjustment()
            {
                Amount = 1.00m,
                Note = "Integration test from ShopifySharp"
            });

            if (! skipAddToCreateList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}