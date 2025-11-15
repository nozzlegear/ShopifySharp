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

public class SuggestedStoreCreditRefundQueryBuilder() : GraphQueryBuilder<SuggestedStoreCreditRefund>("query suggestedStoreCreditRefund")
{
    public SuggestedStoreCreditRefundQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public SuggestedStoreCreditRefundQueryBuilder AddFieldExpiresAt()
    {
        AddField("expiresAt");
        return this;
    }

    public SuggestedStoreCreditRefundQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }
}