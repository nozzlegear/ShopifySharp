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

public class DraftOrderConnectionQueryBuilder() : GraphQueryBuilder<DraftOrderConnection>("query draftOrderConnection")
{
    public DraftOrderConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DraftOrderConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DraftOrderConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}