using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Entities.SalesChannel;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "CheckoutSalesChannel")]
    public class CheckoutSalesChannel_Tests: IClassFixture<CheckoutSalesChannel_Fixture>
    {
        private CheckoutSalesChannel_Fixture Fixture { get; }

        public CheckoutSalesChannel_Tests(CheckoutSalesChannel_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Creates_Checkouts()
        {
            var checkout = await Fixture.Create();

            Assert.NotNull(checkout);
        }

        [Fact]
        public async Task Completes_Checkouts()
        {
            var checkout = await Fixture.Create();
            var shippingRates = await Fixture.Service.ListShippingRatesAsync(checkout.Token);

            checkout.ShippingLine = shippingRates.First();
            checkout = await Fixture.Service.UpdateAsync(checkout.Token, checkout);

            checkout = await Fixture.Service.CompleteAsync(checkout.Token);

            Assert.NotNull(checkout);
        }

        [Fact]
        public async Task Gets_Checkouts()
        {
            var checkout = await Fixture.Create();
            checkout = await Fixture.Service.GetAsync(checkout.Token);

            Assert.NotNull(checkout);
        }

        [Fact]
        public async Task Updates_Checkouts()
        {
            var checkout = await Fixture.Create();
            var shippingRates = await Fixture.Service.ListShippingRatesAsync(checkout.Token);
            checkout.ShippingLine = shippingRates.First();

            checkout = await Fixture.Service.UpdateAsync(checkout.Token, checkout);

            Assert.NotNull(checkout.ShippingLine);
        }

        [Fact]
        public async Task Lists_Checkout_Shipping_Rates()
        {
            var checkout = await Fixture.Create();
            var shippingRates = await Fixture.Service.ListShippingRatesAsync(checkout.Token);

            Assert.NotEmpty(shippingRates);
        }

        
        [Fact]
        public async Task Stores_CreditCards()
        {
            var card = new CreditCard()
            {
                FirstName = "John",
                LastName = "Doe",
                Month = 3,
                Year = 25,
                Number = 4242424242424242,
                VerificationValue = 123
            };
            var cardVault = await Fixture.Service.StoreCreditCard(card);

            Assert.NotNull(cardVault);
        }
    }

    public class CheckoutSalesChannel_Fixture : IAsyncLifetime
    {
        public CheckoutSalesChannelService Service { get; } =
            new CheckoutSalesChannelService(Utils.MyShopifyUrl, Utils.AccessToken);

        public string Note => "This checkout was created while testing ShopifySharp!";

        public List<CheckoutSalesChannel> Created { get; } = new List<CheckoutSalesChannel>();

        public Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy(false));

            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<CheckoutSalesChannel> Create()
        {
            var checkout = new CheckoutSalesChannel()
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
                ShippingAddress = new Address()
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
                LineItems = new[]
                {
                    new CheckoutSalesChannelLineItem()
                    {
                        VariantId = 42726326272237,
                        Quantity = 2,
                    },
                    new CheckoutSalesChannelLineItem()
                    {
                        VariantId = 42726326305005,
                        Quantity = 1,
                    }
                },
                Email = Guid.NewGuid() + "@example.com",
                Note = Note,
            };

            var obj = await Service.CreateAsync(checkout);

            return obj;
        }
    }
}