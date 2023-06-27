using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp
{
    public interface IAssetService : IShopifyService
    {
        /// <summary>
        /// Retrieves the <see cref="Asset"/> with the given id.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to. Assets themselves do not have ids.</param>
        /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Asset"/>.</returns>
        Task<Asset> GetAsync(long themeId, string key, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of all <see cref="Asset"/> objects. Listing theme assets only returns metadata about each asset.
        /// You need to request assets individually in order to get their contents.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<IEnumerable<Asset>> ListAsync(long themeId, AssetListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates or updates a <see cref="Asset"/>. Both tasks use the same method due to the
        /// way Shopify API handles assets. If an asset has a unique <see cref="Asset.Key"/> value,
        /// it will be created. If not, it will be updated. Copy an asset by setting the
        /// <see cref="Asset.SourceKey"/> to the target's <see cref="Asset.Key"/> value.
        /// Note: This will not return the asset's <see cref="Asset.Value"/> property. You should
        /// use <see cref="AssetService.GetAsync"/> to refresh the value after creating or updating.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <param name="asset">The asset.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The created or updated asset.</returns>
        Task<Asset> CreateOrUpdateAsync(long themeId, Asset asset, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a <see cref="Asset"/> with the given key.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long themeId, string key, CancellationToken cancellationToken = default);
    }
}