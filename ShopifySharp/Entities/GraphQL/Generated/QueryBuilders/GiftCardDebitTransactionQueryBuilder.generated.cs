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

public class GiftCardDebitTransactionQueryBuilder() : GraphQueryBuilder<GiftCardDebitTransaction>("giftCardDebitTransaction")
{
    public GiftCardDebitTransactionQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldGiftCard(Func<GiftCardQueryBuilder, GiftCardQueryBuilder> build)
    {
        AddField<GiftCard, GiftCardQueryBuilder>("giftCard", build);
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldProcessedAt()
    {
        AddField("processedAt");
        return this;
    }
}