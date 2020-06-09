using System.Net.Http;
using System.Threading;
using ShopifySharp.Filters;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify countries.
    /// </summary>
    public class CountryService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CountryService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CountryService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's countries.
        /// </summary>
        /// <returns>The count of all countries for the shop.</returns>
        public virtual async Task<int> CountAsync(CountryCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("countries/count.json", "count", filter, cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of the shop's countries.
        /// </summary>
        public virtual async Task<ListResult<Country>> ListAsync(ListFilter<Country> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("countries.json", "countries", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of the shop's countries.
        /// </summary>
        public virtual async Task<ListResult<Country>> ListAsync(CountryListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="Country"/> with the given id.
        /// </summary>
        /// <param name="countryId">The id of the country to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Country"/>.</returns>
        public virtual async Task<Country> GetAsync(long countryId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Country>($"countries/{countryId}.json", "country", fields, cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="Country"/> on the store.
        /// </summary>
        /// <param name="country">A new <see cref="Country"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Country"/>.</returns>
        public virtual async Task<Country> CreateAsync(Country country, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("countries.json");
            var content = new JsonContent(new
            {
                country = country
            });
            var response = await ExecuteRequestAsync<Country>(req, HttpMethod.Post, cancellationToken, content, "country");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="Country"/>.
        /// </summary>
        /// <param name="countryId">Id of the object being updated.</param>
        /// <param name="country">The <see cref="Country"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Country"/>.</returns>
        public virtual async Task<Country> UpdateAsync(long countryId, Country country, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"countries/{countryId}.json");
            var content = new JsonContent(new
            {
                country = country
            });
            var response = await ExecuteRequestAsync<Country>(req, HttpMethod.Put, cancellationToken, content, "country");

            return response.Result;
        }

        /// <summary>
        /// Deletes a country with the given Id.
        /// </summary>
        /// <param name="countryId">The country object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long countryId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"countries/{countryId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}
