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

public class MetafieldRelationConnectionQueryBuilder() : GraphQueryBuilder<MetafieldRelationConnection>("query metafieldRelationConnection")
{
    public MetafieldRelationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MetafieldRelationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MetafieldRelationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}