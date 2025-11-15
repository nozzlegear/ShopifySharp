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

public class TaxonomyCategoryAttributeConnectionQueryBuilder() : GraphQueryBuilder<TaxonomyCategoryAttributeConnection>("query taxonomyCategoryAttributeConnection")
{
    public TaxonomyCategoryAttributeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public TaxonomyCategoryAttributeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public TaxonomyCategoryAttributeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}