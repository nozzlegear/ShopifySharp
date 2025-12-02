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

public class QuantityRulesDeleteQueryBuilder() : GraphQueryBuilder<QuantityRulesDeletePayload>("quantityRulesDelete"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public QuantityRulesDeleteQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }

    public QuantityRulesDeleteQueryBuilder AddArgumentVariantIds(ICollection<string>? variantIds)
    {
        AddArgument("variantIds", variantIds);
        return this;
    }
}