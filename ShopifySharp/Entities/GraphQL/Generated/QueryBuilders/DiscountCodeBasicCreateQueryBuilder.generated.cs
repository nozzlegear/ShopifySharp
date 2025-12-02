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

public class DiscountCodeBasicCreateQueryBuilder() : GraphQueryBuilder<DiscountCodeBasicCreatePayload>("discountCodeBasicCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DiscountCodeBasicCreateQueryBuilder AddArgumentBasicCodeDiscount(DiscountCodeBasicInput? basicCodeDiscount)
    {
        AddArgument("basicCodeDiscount", basicCodeDiscount);
        return this;
    }
}