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

public class ArticleTagsQueryBuilder() : GraphQueryBuilder<ICollection<string>?>("query articleTags")
{
    public ArticleTagsQueryBuilder AddReturnValue()
    {
        // This method is a no-op – the value will be included automatically by virtue of this QueryBuilder being including
        return this;
    }

    public ArticleTagsQueryBuilder AddArgumentLimit(int? limit)
    {
        AddArgument("limit", limit);
        return this;
    }

    public ArticleTagsQueryBuilder AddArgumentSort(ArticleTagSort? sort)
    {
        AddArgument("sort", sort);
        return this;
    }
}