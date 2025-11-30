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

public class DiscountCodeFreeShippingCreateQueryBuilder() : GraphQueryBuilder<DiscountCodeFreeShippingCreatePayload>("query discountCodeFreeShippingCreate")
{
    public DiscountCodeFreeShippingCreateQueryBuilder AddArgumentFreeShippingCodeDiscount(DiscountCodeFreeShippingInput? freeShippingCodeDiscount)
    {
        AddArgument("freeShippingCodeDiscount", freeShippingCodeDiscount);
        return this;
    }
}