#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopifyPaymentsPayoutSummaryQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutSummary>("query shopifyPaymentsPayoutSummary")
{
    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldAdjustmentsFee()
    {
        AddField("adjustmentsFee");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldAdjustmentsGross()
    {
        AddField("adjustmentsGross");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldAdvanceFees()
    {
        AddField("advanceFees");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldAdvanceGross()
    {
        AddField("advanceGross");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldChargesFee()
    {
        AddField("chargesFee");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldChargesGross()
    {
        AddField("chargesGross");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldRefundsFee()
    {
        AddField("refundsFee");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldRefundsFeeGross()
    {
        AddField("refundsFeeGross");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldReservedFundsFee()
    {
        AddField("reservedFundsFee");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldReservedFundsGross()
    {
        AddField("reservedFundsGross");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldRetriedPayoutsFee()
    {
        AddField("retriedPayoutsFee");
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldRetriedPayoutsGross()
    {
        AddField("retriedPayoutsGross");
        return this;
    }
}