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

public class DiscountCodeBulkDeactivatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeBulkDeactivatePayload>("query discountCodeBulkDeactivatePayload")
{
    public DiscountCodeBulkDeactivatePayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public DiscountCodeBulkDeactivatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}