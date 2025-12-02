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

public class ShopLocaleEnableQueryBuilder() : GraphQueryBuilder<ShopLocaleEnablePayload>("shopLocaleEnable"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ShopLocaleEnableQueryBuilder AddArgumentLocale(string? locale)
    {
        AddArgument("locale", locale);
        return this;
    }

    public ShopLocaleEnableQueryBuilder AddArgumentMarketWebPresenceIds(ICollection<string>? marketWebPresenceIds)
    {
        AddArgument("marketWebPresenceIds", marketWebPresenceIds);
        return this;
    }
}