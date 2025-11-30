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

public class ReturnQueryBuilder() : GraphQueryBuilder<Return>("return")
{
    public ReturnQueryBuilder AddFieldClosedAt()
    {
        AddField("closedAt");
        return this;
    }

    public ReturnQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ReturnQueryBuilder AddFieldDecline(Func<ReturnDeclineQueryBuilder, ReturnDeclineQueryBuilder> build)
    {
        AddField<ReturnDecline, ReturnDeclineQueryBuilder>("decline", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldExchangeLineItems(Func<ExchangeLineItemConnectionQueryBuilder, ExchangeLineItemConnectionQueryBuilder> build)
    {
        AddField<ExchangeLineItemConnection, ExchangeLineItemConnectionQueryBuilder>("exchangeLineItems", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReturnQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ReturnQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldRefunds(Func<RefundConnectionQueryBuilder, RefundConnectionQueryBuilder> build)
    {
        AddField<RefundConnection, RefundConnectionQueryBuilder>("refunds", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldRequestApprovedAt()
    {
        AddField("requestApprovedAt");
        return this;
    }

    public ReturnQueryBuilder AddFieldReturnLineItems(Func<ReturnLineItemTypeConnectionQueryBuilder, ReturnLineItemTypeConnectionQueryBuilder> build)
    {
        AddField<ReturnLineItemTypeConnection, ReturnLineItemTypeConnectionQueryBuilder>("returnLineItems", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldReturnShippingFees(Func<ReturnShippingFeeQueryBuilder, ReturnShippingFeeQueryBuilder> build)
    {
        AddField<ReturnShippingFee, ReturnShippingFeeQueryBuilder>("returnShippingFees", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldReverseFulfillmentOrders(Func<ReverseFulfillmentOrderConnectionQueryBuilder, ReverseFulfillmentOrderConnectionQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderConnection, ReverseFulfillmentOrderConnectionQueryBuilder>("reverseFulfillmentOrders", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ReturnQueryBuilder AddFieldSuggestedFinancialOutcome(Func<SuggestedReturnFinancialOutcomeQueryBuilder, SuggestedReturnFinancialOutcomeQueryBuilder> build)
    {
        AddField<SuggestedReturnFinancialOutcome, SuggestedReturnFinancialOutcomeQueryBuilder>("suggestedFinancialOutcome", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldSuggestedRefund(Func<SuggestedReturnRefundQueryBuilder, SuggestedReturnRefundQueryBuilder> build)
    {
        AddField<SuggestedReturnRefund, SuggestedReturnRefundQueryBuilder>("suggestedRefund", build);
        return this;
    }

    public ReturnQueryBuilder AddFieldTotalQuantity()
    {
        AddField("totalQuantity");
        return this;
    }
}