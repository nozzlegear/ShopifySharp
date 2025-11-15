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

public class MetafieldReferenceConnectionQueryBuilder() : GraphQueryBuilder<MetafieldReferenceConnection>("query metafieldReferenceConnection")
{
    public MetafieldReferenceConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}