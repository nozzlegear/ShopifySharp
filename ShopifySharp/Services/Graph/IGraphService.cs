using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ShopifySharp
{
    public interface IGraphService : IShopifyService
    {
        /// <summary>
        /// Executes a Graph API Call.
        /// </summary>
        /// <param name="body">The query you would like to execute. Please see documentation for formatting.</param>
        /// <param name="graphqlQueryCost">
        /// The requestedQueryCost available at extensions.cost.requestedQueryCost.
        /// While it is optional, it is recommended to provide it to avoid wasting resources to issue API calls that will be throttled
        /// </param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>A JToken containing the data from the request.</returns>
        Task<JToken> PostAsync(string body, int? graphqlQueryCost = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Executes a Graph API Call.
        /// </summary>
        /// <param name="body">The query you would like to execute, as a JToken. Please see documentation for formatting.</param>
        /// <param name="graphqlQueryCost">
        /// The requestedQueryCost available at extensions.cost.requestedQueryCost.
        /// While it is optional, it is recommended to provide it to avoid wasting resources to issue API calls that will be throttled
        /// </param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>A JToken containing the data from the request.</returns>
        Task<JToken> PostAsync(JToken body, int? graphqlQueryCost = null, CancellationToken cancellationToken = default);
    }
}