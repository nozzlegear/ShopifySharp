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

public class DiscountCodeAppCreateQueryBuilder() : GraphQueryBuilder<DiscountCodeAppCreatePayload>("query discountCodeAppCreate")
{
    public DiscountCodeAppCreateQueryBuilder AddArgumentCodeAppDiscount(DiscountCodeAppInput? codeAppDiscount)
    {
        AddArgument("codeAppDiscount", codeAppDiscount);
        return this;
    }
}