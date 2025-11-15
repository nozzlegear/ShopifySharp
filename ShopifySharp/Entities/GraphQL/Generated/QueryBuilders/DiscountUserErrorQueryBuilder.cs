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

public class DiscountUserErrorQueryBuilder() : GraphQueryBuilder<DiscountUserError>("query discountUserError")
{
    public DiscountUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DiscountUserErrorQueryBuilder AddFieldExtraInfo()
    {
        AddField("extraInfo");
        return this;
    }

    public DiscountUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DiscountUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}