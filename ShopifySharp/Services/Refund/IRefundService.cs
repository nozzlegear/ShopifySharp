using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

public interface IRefundService : IShopifyService
{
    /// <summary>
    /// Retrieves a list of refunds for an order.
    /// </summary>
    /// <param name="orderId">The id of the order to list orders for.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<Refund>> ListForOrderAsync(long orderId, ListFilter<Refund> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a list of refunds for an order.
    /// </summary>
    /// <param name="orderId">The id of the order to list orders for.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<Refund>> ListForOrderAsync(long orderId, RefundListFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a specific refund.
    /// </summary>
    /// <param name="orderId"></param>
    /// <param name="refundId"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<Refund> GetAsync(long orderId, long refundId, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Calculates <see cref="Refund"/> transactions based on line items and shipping.
    /// When you want to create a refund, you should first use the calculate endpoint to generate accurate refund transactions.
    /// Specify the line items that are being refunded, their quantity and restock instructions, and whether you intend to refund shipping costs.
    /// If the restock instructions can't be met—for example, because you try to return more items than have been fulfilled—then the endpoint returns modified restock instructions.
    /// You can then use the response in the body of the request to create the actual refund.
    /// The response includes a transactions object with "kind": "suggested_refund", which must to be changed to "kind" : "refund" for the refund to be accepted.
    /// </summary>
    Task<Refund> CalculateAsync(long orderId, Refund options, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a <see cref="Refund"/>. Use the calculate endpoint to produce the transactions to submit.
    /// </summary>
    Task<Refund> RefundAsync(long orderId, Refund options, CancellationToken cancellationToken = default);
}