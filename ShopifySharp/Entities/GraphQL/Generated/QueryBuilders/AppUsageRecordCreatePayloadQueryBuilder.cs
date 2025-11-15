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

public class AppUsageRecordCreatePayloadQueryBuilder() : GraphQueryBuilder<AppUsageRecordCreatePayload>("query appUsageRecordCreatePayload")
{
    public AppUsageRecordCreatePayloadQueryBuilder AddFieldAppUsageRecord()
    {
        AddField("appUsageRecord");
        return this;
    }

    public AppUsageRecordCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}