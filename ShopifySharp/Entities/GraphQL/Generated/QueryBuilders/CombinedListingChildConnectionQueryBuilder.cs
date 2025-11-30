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

public class CombinedListingChildConnectionQueryBuilder() : GraphQueryBuilder<CombinedListingChildConnection>("query combinedListingChildConnection")
{
    public CombinedListingChildConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CombinedListingChildConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CombinedListingChildConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}