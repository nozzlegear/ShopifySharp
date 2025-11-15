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

public class DiscountCodeBulkActivatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeBulkActivatePayload>("query discountCodeBulkActivatePayload")
{
    public DiscountCodeBulkActivatePayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public DiscountCodeBulkActivatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}