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

public class RestockingFeeQueryBuilder() : GraphQueryBuilder<RestockingFee>("query restockingFee")
{
    public RestockingFeeQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    public RestockingFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RestockingFeeQueryBuilder AddFieldPercentage()
    {
        AddField("percentage");
        return this;
    }
}