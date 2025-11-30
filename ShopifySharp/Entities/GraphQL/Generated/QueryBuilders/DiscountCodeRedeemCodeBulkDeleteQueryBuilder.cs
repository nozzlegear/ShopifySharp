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

public class DiscountCodeRedeemCodeBulkDeleteQueryBuilder() : GraphQueryBuilder<DiscountCodeRedeemCodeBulkDeletePayload>("query discountCodeRedeemCodeBulkDelete")
{
    public DiscountCodeRedeemCodeBulkDeleteQueryBuilder AddArgumentDiscountId(string? discountId)
    {
        AddArgument("discountId", discountId);
        return this;
    }

    public DiscountCodeRedeemCodeBulkDeleteQueryBuilder AddArgumentIds(ICollection<string>? ids)
    {
        AddArgument("ids", ids);
        return this;
    }

    public DiscountCodeRedeemCodeBulkDeleteQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }

    public DiscountCodeRedeemCodeBulkDeleteQueryBuilder AddArgumentSearch(string? search)
    {
        AddArgument("search", search);
        return this;
    }
}