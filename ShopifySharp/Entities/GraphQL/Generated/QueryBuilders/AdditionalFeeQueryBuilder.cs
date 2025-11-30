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

public class AdditionalFeeQueryBuilder() : GraphQueryBuilder<AdditionalFee>("query additionalFee")
{
    public AdditionalFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AdditionalFeeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public AdditionalFeeQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public AdditionalFeeQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }
}