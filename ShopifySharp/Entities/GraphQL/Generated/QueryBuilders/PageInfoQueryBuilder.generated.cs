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

public class PageInfoQueryBuilder() : GraphQueryBuilder<PageInfo>("pageInfo")
{
    public PageInfoQueryBuilder AddFieldEndCursor()
    {
        AddField("endCursor");
        return this;
    }

    public PageInfoQueryBuilder AddFieldHasNextPage()
    {
        AddField("hasNextPage");
        return this;
    }

    public PageInfoQueryBuilder AddFieldHasPreviousPage()
    {
        AddField("hasPreviousPage");
        return this;
    }

    public PageInfoQueryBuilder AddFieldStartCursor()
    {
        AddField("startCursor");
        return this;
    }
}