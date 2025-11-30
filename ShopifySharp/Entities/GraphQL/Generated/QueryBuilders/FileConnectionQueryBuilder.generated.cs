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

public class FileConnectionQueryBuilder() : GraphQueryBuilder<FileConnection>("fileConnection")
{
    public FileConnectionQueryBuilder AddFieldEdges(Func<FileEdgeQueryBuilder, FileEdgeQueryBuilder> build)
    {
        AddField<FileEdge, FileEdgeQueryBuilder>("edges", build);
        return this;
    }

    public FileConnectionQueryBuilder AddFieldNodes(Func<FileQueryBuilder, FileQueryBuilder> build)
    {
        AddField<IFile, FileQueryBuilder>("nodes", build);
        return this;
    }

    public FileConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}