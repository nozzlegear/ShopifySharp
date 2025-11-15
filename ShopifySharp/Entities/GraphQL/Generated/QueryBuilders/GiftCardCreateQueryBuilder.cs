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

public class GiftCardCreateQueryBuilder() : GraphQueryBuilder<GiftCardCreatePayload>("query giftCardCreate")
{
    public GiftCardCreateQueryBuilder AddArgumentInput(GiftCardCreateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}