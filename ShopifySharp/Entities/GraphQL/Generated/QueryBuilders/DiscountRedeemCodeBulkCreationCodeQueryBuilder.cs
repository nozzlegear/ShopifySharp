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

public class DiscountRedeemCodeBulkCreationCodeQueryBuilder() : GraphQueryBuilder<DiscountRedeemCodeBulkCreationCode>("query discountRedeemCodeBulkCreationCode")
{
    public DiscountRedeemCodeBulkCreationCodeQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DiscountRedeemCodeBulkCreationCodeQueryBuilder AddFieldDiscountRedeemCode()
    {
        AddField("discountRedeemCode");
        return this;
    }

    public DiscountRedeemCodeBulkCreationCodeQueryBuilder AddFieldErrors()
    {
        AddField("errors");
        return this;
    }
}