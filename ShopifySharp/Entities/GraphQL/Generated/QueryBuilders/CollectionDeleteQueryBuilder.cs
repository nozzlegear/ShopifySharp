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

public class CollectionDeleteQueryBuilder() : GraphQueryBuilder<CollectionDeletePayload>("query collectionDelete")
{
    public CollectionDeleteQueryBuilder AddArgumentInput(CollectionDeleteInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}