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

public class CalculatedReturnShippingFeeQueryBuilder() : GraphQueryBuilder<CalculatedReturnShippingFee>("query calculatedReturnShippingFee")
{
    public CalculatedReturnShippingFeeQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    public CalculatedReturnShippingFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}