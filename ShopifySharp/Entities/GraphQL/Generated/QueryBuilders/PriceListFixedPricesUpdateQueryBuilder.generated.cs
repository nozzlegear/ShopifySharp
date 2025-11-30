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

public class PriceListFixedPricesUpdateQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesUpdatePayload>("priceListFixedPricesUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public PriceListFixedPricesUpdateQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }

    public PriceListFixedPricesUpdateQueryBuilder AddArgumentPricesToAdd(ICollection<PriceListPriceInput>? pricesToAdd)
    {
        AddArgument("pricesToAdd", pricesToAdd);
        return this;
    }

    public PriceListFixedPricesUpdateQueryBuilder AddArgumentVariantIdsToDelete(ICollection<string>? variantIdsToDelete)
    {
        AddArgument("variantIdsToDelete", variantIdsToDelete);
        return this;
    }
}