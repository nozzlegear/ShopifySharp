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

public class DraftOrderBulkRemoveTagsQueryBuilder() : GraphQueryBuilder<DraftOrderBulkRemoveTagsPayload>("query draftOrderBulkRemoveTags")
{
    public DraftOrderBulkRemoveTagsQueryBuilder AddArgumentIds(ICollection<string>? ids)
    {
        AddArgument("ids", ids);
        return this;
    }

    public DraftOrderBulkRemoveTagsQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }

    public DraftOrderBulkRemoveTagsQueryBuilder AddArgumentSearch(string? search)
    {
        AddArgument("search", search);
        return this;
    }

    public DraftOrderBulkRemoveTagsQueryBuilder AddArgumentTags(ICollection<string>? tags)
    {
        AddArgument("tags", tags);
        return this;
    }
}