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

public class MobilePlatformApplicationConnectionQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationConnection>("query mobilePlatformApplicationConnection")
{
    public MobilePlatformApplicationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MobilePlatformApplicationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MobilePlatformApplicationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}