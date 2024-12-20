using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify price rules.
/// </summary>
public class PriceRuleService : ShopifyService, IPriceRuleService
{
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public PriceRuleService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal PriceRuleService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal PriceRuleService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<PriceRule>> ListAsync(ListFilter<PriceRule> filter, CancellationToken cancellationToken = default)
    {
        return await ExecuteGetListAsync("price_rules.json", "price_rules", filter, cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<ListResult<PriceRule>> ListAsync(PriceRuleListFilter filter = null, CancellationToken cancellationToken = default)
    {
        return await ListAsync(filter?.AsListFilter(), cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<PriceRule> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"price_rules/{id}.json");

        if (!string.IsNullOrEmpty(fields))
        {
            req.QueryParams.Add("fields", fields);
        }

        var response = await ExecuteRequestAsync<PriceRule>(req, HttpMethod.Get, cancellationToken, rootElement: "price_rule");
            
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<PriceRule> CreateAsync(PriceRule rule, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("price_rules.json");
        var body = rule.ToDictionary();
        var content = new JsonContent(new
        {
            price_rule = body
        });
        var response =  await ExecuteRequestAsync<PriceRule>(req, HttpMethod.Post, cancellationToken, content, "price_rule");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<PriceRule> UpdateAsync(long id, PriceRule rule, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"price_rules/{id}.json");
        var content = new JsonContent(new
        {
            price_rule = rule
        });
        var response = await ExecuteRequestAsync<PriceRule>(req, HttpMethod.Put, cancellationToken, content, "price_rule");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"price_rules/{id}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }
}