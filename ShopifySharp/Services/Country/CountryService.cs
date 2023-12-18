using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify countries.
    /// </summary>
    public class CountryService : ShopifyService, ICountryService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CountryService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CountryService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<int> CountAsync(CountryCountFilter filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<int>("countries/count.json", "count", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Country>> ListAsync(ListFilter<Country> filter, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync("countries.json", "countries", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Country>> ListAsync(CountryListFilter filter = null, CancellationToken cancellationToken = default) =>
            await ListAsync(filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Country> GetAsync(long countryId, string fields = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<Country>($"countries/{countryId}.json", "country", fields, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Country> CreateAsync(Country country, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri("countries.json");
            var content = new JsonContent(new
            {
                country = country
            });
            var response = await ExecuteRequestAsync<Country>(req, HttpMethod.Post, cancellationToken, content, "country");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Country> UpdateAsync(long countryId, Country country, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"countries/{countryId}.json");
            var content = new JsonContent(new
            {
                country = country
            });
            var response = await ExecuteRequestAsync<Country>(req, HttpMethod.Put, cancellationToken, content, "country");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long countryId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"countries/{countryId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}