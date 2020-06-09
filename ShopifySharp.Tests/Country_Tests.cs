using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Country")]
    public class Country_Tests : IClassFixture<Country_Tests_Fixture>
    {
        private Country_Tests_Fixture Fixture { get; }

        public Country_Tests(Country_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Countries()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Countries_NoFilter()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Items.Any());
        }

        [Fact]
        public async Task Lists_Countries_ComparePagingByCursorAndBySinceId()
        {
            var list = await Fixture.Service.ListAsync(new CountryListFilter
            {
                SinceId = 0,
                Limit = 2
            });
            Assert.True(list.Items.Count() == 2);

            var nextPageViaCursor = await Fixture.Service.ListAsync(list.GetNextPageFilter(2));
            Assert.True(list.Items.Count() == 2);

            var nextPageViaSinceId = await Fixture.Service.ListAsync(new CountryListFilter
            {
                SinceId = list.Items.Last().Id.Value,
                Limit = 2
            });
            Assert.True(list.Items.Count() == 2);

            Assert.True(Enumerable.SequenceEqual(nextPageViaCursor.Items.Select(i => i.Id.Value),
                                                 nextPageViaSinceId.Items.Select(i => i.Id.Value)));
        }

        [Fact]
        public async Task Lists_Countries_PageAll()
        {
            var svc = Fixture.Service;
            var list = await svc.ListAsync(new CountryListFilter { Limit = 5 });

            while (true)
            {
                Assert.True(list.Items.Any());
                list = await svc.ListAsync(list.GetNextPageFilter());
                if (!list.HasNextPage)
                    break;
            }
        }

        [Fact]
        public async Task Deletes_Countries()
        {
            var created = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Countries)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Countries()
        {
            var obj = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.Code, obj.Code);
            Assert.Equal(Fixture.Name, obj.Name);
            Assert.Equal(Fixture.Tax, obj.Tax);
        }

        [Fact]
        public async Task Creates_Countries()
        {
            var obj = await Fixture.Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.Code, obj.Code);
            Assert.Equal(Fixture.Name, obj.Name);
            Assert.Equal(Fixture.Tax, obj.Tax);
        }

        [Fact]
        public async Task Updates_Countries()
        {
            string name = "ShopifySharp Updated Test Country";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.Name = name;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(name, updated.Name);
        }
    }

    public class Country_Tests_Fixture : IAsyncLifetime
    {
        public CountryService Service { get; } = new CountryService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<Country> Created { get; } = new List<Country>();

        public string Code => "DE";

        public string Name = "Germany";

        public decimal Tax = (decimal)0.14;

        public string TaxName = "VAT";

        public async Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());

            // Create one for count, list, get, etc. orders.
            await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in Created)
            {
                try
                {
                    await Service.DeleteAsync(obj.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created Country with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Country> Create(bool skipAddToCreateList = false)
        {
            var obj = await Service.CreateAsync(new Country()
            {
                Code = Code,
                Name = Name,
                Tax = Tax
            });

            if (!skipAddToCreateList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
