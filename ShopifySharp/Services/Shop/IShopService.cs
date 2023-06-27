using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public interface IShopService : IShopifyService
    {
        /// <summary>
        /// Gets the shop's data.
        /// </summary>
        Task<Shop> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Forces the shop to uninstall your Shopify app. Uninstalling an application is an irreversible operation. Be entirely sure that you no longer need to make API calls for the shop in which the application has been installed.
        /// </summary>
        Task UninstallAppAsync(CancellationToken cancellationToken = default);
    }
}