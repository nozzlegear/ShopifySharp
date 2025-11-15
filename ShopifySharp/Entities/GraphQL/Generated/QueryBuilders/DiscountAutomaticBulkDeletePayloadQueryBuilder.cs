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

public class DiscountAutomaticBulkDeletePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticBulkDeletePayload>("query discountAutomaticBulkDeletePayload")
{
    public DiscountAutomaticBulkDeletePayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public DiscountAutomaticBulkDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}