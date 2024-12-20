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
/// A service for manipulating a Shopify inventory items.
/// </summary>
public class InventoryItemService : ShopifyService, IInventoryItemService
{
    /// <summary>
    /// Creates a new instance of <see cref="InventoryItemService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public InventoryItemService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal InventoryItemService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal InventoryItemService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<InventoryItem>> ListAsync(ListFilter<InventoryItem> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync($"inventory_items.json", "inventory_items", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<InventoryItem>> ListAsync(InventoryItemListFilter filter, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<InventoryItem> GetAsync(long inventoryItemId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<InventoryItem>($"inventory_items/{inventoryItemId}.json", "inventory_item", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<InventoryItem> UpdateAsync( long inventoryItemId, InventoryItem inventoryItem, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri( $"inventory_items/{inventoryItemId}.json" );
        var content = new JsonContent( new
        {
            inventory_item = inventoryItem
        } );

        var response = await ExecuteRequestAsync<InventoryItem>( req, HttpMethod.Put, cancellationToken, content, "inventory_item");
        return response.Result;
    }
}