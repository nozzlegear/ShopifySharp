using System;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify's RecurringApplicationCharge API.
/// </summary>
public class RecurringChargeService : ShopifyService, IRecurringChargeService
{
    /// <summary>
    /// Creates a new instance of <see cref="RecurringChargeService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public RecurringChargeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal RecurringChargeService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    internal RecurringChargeService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider) : base(shopifyApiCredentials, serviceProvider) {}
    #nullable restore
    internal RecurringChargeService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<RecurringCharge> CreateAsync(RecurringCharge charge, CancellationToken cancellationToken = default) =>
        await ExecutePostAsync<RecurringCharge>("recurring_application_charges.json", "recurring_application_charge", cancellationToken, new { recurring_application_charge = charge });

    /// <inheritdoc />
    public virtual async Task<RecurringCharge> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<RecurringCharge>($"recurring_application_charges/{id}.json", "recurring_application_charge", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<IEnumerable<RecurringCharge>> ListAsync(RecurringChargeListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<IEnumerable<RecurringCharge>>("recurring_application_charges.json", "recurring_application_charges", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long id, CancellationToken cancellationToken = default) =>
        await ExecuteDeleteAsync($"recurring_application_charges/{id}.json", cancellationToken);
}