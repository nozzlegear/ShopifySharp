using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ICustomerSavedSearchService
    {
        Task<int> CountAsync(CustomerSavedSearchCountFilter filter = null, CancellationToken cancellationToken = default);
        Task<ListResult<CustomerSavedSearch>> ListAsync(ListFilter<CustomerSavedSearch> filter = null, CancellationToken cancellationToken = default);
        Task<ListResult<CustomerSavedSearch>> ListAsync(CustomerSavedSearchListFilter filter, CancellationToken cancellationToken = default);
        Task<CustomerSavedSearch> GetAsync(long customerSearchId, string fields = null, CancellationToken cancellationToken = default);
        Task<CustomerSavedSearch> CreateAsync(CustomerSavedSearch customerSavedSearch, CancellationToken cancellationToken = default);
        Task<CustomerSavedSearch> UpdateAsync(long customerSavedSearchId, CustomerSavedSearch customerSavedSearch, CancellationToken cancellationToken = default);
        Task DeleteAsync(long customerSavedSearchId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Customer>> GetCustomersFromSavedSearchAsync(long customerSavedSearchId, CustomerSavedSearchFilter filter = null, CancellationToken cancellationToken = default);
    }
}