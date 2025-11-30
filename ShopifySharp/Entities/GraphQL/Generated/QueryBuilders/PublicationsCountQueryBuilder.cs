#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class PublicationsCountQueryBuilder() : GraphQueryBuilder<Count>("query publicationsCount")
{
    public PublicationsCountQueryBuilder AddArgumentCatalogType(CatalogType? catalogType)
    {
        AddArgument("catalogType", catalogType);
        return this;
    }

    public PublicationsCountQueryBuilder AddArgumentLimit(int? limit)
    {
        AddArgument("limit", limit);
        return this;
    }
}