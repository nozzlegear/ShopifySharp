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

public class PriceListFixedPricesByProductUpdateQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesByProductUpdatePayload>("priceListFixedPricesByProductUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public PriceListFixedPricesByProductUpdateQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }

    public PriceListFixedPricesByProductUpdateQueryBuilder AddArgumentPricesToAdd(ICollection<PriceListProductPriceInput>? pricesToAdd)
    {
        AddArgument("pricesToAdd", pricesToAdd);
        return this;
    }

    public PriceListFixedPricesByProductUpdateQueryBuilder AddArgumentPricesToDeleteByProductIds(ICollection<string>? pricesToDeleteByProductIds)
    {
        AddArgument("pricesToDeleteByProductIds", pricesToDeleteByProductIds);
        return this;
    }
}