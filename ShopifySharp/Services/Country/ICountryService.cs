using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

public interface ICountryService : IShopifyService
{
    /// <summary>
    /// Gets a count of all of the shop's countries.
    /// </summary>
    /// <returns>The count of all countries for the shop.</returns>
    Task<int> CountAsync(CountryCountFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of the shop's countries.
    /// </summary>
    Task<ListResult<Country>> ListAsync(ListFilter<Country> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of the shop's countries.
    /// </summary>
    Task<ListResult<Country>> ListAsync(CountryListFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="Country"/> with the given id.
    /// </summary>
    /// <param name="countryId">The id of the country to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="Country"/>.</returns>
    Task<Country> GetAsync(long countryId, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="Country"/> on the store.
    /// </summary>
    /// <param name="country">A new <see cref="Country"/>. Id should be set to null.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="Country"/>.</returns>
    Task<Country> CreateAsync(Country country, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given <see cref="Country"/>.
    /// </summary>
    /// <param name="countryId">Id of the object being updated.</param>
    /// <param name="country">The <see cref="Country"/> to update.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The updated <see cref="Country"/>.</returns>
    Task<Country> UpdateAsync(long countryId, Country country, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a country with the given Id.
    /// </summary>
    /// <param name="countryId">The country object's Id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long countryId, CancellationToken cancellationToken = default);
}