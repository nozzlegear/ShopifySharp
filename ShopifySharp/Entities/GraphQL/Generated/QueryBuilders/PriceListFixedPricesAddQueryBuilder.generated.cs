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

public class PriceListFixedPricesAddQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesAddPayload>("priceListFixedPricesAdd"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public PriceListFixedPricesAddQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }

    public PriceListFixedPricesAddQueryBuilder AddArgumentPrices(ICollection<PriceListPriceInput>? prices)
    {
        AddArgument("prices", prices);
        return this;
    }
}