using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ITenderTransactionService
    {
        /// <summary>
        /// Gets a list of up to 250 of the shop's tender transactions.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<TenderTransaction>> ListAsync(ListFilter<TenderTransaction> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's tender transactions.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<TenderTransaction>> ListAsync(TenderTransactionListFilter filter = null, CancellationToken cancellationToken = default);
    }
}