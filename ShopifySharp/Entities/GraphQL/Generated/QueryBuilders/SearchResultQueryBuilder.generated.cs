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

public class SearchResultQueryBuilder() : GraphQueryBuilder<SearchResult>("searchResult")
{
    public SearchResultQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SearchResultQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public SearchResultQueryBuilder AddFieldReference(Func<NodeQueryBuilder, NodeQueryBuilder> build)
    {
        AddField<INode, NodeQueryBuilder>("reference", build);
        return this;
    }

    public SearchResultQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public SearchResultQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}