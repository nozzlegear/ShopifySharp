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

public class DiscountRedeemCodeQueryBuilder() : GraphQueryBuilder<DiscountRedeemCode>("query discountRedeemCode")
{
    public DiscountRedeemCodeQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountRedeemCodeQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DiscountRedeemCodeQueryBuilder AddFieldCreatedBy()
    {
        AddField("createdBy");
        return this;
    }

    public DiscountRedeemCodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}