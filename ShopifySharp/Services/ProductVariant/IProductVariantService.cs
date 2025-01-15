using System;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

[Obsolete("Shopify has deprecated the REST API for product variants. This service is deprecated and will be removed in a future version of ShopifySharp. Use ShopifySharp's GraphService to manage product variants via the GraphQL API, and check https://github.com/nozzlegear/shopifysharp for a migration guide.")]
public interface IProductVariantService : IShopifyService
{
    /// <summary>
    /// Gets a count of all variants belonging to the given product.
    /// </summary>
    /// <param name="productId">The product that the variants belong to.</param>
    /// <param name="filter">Options for filtering the result.</param>
    /// <remarks>
    /// According to Shopify's documentation, this endpoint does not currently support any additional filter parameters for counting.
    /// </remarks>
    Task<int> CountAsync(long productId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of variants belonging to the given product.
    /// </summary>
    /// <param name="productId">The product that the variants belong to.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<ProductVariant>> ListAsync(long productId, ListFilter<ProductVariant> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of variants belonging to the given product.
    /// </summary>
    /// <param name="productId">The product that the variants belong to.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<ProductVariant>> ListAsync(long productId, ProductVariantListFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="ProductVariant"/> with the given id.
    /// </summary>
    /// <param name="variantId">The id of the product variant to retrieve.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ProductVariant> GetAsync(long variantId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="ProductVariant"/>.
    /// </summary>
    /// <param name="productId">The product that the new variant will belong to.</param>
    /// <param name="variant">A new <see cref="ProductVariant"/>. Id should be set to null.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ProductVariant> CreateAsync(long productId, ProductVariant variant, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given <see cref="ProductVariant"/>.
    /// </summary>
    /// <param name="productVariantId">Id of the object being updated.</param>
    /// <param name="variant">The variant to update.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ProductVariant> UpdateAsync(long productVariantId, ProductVariant variant, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a product variant with the given Id.
    /// </summary>
    /// <param name="productId">The product that the variant belongs to.</param>
    /// <param name="variantId">The product variant's id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long productId, long variantId, CancellationToken cancellationToken = default);
}
