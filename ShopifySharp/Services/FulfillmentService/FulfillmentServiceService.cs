using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify fulfillments.
    /// </summary>
    public class FulfillmentServiceService : ShopifyService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentServiceService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of your app's FulfillmentServices.
        /// </summary>
        /// <param name="scope">Set scope to all to retrieve all of the store's fulfillment services</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The list of fulfillment services matching the filter.</returns>
        public virtual async Task<IEnumerable<FulfillmentServiceEntity>> ListAsync(FulfillmentServiceListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<List<FulfillmentServiceEntity>>("fulfillment_services.json", "fulfillment_services", filter, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="FulfillmentServiceEntity"/> with the given id.
        /// </summary>
        /// <param name="fulfillmentServiceId">The if of the fulfillment service.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Fulfillment"/>.</returns>
        public virtual async Task<FulfillmentServiceEntity> GetAsync(long fulfillmentServiceId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<FulfillmentServiceEntity>($"fulfillment_services/{fulfillmentServiceId}.json", "fulfillment_service", fields, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="FulfillmentServiceEntity"/>.
        /// </summary>
        /// <param name="fulfillmentServiceEntity">A new <see cref="FulfillmentServiceEntity"/>. Id should be set to null.</param>
        /// has been created.</param>
        /// <returns>The new <see cref="FulfillmentServiceEntity"/>.</returns>
        public virtual async Task<FulfillmentServiceEntity> CreateAsync(FulfillmentServiceEntity fulfillmentServiceEntity, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillment_services.json");
            var body = fulfillmentServiceEntity.ToDictionary();

            var content = new JsonContent(new
            {
                fulfillment_service = body
            });

            var response = await ExecuteRequestAsync<FulfillmentServiceEntity>(req, HttpMethod.Post, content, "fulfillment_service", cancellationToken: cancellationToken);
            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="FulfillmentServiceEntity"/>.
        /// </summary>
        /// <param name="fulfillmentServiceId">Id of the fulfillment service being updated.</param>
        /// <param name="fulfillmentServiceEntity">The <see cref="FulfillmentServiceEntity"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="FulfillmentServiceEntity"/>.</returns>
        public virtual async Task<FulfillmentServiceEntity> UpdateAsync(long fulfillmentServiceId, FulfillmentServiceEntity fulfillmentServiceEntity, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillment_services/{fulfillmentServiceId}.json");
            var body = fulfillmentServiceEntity.ToDictionary();

            var content = new JsonContent(new
            {
                fulfillment_service = body
            });

            var response = await ExecuteRequestAsync<FulfillmentServiceEntity>(req, HttpMethod.Put, content, "fulfillment_service", cancellationToken: cancellationToken);
            return response.Result;
        }

        /// <summary>
        /// Deletes a fulfillment service with the given Id.
        /// </summary>
        /// <param name="fulfillmentServiceId">The fulfillment service object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long fulfillmentServiceId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillment_services/{fulfillmentServiceId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken: cancellationToken);
        }
    }
}
