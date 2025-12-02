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

public class LocalizationExtensionEdgeQueryBuilder() : GraphQueryBuilder<LocalizationExtensionEdge>("localizationExtensionEdge")
{
    public LocalizationExtensionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public LocalizationExtensionEdgeQueryBuilder AddFieldNode(Func<LocalizationExtensionQueryBuilder, LocalizationExtensionQueryBuilder> build)
    {
        AddField<LocalizationExtension, LocalizationExtensionQueryBuilder>("node", build);
        return this;
    }
}