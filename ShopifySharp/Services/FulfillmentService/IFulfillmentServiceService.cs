using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp;

public interface IFulfillmentServiceService : IShopifyService
{
    /// <summary>
    /// Gets a list of your app's FulfillmentServices.
    /// </summary>
    /// <param name="filter">Set scope to all to retrieve all of the store's fulfillment services</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The list of fulfillment services matching the filter.</returns>
    Task<IEnumerable<FulfillmentServiceEntity>> ListAsync(FulfillmentServiceListFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="FulfillmentServiceEntity"/> with the given id.
    /// </summary>
    /// <param name="fulfillmentServiceId">The if of the fulfillment service.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="Fulfillment"/>.</returns>
    Task<FulfillmentServiceEntity> GetAsync(long fulfillmentServiceId, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="FulfillmentServiceEntity"/>.
    /// </summary>
    /// <param name="fulfillmentServiceEntity">A new <see cref="FulfillmentServiceEntity"/>. Id should be set to null.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="FulfillmentServiceEntity"/>.</returns>
    Task<FulfillmentServiceEntity> CreateAsync(FulfillmentServiceEntity fulfillmentServiceEntity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given <see cref="FulfillmentServiceEntity"/>.
    /// </summary>
    /// <param name="fulfillmentServiceId">Id of the fulfillment service being updated.</param>
    /// <param name="fulfillmentServiceEntity">The <see cref="FulfillmentServiceEntity"/> to update.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The updated <see cref="FulfillmentServiceEntity"/>.</returns>
    Task<FulfillmentServiceEntity> UpdateAsync(long fulfillmentServiceId, FulfillmentServiceEntity fulfillmentServiceEntity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a fulfillment service with the given Id.
    /// </summary>
    /// <param name="fulfillmentServiceId">The fulfillment service object's Id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long fulfillmentServiceId, CancellationToken cancellationToken = default);
}