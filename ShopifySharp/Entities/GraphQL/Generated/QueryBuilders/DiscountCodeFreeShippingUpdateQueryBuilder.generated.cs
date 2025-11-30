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

public class DiscountCodeFreeShippingUpdateQueryBuilder() : GraphQueryBuilder<DiscountCodeFreeShippingUpdatePayload>("discountCodeFreeShippingUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DiscountCodeFreeShippingUpdateQueryBuilder AddArgumentFreeShippingCodeDiscount(DiscountCodeFreeShippingInput? freeShippingCodeDiscount)
    {
        AddArgument("freeShippingCodeDiscount", freeShippingCodeDiscount);
        return this;
    }

    public DiscountCodeFreeShippingUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}