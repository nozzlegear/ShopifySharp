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

public class ValidationEdgeQueryBuilder() : GraphQueryBuilder<ValidationEdge>("query validationEdge")
{
    public ValidationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ValidationEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}