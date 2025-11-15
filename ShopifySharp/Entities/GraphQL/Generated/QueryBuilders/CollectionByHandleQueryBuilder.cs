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

[Obsolete("Use `collectionByIdentifier` instead.")]
public class CollectionByHandleQueryBuilder() : GraphQueryBuilder<Collection>("query collectionByHandle")
{
    public CollectionByHandleQueryBuilder AddArgumentHandle(string? handle)
    {
        AddArgument("handle", handle);
        return this;
    }
}