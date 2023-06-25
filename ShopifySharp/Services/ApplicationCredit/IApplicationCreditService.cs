using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IApplicationCreditService
    {
        /// <summary>
        /// Gets a list of all past and present application credits.
        /// </summary>
        Task<ListResult<ApplicationCredit>> ListAsync(ListFilter<ApplicationCredit> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of all past and present application credits.
        /// </summary>
        Task<ListResult<ApplicationCredit>> ListAsync(ApplicationCreditListFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the application credit with the given id.
        /// </summary>
        /// <param name="id">The application credit's id.</param>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ApplicationCredit> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="ApplicationCredit"/>.
        /// </summary>
        /// <param name="credit">A new <see cref="ApplicationCredit"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ApplicationCredit> CreateAsync(ApplicationCredit credit, CancellationToken cancellationToken = default);
    }
}