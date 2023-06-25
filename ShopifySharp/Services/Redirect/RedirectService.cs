using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify redirects.
    /// </summary>
    public class RedirectService : ShopifyService, IRedirectService
    {
        /// <summary>
        /// Creates a new instance of <see cref="RedirectService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public RedirectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<int> CountAsync(RedirectCountFilter filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<int>("redirects/count.json", "count", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Redirect>> ListAsync(ListFilter<Redirect> filter, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync("redirects.json", "redirects", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Redirect>> ListAsync(RedirectListFilter filter = null, CancellationToken cancellationToken = default) =>
            await ListAsync(filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Redirect> GetAsync(long redirectId, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Get, cancellationToken, rootElement: "redirect");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Redirect> CreateAsync(Redirect redirect, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("redirects.json");
            var content = new JsonContent(new
            {
                redirect = redirect
            });
            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Post, cancellationToken, content, "redirect");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Redirect> UpdateAsync(long redirectId, Redirect redirect, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");
            var content = new JsonContent(new
            {
                redirect = redirect
            });
            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Put, cancellationToken, content, "redirect");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long redirectId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}