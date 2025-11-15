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

public class ICalculatedReturnFeeQueryBuilder() : GraphQueryBuilder<ICalculatedReturnFee>("query iCalculatedReturnFee")
{
    public ICalculatedReturnFeeQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    public ICalculatedReturnFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}