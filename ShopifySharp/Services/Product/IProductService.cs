using System;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

[Obsolete("Shopify has deprecated the REST API for products. This service is deprecated and will be removed in a future version of ShopifySharp. Use ShopifySharp's GraphService to manage products via the GraphQL API, and check https://github.com/nozzlegear/shopifysharp for a migration guide.")]
public interface IProductService : IShopifyService
{
    /// <summary>
    /// Gets a count of all of the shop's products.
    /// </summary>
    /// <returns>The count of all products for the shop.</returns>
    Task<int> CountAsync(ProductCountFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's products.
    /// </summary>
    Task<ListResult<Product>> ListAsync(ListFilter<Product> filter, bool includePresentmentPrices = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's products.
    /// </summary>
    Task<ListResult<Product>> ListAsync(ProductListFilter filter = null, bool includePresentmentPrices = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="Product"/> with the given id.
    /// </summary>
    /// <param name="productId">The id of the product to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="Product"/>.</returns>
    Task<Product> GetAsync(long productId, string fields = null, bool includePresentmentPrices = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="Product"/> on the store.
    /// </summary>
    /// <param name="product">A new <see cref="Product"/>. Id should be set to null.</param>
    /// <param name="options">Options for creating the product.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="Product"/>.</returns>
    Task<Product> CreateAsync(Product product, ProductCreateOptions options = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given <see cref="Product"/>.
    /// </summary>
    /// <param name="productId">Id of the object being updated.</param>
    /// <param name="product">The <see cref="Product"/> to update.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The updated <see cref="Product"/>.</returns>
    Task<Product> UpdateAsync(long productId, Product product, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a product with the given Id.
    /// </summary>
    /// <param name="productId">The product object's Id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long productId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Publishes an unpublished <see cref="Product"/>.
    /// </summary>
    /// <param name="id">The product's id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The published <see cref="Product"/></returns>
    Task<Product> PublishAsync(long id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Unpublishes an published <see cref="Product"/>.
    /// </summary>
    /// <param name="id">The product's id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The unpublished <see cref="Product"/></returns>
    Task<Product> UnpublishAsync(long id, CancellationToken cancellationToken = default);
}
