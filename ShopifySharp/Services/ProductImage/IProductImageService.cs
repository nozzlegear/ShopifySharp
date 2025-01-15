using System;
using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp;

[Obsolete("Shopify has deprecated the REST API for product images. This service is deprecated and will be removed in a future version of ShopifySharp. Use ShopifySharp's GraphService to manage product images via the GraphQL API, and check https://github.com/nozzlegear/shopifysharp for a migration guide.")]
public interface IProductImageService : IShopifyService
{
    /// <summary>
    /// Gets a count of all of the shop's ProductImages.
    /// </summary>
    /// <param name="productId">The id of the product that counted images belong to.</param>
    /// <param name="filter">Options for filtering the result.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<int> CountAsync(long productId, ProductImageCountFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's ProductImages.
    /// </summary>
    /// <param name="productId">The id of the product that counted images belong to.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<ProductImage>> ListAsync(long productId, ListFilter<ProductImage> filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="ProductImage"/> with the given id.
    /// </summary>
    /// <param name="productId">The id of the product that counted images belong to.</param>
    /// <param name="imageId">The id of the ProductImage to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="ProductImage"/>.</returns>
    Task<ProductImage> GetAsync(long productId, long imageId, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="ProductImage"/>. If the new image has an <see cref="ProductImage.Attachment"/> string, it will be converted to the <see cref="ProductImage.Src"/>.
    /// </summary>
    /// <param name="productId">The id of the product that counted images belong to.</param>
    /// <param name="image">The new <see cref="ProductImage"/>.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="ProductImage"/>.</returns>
    Task<ProductImage> CreateAsync(long productId, ProductImage image, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given <see cref="ProductImage"/>.
    /// </summary>
    /// <param name="productId">The id of the product that counted images belong to.</param>
    /// <param name="productImageId">Id of the object being updated.</param>
    /// <param name="image">The <see cref="ProductImage"/> to update.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The updated <see cref="ProductImage"/>.</returns>
    Task<ProductImage> UpdateAsync(long productId, long productImageId, ProductImage image, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a ProductImage with the given Id.
    /// </summary>
    /// <param name="productId">The id of the product that counted images belong to.</param>
    /// <param name="imageId">The ProductImage object's Id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long productId, long imageId, CancellationToken cancellationToken = default);
}
