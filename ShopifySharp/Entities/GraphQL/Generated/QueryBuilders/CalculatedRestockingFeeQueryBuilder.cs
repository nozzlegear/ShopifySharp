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

public class CalculatedRestockingFeeQueryBuilder() : GraphQueryBuilder<CalculatedRestockingFee>("query calculatedRestockingFee")
{
    public CalculatedRestockingFeeQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    public CalculatedRestockingFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedRestockingFeeQueryBuilder AddFieldPercentage()
    {
        AddField("percentage");
        return this;
    }
}