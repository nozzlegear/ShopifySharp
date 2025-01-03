using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for listing Shopify tender transactions.
/// </summary>
public class TenderTransactionService : ShopifyService, ITenderTransactionService
{
    /// <summary>
    /// Creates a new instance of <see cref="TenderTransactionService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public TenderTransactionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal TenderTransactionService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal TenderTransactionService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<TenderTransaction>> ListAsync(ListFilter<TenderTransaction> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("tender_transactions.json", "tender_transactions", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<TenderTransaction>> ListAsync(TenderTransactionListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);
}