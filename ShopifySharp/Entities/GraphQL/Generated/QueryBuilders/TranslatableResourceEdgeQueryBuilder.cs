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

public class TranslatableResourceEdgeQueryBuilder() : GraphQueryBuilder<TranslatableResourceEdge>("query translatableResourceEdge")
{
    public TranslatableResourceEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public TranslatableResourceEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}