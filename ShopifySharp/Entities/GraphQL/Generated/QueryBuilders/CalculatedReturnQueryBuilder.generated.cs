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

public class CalculatedReturnQueryBuilder() : GraphQueryBuilder<CalculatedReturn>("calculatedReturn")
{
    public CalculatedReturnQueryBuilder AddFieldExchangeLineItems(Func<CalculatedExchangeLineItemQueryBuilder, CalculatedExchangeLineItemQueryBuilder> build)
    {
        AddField<CalculatedExchangeLineItem, CalculatedExchangeLineItemQueryBuilder>("exchangeLineItems", build);
        return this;
    }

    public CalculatedReturnQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedReturnQueryBuilder AddFieldReturnLineItems(Func<CalculatedReturnLineItemQueryBuilder, CalculatedReturnLineItemQueryBuilder> build)
    {
        AddField<CalculatedReturnLineItem, CalculatedReturnLineItemQueryBuilder>("returnLineItems", build);
        return this;
    }

    public CalculatedReturnQueryBuilder AddFieldReturnShippingFee(Func<CalculatedReturnShippingFeeQueryBuilder, CalculatedReturnShippingFeeQueryBuilder> build)
    {
        AddField<CalculatedReturnShippingFee, CalculatedReturnShippingFeeQueryBuilder>("returnShippingFee", build);
        return this;
    }
}