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

public class DiscountAutomaticBulkDeleteQueryBuilder() : GraphQueryBuilder<DiscountAutomaticBulkDeletePayload>("query discountAutomaticBulkDelete")
{
    public DiscountAutomaticBulkDeleteQueryBuilder AddArgumentIds(ICollection<string>? ids)
    {
        AddArgument("ids", ids);
        return this;
    }

    public DiscountAutomaticBulkDeleteQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }

    public DiscountAutomaticBulkDeleteQueryBuilder AddArgumentSearch(string? search)
    {
        AddArgument("search", search);
        return this;
    }
}