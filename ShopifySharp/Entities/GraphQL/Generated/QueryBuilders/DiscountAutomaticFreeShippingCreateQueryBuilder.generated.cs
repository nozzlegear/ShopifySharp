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

public class DiscountAutomaticFreeShippingCreateQueryBuilder() : GraphQueryBuilder<DiscountAutomaticFreeShippingCreatePayload>("discountAutomaticFreeShippingCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DiscountAutomaticFreeShippingCreateQueryBuilder AddArgumentFreeShippingAutomaticDiscount(DiscountAutomaticFreeShippingInput? freeShippingAutomaticDiscount)
    {
        AddArgument("freeShippingAutomaticDiscount", freeShippingAutomaticDiscount);
        return this;
    }
}