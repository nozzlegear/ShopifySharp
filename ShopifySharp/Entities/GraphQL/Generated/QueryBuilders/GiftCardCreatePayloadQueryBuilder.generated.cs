#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class GiftCardCreatePayloadQueryBuilder() : GraphQueryBuilder<GiftCardCreatePayload>("giftCardCreatePayload")
{
    public GiftCardCreatePayloadQueryBuilder AddFieldGiftCard(Func<GiftCardQueryBuilder, GiftCardQueryBuilder> build)
    {
        AddField<GiftCard, GiftCardQueryBuilder>("giftCard", build);
        return this;
    }

    public GiftCardCreatePayloadQueryBuilder AddFieldGiftCardCode()
    {
        AddField("giftCardCode");
        return this;
    }

    public GiftCardCreatePayloadQueryBuilder AddFieldUserErrors(Func<GiftCardUserErrorQueryBuilder, GiftCardUserErrorQueryBuilder> build)
    {
        AddField<GiftCardUserError, GiftCardUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}