using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp
{
    public interface IShippingZoneService : IShopifyService
    {
        /// <summary>
        /// Retrieves a list of all shipping zones. 
        /// </summary>
        Task<IEnumerable<ShippingZone>> ListAsync(ShippingZoneListFilter filter = null, CancellationToken cancellationToken = default);
    }
}