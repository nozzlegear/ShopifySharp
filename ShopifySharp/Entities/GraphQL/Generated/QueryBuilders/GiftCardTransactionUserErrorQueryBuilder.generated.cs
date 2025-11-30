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

public class GiftCardTransactionUserErrorQueryBuilder() : GraphQueryBuilder<GiftCardTransactionUserError>("giftCardTransactionUserError")
{
    public GiftCardTransactionUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public GiftCardTransactionUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public GiftCardTransactionUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}