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

public class DiscountRedeemCodeBulkAddQueryBuilder() : GraphQueryBuilder<DiscountRedeemCodeBulkAddPayload>("query discountRedeemCodeBulkAdd")
{
    public DiscountRedeemCodeBulkAddQueryBuilder AddArgumentCodes(ICollection<DiscountRedeemCodeInput>? codes)
    {
        AddArgument("codes", codes);
        return this;
    }

    public DiscountRedeemCodeBulkAddQueryBuilder AddArgumentDiscountId(string? discountId)
    {
        AddArgument("discountId", discountId);
        return this;
    }
}