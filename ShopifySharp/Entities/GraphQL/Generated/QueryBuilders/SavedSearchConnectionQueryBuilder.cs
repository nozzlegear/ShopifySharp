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

public class SavedSearchConnectionQueryBuilder() : GraphQueryBuilder<SavedSearchConnection>("query savedSearchConnection")
{
    public SavedSearchConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SavedSearchConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SavedSearchConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}