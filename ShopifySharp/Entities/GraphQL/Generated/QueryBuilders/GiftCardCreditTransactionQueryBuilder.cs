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

public class GiftCardCreditTransactionQueryBuilder() : GraphQueryBuilder<GiftCardCreditTransaction>("query giftCardCreditTransaction")
{
    public GiftCardCreditTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public GiftCardCreditTransactionQueryBuilder AddFieldGiftCard()
    {
        AddField("giftCard");
        return this;
    }

    public GiftCardCreditTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public GiftCardCreditTransactionQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    public GiftCardCreditTransactionQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }

    public GiftCardCreditTransactionQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public GiftCardCreditTransactionQueryBuilder AddFieldProcessedAt()
    {
        AddField("processedAt");
        return this;
    }
}