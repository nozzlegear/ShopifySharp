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

public class ReturnShippingFeeQueryBuilder() : GraphQueryBuilder<ReturnShippingFee>("query returnShippingFee")
{
    public ReturnShippingFeeQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    public ReturnShippingFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}