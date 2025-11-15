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

public class GiftCardUserErrorQueryBuilder() : GraphQueryBuilder<GiftCardUserError>("query giftCardUserError")
{
    public GiftCardUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public GiftCardUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public GiftCardUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}