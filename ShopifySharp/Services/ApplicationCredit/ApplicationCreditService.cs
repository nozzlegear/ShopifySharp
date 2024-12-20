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
/// A service for offering credits for payments made via the Application Charge, Recurring Application Charge, and Usage Charge APIs.
/// </summary>
public class ApplicationCreditService : ShopifyService, IApplicationCreditService
{
    /// <summary>
    /// Creates a new instance of <see cref="ApplicationCreditService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public ApplicationCreditService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal ApplicationCreditService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal ApplicationCreditService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<ApplicationCredit>> ListAsync(ListFilter<ApplicationCredit> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("application_credits.json", "application_credits", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<ApplicationCredit>> ListAsync(ApplicationCreditListFilter filter, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ApplicationCredit> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default) => 
        await ExecuteGetAsync<ApplicationCredit>($"application_credits/{id}.json", "application_credit", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ApplicationCredit> CreateAsync(ApplicationCredit credit, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"application_credits.json");
        var body = new JsonContent(new
        {
            application_credit = credit,
        });

        var response = await ExecuteRequestAsync<ApplicationCredit>(req, HttpMethod.Post, cancellationToken, body, "application_credit");

        return response.Result;
    }
}