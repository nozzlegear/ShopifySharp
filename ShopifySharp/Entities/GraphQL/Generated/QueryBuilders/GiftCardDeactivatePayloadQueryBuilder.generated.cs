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

public class GiftCardDeactivatePayloadQueryBuilder() : GraphQueryBuilder<GiftCardDeactivatePayload>("giftCardDeactivatePayload")
{
    public GiftCardDeactivatePayloadQueryBuilder AddFieldGiftCard(Func<GiftCardQueryBuilder, GiftCardQueryBuilder> build)
    {
        AddField<GiftCard, GiftCardQueryBuilder>("giftCard", build);
        return this;
    }

    public GiftCardDeactivatePayloadQueryBuilder AddFieldUserErrors(Func<GiftCardDeactivateUserErrorQueryBuilder, GiftCardDeactivateUserErrorQueryBuilder> build)
    {
        AddField<GiftCardDeactivateUserError, GiftCardDeactivateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}