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

public class DiscountCodeAppUpdateQueryBuilder() : GraphQueryBuilder<DiscountCodeAppUpdatePayload>("discountCodeAppUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DiscountCodeAppUpdateQueryBuilder AddArgumentCodeAppDiscount(DiscountCodeAppInput? codeAppDiscount)
    {
        AddArgument("codeAppDiscount", codeAppDiscount);
        return this;
    }

    public DiscountCodeAppUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}