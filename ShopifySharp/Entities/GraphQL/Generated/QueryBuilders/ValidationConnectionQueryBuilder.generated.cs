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

public class ValidationConnectionQueryBuilder() : GraphQueryBuilder<ValidationConnection>("validationConnection")
{
    public ValidationConnectionQueryBuilder AddFieldEdges(Func<ValidationEdgeQueryBuilder, ValidationEdgeQueryBuilder> build)
    {
        AddField<ValidationEdge, ValidationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ValidationConnectionQueryBuilder AddFieldNodes(Func<ValidationQueryBuilder, ValidationQueryBuilder> build)
    {
        AddField<Validation, ValidationQueryBuilder>("nodes", build);
        return this;
    }

    public ValidationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}