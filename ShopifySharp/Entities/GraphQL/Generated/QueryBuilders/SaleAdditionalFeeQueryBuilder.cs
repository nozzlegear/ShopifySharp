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

public class SaleAdditionalFeeQueryBuilder() : GraphQueryBuilder<SaleAdditionalFee>("query saleAdditionalFee")
{
    public SaleAdditionalFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SaleAdditionalFeeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public SaleAdditionalFeeQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public SaleAdditionalFeeQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }
}