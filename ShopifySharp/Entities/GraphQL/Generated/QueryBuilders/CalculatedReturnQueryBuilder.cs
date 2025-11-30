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

public class CalculatedReturnQueryBuilder() : GraphQueryBuilder<CalculatedReturn>("query calculatedReturn")
{
    public CalculatedReturnQueryBuilder AddFieldExchangeLineItems()
    {
        AddField("exchangeLineItems");
        return this;
    }

    public CalculatedReturnQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedReturnQueryBuilder AddFieldReturnLineItems()
    {
        AddField("returnLineItems");
        return this;
    }

    public CalculatedReturnQueryBuilder AddFieldReturnShippingFee()
    {
        AddField("returnShippingFee");
        return this;
    }
}