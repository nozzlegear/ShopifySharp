using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

/// <remarks>
/// For the tests below to pass, the required permissions must be granted AND Shopify payments must be set as a payment provider in the store's settings
/// </remarks>
[Trait("Category", "Shopify payments")]
public class ShopifyPayments_Tests
{
	ShopifyPaymentsService Service { get; } = new ShopifyPaymentsService(Utils.MyShopifyUrl, Utils.AccessToken);
	private readonly ITestOutputHelper _testOutputHelper;


	public ShopifyPayments_Tests(ITestOutputHelper testOutputHelper)
	{
		Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
		_testOutputHelper = testOutputHelper;
	}

	[Fact]
	public async Task GetBalance()
	{
		if (await Service.IsShopifyPaymentApiEnabledAsync())
		{
			var balances = await Service.GetBalanceAsync();
			Assert.NotNull(balances);
		}
	}

	[Fact]
	public async Task GetPayouts()
	{
		if (await Service.IsShopifyPaymentApiEnabledAsync())
		{
			var payouts = await Service.ListPayoutsAsync();
			Assert.NotNull(payouts);
		}
	}

	[Fact]
	public async Task GetDisputes()
	{
		if (await Service.IsShopifyPaymentApiEnabledAsync())
		{
			var disputes = await Service.ListDisputesAsync();
			Assert.NotNull(disputes);
		}
	}
	[Fact]
	public async Task GetDisputedEvidence()
	{
		if (await Service.IsShopifyPaymentApiEnabledAsync())
		{
			var disputes = await Service.ListDisputesAsync();
			
			Assert.True((disputes?.Items?.Count() > 0),"There are no disputes to get dispute evidence from.");
			
			_testOutputHelper.WriteLine($"Getting evidence for dispute id '{disputes.Items.First().Id.Value}'.");

			var disputedEvidence = await Service.GetDisputeEvidenceAsync(disputes.Items.First().Id.Value);
			
			Assert.NotNull(disputedEvidence);
		}
	}

	[Fact]
	public async Task PutDisputedEvidence()
	{
		if (await Service.IsShopifyPaymentApiEnabledAsync())
		{
			var disputes = await Service.ListDisputesAsync();
			Assert.True((disputes?.Items?.Count() > 0),"There are no disputes available to add evidence to.");

			_testOutputHelper.WriteLine($"Updating evidence for dispute Id: '{disputes.Items.First().Id.Value}'.");

			ShopifyPaymentsDisputeEvidenceUpdate update = new();
			update.CustomerFirstName = "Tom";
			update.CustomerLastName = "Thumb";
			update.CancellationRebuttal = "You can't cancel past the return period.";
			update.RefundRefusalExplanation = "You are past the return period.";
			update.RefundPolicyDisclosure = "Refund policy is displayed on the checkout page.";
			update.AccessActivityLog = "Email sent detailing return policy.";
			update.UncategorizedText = "You are trying to do something not allowed.";

			var disputedEvidence = await Service.UpdateDisputeEvidenceAsync(disputes.Items.First().Id.Value, update);
			Assert.NotNull(disputedEvidence);
		}
	}

	[Fact]
	public async Task GetTransactions()
	{
		if (await Service.IsShopifyPaymentApiEnabledAsync())
		{
			var transactions = await Service.ListTransactionsAsync();
			Assert.NotNull(transactions);
		}
	}
}