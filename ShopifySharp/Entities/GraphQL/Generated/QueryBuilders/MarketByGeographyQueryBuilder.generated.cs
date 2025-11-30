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

[Obsolete("This `market_by_geography` field will be removed in a future version of the API.")]
public class MarketByGeographyQueryBuilder() : GraphQueryBuilder<Market>("marketByGeography"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public MarketByGeographyQueryBuilder AddArgumentCountryCode(CountryCode? countryCode)
    {
        AddArgument("countryCode", countryCode);
        return this;
    }
}