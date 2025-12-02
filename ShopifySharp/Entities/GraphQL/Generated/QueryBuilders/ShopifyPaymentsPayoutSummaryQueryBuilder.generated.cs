#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopifyPaymentsPayoutSummaryQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutSummary>("shopifyPaymentsPayoutSummary")
{
    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldAdjustmentsFee(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("adjustmentsFee", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldAdjustmentsGross(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("adjustmentsGross", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldAdvanceFees(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("advanceFees", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldAdvanceGross(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("advanceGross", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldChargesFee(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("chargesFee", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldChargesGross(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("chargesGross", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldRefundsFee(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("refundsFee", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldRefundsFeeGross(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("refundsFeeGross", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldReservedFundsFee(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("reservedFundsFee", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldReservedFundsGross(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("reservedFundsGross", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldRetriedPayoutsFee(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("retriedPayoutsFee", build);
        return this;
    }

    public ShopifyPaymentsPayoutSummaryQueryBuilder AddFieldRetriedPayoutsGross(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("retriedPayoutsGross", build);
        return this;
    }
}