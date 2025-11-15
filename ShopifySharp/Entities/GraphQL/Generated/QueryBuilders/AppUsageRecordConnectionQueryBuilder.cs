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

public class AppUsageRecordConnectionQueryBuilder() : GraphQueryBuilder<AppUsageRecordConnection>("query appUsageRecordConnection")
{
    public AppUsageRecordConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public AppUsageRecordConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public AppUsageRecordConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}