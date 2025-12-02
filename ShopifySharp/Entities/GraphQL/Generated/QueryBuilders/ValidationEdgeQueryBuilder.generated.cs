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

public class ValidationEdgeQueryBuilder() : GraphQueryBuilder<ValidationEdge>("validationEdge")
{
    public ValidationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ValidationEdgeQueryBuilder AddFieldNode(Func<ValidationQueryBuilder, ValidationQueryBuilder> build)
    {
        AddField<Validation, ValidationQueryBuilder>("node", build);
        return this;
    }
}