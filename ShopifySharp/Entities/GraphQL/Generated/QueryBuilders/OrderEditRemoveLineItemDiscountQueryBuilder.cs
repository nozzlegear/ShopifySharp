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

[Obsolete("Use `orderEditRemoveDiscount` instead.")]
public class OrderEditRemoveLineItemDiscountQueryBuilder() : GraphQueryBuilder<OrderEditRemoveLineItemDiscountPayload>("query orderEditRemoveLineItemDiscount")
{
    public OrderEditRemoveLineItemDiscountQueryBuilder AddArgumentDiscountApplicationId(string? discountApplicationId)
    {
        AddArgument("discountApplicationId", discountApplicationId);
        return this;
    }

    public OrderEditRemoveLineItemDiscountQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}