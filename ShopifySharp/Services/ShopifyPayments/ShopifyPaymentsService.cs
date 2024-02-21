using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Infrastructure;
using ShopifySharp.Utilities;

namespace ShopifySharp
{
	/// <summary>
	/// A service for manipulating Shopify payments.
	/// </summary>
	public class ShopifyPaymentsService : ShopifyService, IShopifyPaymentsService
	{
		/// <summary>
		/// Creates a new instance of <see cref="ShopifyPaymentsService" />.
		/// </summary>
		/// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
		/// <param name="shopAccessToken">An API access token for the shop.</param>
		public ShopifyPaymentsService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
		internal ShopifyPaymentsService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) { }

		/// <inheritdoc />
		public virtual async Task<bool> IsShopifyPaymentApiEnabledAsync(CancellationToken cancellationToken = default)
		{
			try
			{
				//calling any method endpoint would do, but choosing GetBalance because it is likely the most lightweight
				await this.GetBalanceAsync(cancellationToken);
				return true;
			}
			catch (ShopifyHttpException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
			{
				return false;
			}
		}

		/// <inheritdoc />
		public virtual async Task<IEnumerable<ShopifyPaymentsBalance>> GetBalanceAsync(CancellationToken cancellationToken = default) =>
			await ExecuteGetAsync<IEnumerable<ShopifyPaymentsBalance>>("shopify_payments/balance.json", "balance", cancellationToken: cancellationToken);

		/// <inheritdoc />
		public virtual async Task<ListResult<ShopifyPaymentsPayout>> ListPayoutsAsync(ListFilter<ShopifyPaymentsPayout> filter, CancellationToken cancellationToken = default) =>
			await ExecuteGetListAsync("shopify_payments/payouts.json", "payouts", filter, cancellationToken: cancellationToken);

		/// <inheritdoc />
		public virtual async Task<ListResult<ShopifyPaymentsPayout>> ListPayoutsAsync(ShopifyPaymentsPayoutListFilter filter = null, CancellationToken cancellationToken = default) =>
			await ListPayoutsAsync(filter?.AsListFilter(), cancellationToken);

		/// <inheritdoc />
		public virtual async Task<ShopifyPaymentsPayout> GetPayoutAsync(long payoutId, CancellationToken cancellationToken = default) =>
			await ExecuteGetAsync<ShopifyPaymentsPayout>($"shopify_payments/payouts/{payoutId}.json", "payout", cancellationToken: cancellationToken);

		/// <inheritdoc />
		public virtual async Task<ListResult<ShopifyPaymentsDispute>> ListDisputesAsync(ListFilter<ShopifyPaymentsDispute> filter, CancellationToken cancellationToken = default) =>
			await ExecuteGetListAsync("shopify_payments/disputes.json", "disputes", filter, cancellationToken: cancellationToken);

		/// <inheritdoc />
		public virtual async Task<ListResult<ShopifyPaymentsDispute>> ListDisputesAsync(ShopifyPaymentsDisputeListFilter filter = null, CancellationToken cancellationToken = default) =>
			await ListDisputesAsync(filter?.AsListFilter(), cancellationToken);

		/// <inheritdoc />
		public virtual async Task<ShopifyPaymentsDispute> GetDisputeAsync(long disputeId, CancellationToken cancellationToken = default) =>
			await ExecuteGetAsync<ShopifyPaymentsDispute>($"shopify_payments/disputes/{disputeId}.json", "dispute", cancellationToken: cancellationToken);

		/// <inheritdoc />
		public virtual async Task<ListResult<ShopifyPaymentsTransaction>> ListTransactionsAsync(ListFilter<ShopifyPaymentsTransaction> filter, CancellationToken cancellationToken = default) =>
			await ExecuteGetListAsync("shopify_payments/balance/transactions.json", "transactions", filter, cancellationToken: cancellationToken);

		/// <inheritdoc />
		public virtual async Task<ListResult<ShopifyPaymentsTransaction>> ListTransactionsAsync(ShopifyPaymentsTransactionListFilter filter = null, CancellationToken cancellationToken = default) =>
			await ListTransactionsAsync(filter?.AsListFilter(), cancellationToken);
		
		/// <inheritdoc />
		public async Task<ShopifyPaymentsDisputeEvidence> GetDisputeEvidenceAsync(long disputeId, CancellationToken cancellationToken = default) =>
			await ExecuteGetAsync<ShopifyPaymentsDisputeEvidence>($"shopify_payments/disputes/{disputeId}/dispute_evidences.json", "dispute_evidence", cancellationToken: cancellationToken);
		
		/// <inheritdoc />
		public async Task<ShopifyPaymentsDisputeEvidence> UpdateDisputeEvidenceAsync(long disputeId, ShopifyPaymentsDisputeEvidenceUpdate updateRequest, CancellationToken cancellationToken = default) =>
			await ExecutePutAsync<ShopifyPaymentsDisputeEvidence>($"shopify_payments/disputes/{disputeId}/dispute_evidences.json", "dispute_evidence", cancellationToken: cancellationToken, updateRequest);
	}
}
