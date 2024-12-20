using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for working with shipping carriers.
/// </summary>
public class CarrierService : ShopifyService, ICarrierService
{
    /// <summary>
    /// Creates a new instance of <see cref="CarrierService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public CarrierService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }        
    #nullable enable
    internal CarrierService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal CarrierService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<IEnumerable<Carrier>> ListAsync(CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync< IEnumerable < Carrier >>("carrier_services.json", "carrier_services", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Carrier> CreateAsync(Carrier carrier, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("carrier_services.json");
        var content = new JsonContent(new
        {
            carrier_service = carrier
        });

        var response = await ExecuteRequestAsync<Carrier>(req, HttpMethod.Post, cancellationToken, content, "carrier_service");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Carrier> GetAsync(long carrierId, CancellationToken cancellationToken = default)
    {            
        var req = BuildRequestUri($"carrier_services/{carrierId}.json");

        var response = await ExecuteRequestAsync<Carrier>(req, HttpMethod.Get, cancellationToken, rootElement: "carrier_service");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long carrierId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"carrier_services/{carrierId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<Carrier> UpdateAsync(long carrierId, Carrier carrier, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"carrier_services/{carrierId}.json");
        var content = new JsonContent(new
        {
            carrier_service = carrier
        });

        var response = await ExecuteRequestAsync<Carrier>(req, HttpMethod.Put, cancellationToken, content, "carrier_service");
        return response.Result;
    }
}