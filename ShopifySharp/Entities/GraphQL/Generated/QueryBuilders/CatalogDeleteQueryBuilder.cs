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

public class CatalogDeleteQueryBuilder() : GraphQueryBuilder<CatalogDeletePayload>("query catalogDelete")
{
    public CatalogDeleteQueryBuilder AddArgumentDeleteDependentResources(bool? deleteDependentResources)
    {
        AddArgument("deleteDependentResources", deleteDependentResources);
        return this;
    }

    public CatalogDeleteQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}