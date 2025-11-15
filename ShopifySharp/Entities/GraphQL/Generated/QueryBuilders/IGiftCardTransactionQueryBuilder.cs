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

public class IGiftCardTransactionQueryBuilder() : GraphQueryBuilder<IGiftCardTransaction>("query iGiftCardTransaction")
{
    public IGiftCardTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public IGiftCardTransactionQueryBuilder AddFieldGiftCard()
    {
        AddField("giftCard");
        return this;
    }

    public IGiftCardTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public IGiftCardTransactionQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    public IGiftCardTransactionQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }

    public IGiftCardTransactionQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public IGiftCardTransactionQueryBuilder AddFieldProcessedAt()
    {
        AddField("processedAt");
        return this;
    }
}