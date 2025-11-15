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

public class ReturnQueryBuilder() : GraphQueryBuilder<Return>("query return")
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

    public ReturnQueryBuilder AddFieldDecline()
    {
        AddField("decline");
        return this;
    }

    public ReturnQueryBuilder AddFieldExchangeLineItems()
    {
        AddField("exchangeLineItems");
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

    public ReturnQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public ReturnQueryBuilder AddFieldRefunds()
    {
        AddField("refunds");
        return this;
    }

    public ReturnQueryBuilder AddFieldRequestApprovedAt()
    {
        AddField("requestApprovedAt");
        return this;
    }

    public ReturnQueryBuilder AddFieldReturnLineItems()
    {
        AddField("returnLineItems");
        return this;
    }

    public ReturnQueryBuilder AddFieldReturnShippingFees()
    {
        AddField("returnShippingFees");
        return this;
    }

    public ReturnQueryBuilder AddFieldReverseFulfillmentOrders()
    {
        AddField("reverseFulfillmentOrders");
        return this;
    }

    public ReturnQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ReturnQueryBuilder AddFieldSuggestedFinancialOutcome()
    {
        AddField("suggestedFinancialOutcome");
        return this;
    }

    [Obsolete("Use `suggestedFinancialOutcome` instead.")]
    public ReturnQueryBuilder AddFieldSuggestedRefund()
    {
        AddField("suggestedRefund");
        return this;
    }

    public ReturnQueryBuilder AddFieldTotalQuantity()
    {
        AddField("totalQuantity");
        return this;
    }
}