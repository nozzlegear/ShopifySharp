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

public class LocalizationExtensionConnectionQueryBuilder() : GraphQueryBuilder<LocalizationExtensionConnection>("localizationExtensionConnection")
{
    public LocalizationExtensionConnectionQueryBuilder AddFieldEdges(Func<LocalizationExtensionEdgeQueryBuilder, LocalizationExtensionEdgeQueryBuilder> build)
    {
        AddField<LocalizationExtensionEdge, LocalizationExtensionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public LocalizationExtensionConnectionQueryBuilder AddFieldNodes(Func<LocalizationExtensionQueryBuilder, LocalizationExtensionQueryBuilder> build)
    {
        AddField<LocalizationExtension, LocalizationExtensionQueryBuilder>("nodes", build);
        return this;
    }

    public LocalizationExtensionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}