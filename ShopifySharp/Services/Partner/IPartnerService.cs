using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ShopifySharp
{
    public interface IPartnerService : IShopifyService
    {
        /// <summary>
        /// Executes a Graph API Call.
        /// </summary>
        /// <param name="body">The query you would like to execute. Please see documentation for formatting.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>A JToken containing the data from the request.</returns>
        Task<JToken> PostAsync(string body, CancellationToken cancellationToken = default);
    }
}