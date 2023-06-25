using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp
{
    public interface IThemeService : IShopifyService
    {
        /// <summary>
        /// Gets a list of up to 250 of the shop's themes.
        /// </summary>
        Task<IEnumerable<Theme>> ListAsync(ThemeListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="Theme"/> with the given id.
        /// </summary>
        /// <param name="themeId">The id of the theme to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Theme"/>.</returns>
        Task<Theme> GetAsync(long themeId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new theme on the store. The theme always starts out with a role of
        /// "unpublished." If the theme has a different role, it will be assigned that only after all of its
        /// files have been extracted and stored by Shopify (which might take a couple of minutes).
        /// </summary>
        /// <param name="theme">The new theme.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Theme> CreateAsync(Theme theme, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new theme on the store. The theme always starts out with a role of
        /// "unpublished." If the theme has a different role, it will be assigned that only after all of its
        /// files have been extracted and stored by Shopify (which might take a couple of minutes).
        /// </summary>
        /// <param name="theme">The new theme.</param>
        /// <param name="sourceUrl">A URL that points to the .zip file containing the theme's source files.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Theme> CreateAsync(Theme theme, string sourceUrl, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="Theme"/>.
        /// </summary>
        /// <param name="themeId">Id of the object being updated.</param>
        /// <param name="theme">The <see cref="Theme"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Theme"/>.</returns>
        Task<Theme> UpdateAsync(long themeId, Theme theme, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a Theme with the given Id.
        /// </summary>
        /// <param name="themeId">The Theme object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long themeId, CancellationToken cancellationToken = default);
    }
}