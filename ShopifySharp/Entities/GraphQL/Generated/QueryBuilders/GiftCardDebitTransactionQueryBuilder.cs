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

public class GiftCardDebitTransactionQueryBuilder() : GraphQueryBuilder<GiftCardDebitTransaction>("query giftCardDebitTransaction")
{
    public GiftCardDebitTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldGiftCard()
    {
        AddField("giftCard");
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    public GiftCardDebitTransactionQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
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