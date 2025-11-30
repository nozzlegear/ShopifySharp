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

public class PriceListFixedPricesDeleteQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesDeletePayload>("priceListFixedPricesDelete"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public PriceListFixedPricesDeleteQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }

    public PriceListFixedPricesDeleteQueryBuilder AddArgumentVariantIds(ICollection<string>? variantIds)
    {
        AddArgument("variantIds", variantIds);
        return this;
    }
}