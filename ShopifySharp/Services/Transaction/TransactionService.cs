using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify transactions.
/// </summary>
public class TransactionService : ShopifyService, ITransactionService
{
    /// <summary>
    /// Creates a new instance of <see cref="TransactionService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public TransactionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal TransactionService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal TransactionService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    public virtual async Task<int> CountAsync(long orderId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>($"orders/{orderId}/transactions/count.json", "count", cancellationToken: cancellationToken);

    public virtual async Task<IEnumerable<Transaction>> ListAsync(long orderId, TransactionListFilter filter = null, bool includeCurrencyExchangeAdjustments = false, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<IEnumerable<Transaction>>($"orders/{orderId}/transactions.json", "transactions", filter, cancellationToken, GetHeaders(includeCurrencyExchangeAdjustments));

    public virtual async Task<Transaction> GetAsync(long orderId, long transactionId, TransactionGetFilter filter = null, bool includeCurrencyExchangeAdjustments = false, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Transaction>($"orders/{orderId}/transactions/{transactionId}.json", "transaction", filter, cancellationToken, GetHeaders(includeCurrencyExchangeAdjustments));

    public virtual async Task<Transaction> CreateAsync(long orderId, Transaction transaction, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}/transactions.json");
        var content = new JsonContent(new
        {
            transaction = transaction
        });
        var response = await ExecuteRequestAsync<Transaction>(req, HttpMethod.Post, cancellationToken, content, "transaction");

        return response.Result;
    }

    /// <summary>
    /// Creates a dictionary containing the currency exchange adjustments headers depending on whether
    /// <paramref name="includeCurrencyExchangeAdjustments"/> is true or false.
    /// </summary>
    private Dictionary<string, string> GetHeaders(bool includeCurrencyExchangeAdjustments)
    {
        if (!includeCurrencyExchangeAdjustments)
            return null;

        return new Dictionary<string, string>
        {
            { "X-Shopify-Api-Features", "include-currency-exchange-adjustments" }
        };
    }
}