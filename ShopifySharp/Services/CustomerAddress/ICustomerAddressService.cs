using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ICustomerAddressService : IShopifyService
    {
        /// <summary>
        /// Gets a list of up to 250 of the shop customer's addresses.
        /// </summary>
        /// <param name="customerId">The id of the customer to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<Address>> ListAsync(long customerId, ListFilter<Address> filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="Address"/> with the given id.
        /// </summary>
        /// <param name="customerId">The id of the customer to retrieve.</param>
        /// <param name="addressId">The id of the customer address to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Address"/>.</returns>
        Task<Address> GetAsync(long customerId, long addressId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="Address"/> on the store.
        /// </summary>
        /// <param name="customerId">The id of the customer to create address for.</param>
        /// <param name="address">A new <see cref="Address"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Address"/>.</returns>
        Task<Address> CreateAsync(long customerId, Address address, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="Address"/>.
        /// </summary>
        /// <param name="customerId">Id of the customer object being updated.</param>
        /// <param name="addressId">Id of the address object being updated.</param>
        /// <param name="address">The <see cref="Address"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Customer"/>.</returns>
        Task<Address> UpdateAsync(long customerId, long addressId, Address address, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a address with the given Id from a customer.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <param name="addressId">The address object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long customerId, long addressId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sets the specified address as the default for a customer
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <param name="addressId">The address object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
        Task<Address> SetDefault(long customerId, long addressId, CancellationToken cancellationToken = default);
    }
}