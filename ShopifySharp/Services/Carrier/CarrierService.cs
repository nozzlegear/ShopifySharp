using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using System;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for working with shipping carriers.
    /// </summary>
    public class CarrierService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CarrierService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CarrierService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }        
        
        /// <summary>
        /// Retrieve a list of all carrier services that are associated with the store.
        /// </summary>
        public virtual async Task<IEnumerable<Carrier>> ListAsync(CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync< IEnumerable < Carrier >>("carrier_services.json", "carrier_services", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="Carrier"/> Carrier
        /// </summary>
        /// <param name="carrier">A new <see cref="Carrier"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Carrier"/>.</returns>
        public virtual async Task<Carrier> CreateAsync(Carrier carrier, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("carrier_services.json");
            var content = new JsonContent(new
            {
                carrier_service = carrier
            });

            var response = await ExecuteRequestAsync<Carrier>(req, HttpMethod.Post, cancellationToken, content, "carrier_service");
            return response.Result;
        }

        /// <summary>
        /// Retrieves the <see cref="Carrier"/> with the given id.
        /// </summary>
        /// <param name="carrierId">The id of the Carrier to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Carrier"/>.</returns>
        public virtual async Task<Carrier> GetAsync(long carrierId, CancellationToken cancellationToken = default)
        {            
            var req = PrepareRequest($"carrier_services/{carrierId}.json");

            var response = await ExecuteRequestAsync<Carrier>(req, HttpMethod.Get, cancellationToken, rootElement: "carrier_service");
            return response.Result;
        }

        /// <summary>
        /// Deletes a Carruer with the given Id.
        /// </summary>
        /// <param name="carrierId">The Carrier's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long carrierId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"carrier_services/{carrierId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <summary>
        /// Updates the given <see cref="Carrier"/>.
        /// </summary>
        /// <param name="carrierId">Id of the Carrier being updated.</param>
        /// <param name="carrier">The <see cref="Carrier"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Carrier"/>.</returns>
        public virtual async Task<Carrier> UpdateAsync(long carrierId, Carrier carrier, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"carrier_services/{carrierId}.json");
            var content = new JsonContent(new
            {
                carrier_service = carrier
            });

            var response = await ExecuteRequestAsync<Carrier>(req, HttpMethod.Put, cancellationToken, content, "carrier_service");
            return response.Result;
        }
    }
}
