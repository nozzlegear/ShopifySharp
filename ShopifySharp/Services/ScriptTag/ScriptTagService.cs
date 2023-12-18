using System.Net.Http;
using ShopifySharp.Filters;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's ScriptTag API.
    /// </summary>
    public class ScriptTagService : ShopifyService, IScriptTagService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ScriptTagService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ScriptTagService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
        
		///<inheritdoc />
        public virtual async Task<int> CountAsync(ScriptTagCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("script_tags/count.json", "count", filter, cancellationToken);
        }
        
		///<inheritdoc />
        public virtual async Task<ListResult<ScriptTag>> ListAsync(ListFilter<ScriptTag> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("script_tags.json", "script_tags", filter, cancellationToken);
        }
        
		///<inheritdoc />
        public virtual async Task<ListResult<ScriptTag>> ListAsync(ScriptTagListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }
        
		///<inheritdoc />
        public virtual async Task<ScriptTag> GetAsync(long tagId, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"script_tags/{tagId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<ScriptTag>(req, HttpMethod.Get, cancellationToken, rootElement: "script_tag");

            return response.Result;
        }
        
		///<inheritdoc />
        public virtual async Task<ScriptTag> CreateAsync(ScriptTag tag, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri("script_tags.json");
            var content = new JsonContent(new
            {
                script_tag = tag
            });
            var response = await ExecuteRequestAsync<ScriptTag>(req, HttpMethod.Post, cancellationToken, content, "script_tag");

            return response.Result;
        }
        
		///<inheritdoc />
        public virtual async Task<ScriptTag> UpdateAsync(long scriptTagId, ScriptTag tag, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"script_tags/{scriptTagId}.json");
            var content = new JsonContent(new
            {
                script_tag = tag
            });
            var response = await ExecuteRequestAsync<ScriptTag>(req, HttpMethod.Put, cancellationToken, content, "script_tag");

            return response.Result;
        }
        
		///<inheritdoc />
        public virtual async Task DeleteAsync(long tagId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"script_tags/{tagId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}