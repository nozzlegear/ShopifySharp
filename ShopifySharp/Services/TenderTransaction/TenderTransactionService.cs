using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for listing Shopify tender transactions.
    /// </summary>
    public class TenderTransactionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="TenderTransactionService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public TenderTransactionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 of the shop's tender transactions.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<TenderTransaction>> ListAsync(ListFilter<TenderTransaction> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("tender_transactions.json", "tender_transactions", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's tender transactions.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<TenderTransaction>> ListAsync(TenderTransactionListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }
    }
}
