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

public class TranslatableResourceEdgeQueryBuilder() : GraphQueryBuilder<TranslatableResourceEdge>("translatableResourceEdge")
{
    public TranslatableResourceEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public TranslatableResourceEdgeQueryBuilder AddFieldNode(Func<TranslatableResourceQueryBuilder, TranslatableResourceQueryBuilder> build)
    {
        AddField<TranslatableResource, TranslatableResourceQueryBuilder>("node", build);
        return this;
    }
}