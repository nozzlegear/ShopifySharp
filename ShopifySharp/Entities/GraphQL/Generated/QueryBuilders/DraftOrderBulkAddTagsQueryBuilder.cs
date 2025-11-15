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

public class DraftOrderBulkAddTagsQueryBuilder() : GraphQueryBuilder<DraftOrderBulkAddTagsPayload>("query draftOrderBulkAddTags")
{
    public DraftOrderBulkAddTagsQueryBuilder AddArgumentIds(ICollection<string>? ids)
    {
        AddArgument("ids", ids);
        return this;
    }

    public DraftOrderBulkAddTagsQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }

    public DraftOrderBulkAddTagsQueryBuilder AddArgumentSearch(string? search)
    {
        AddArgument("search", search);
        return this;
    }

    public DraftOrderBulkAddTagsQueryBuilder AddArgumentTags(ICollection<string>? tags)
    {
        AddArgument("tags", tags);
        return this;
    }
}