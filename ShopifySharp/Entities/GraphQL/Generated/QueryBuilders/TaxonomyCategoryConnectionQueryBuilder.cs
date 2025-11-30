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

public class TaxonomyCategoryConnectionQueryBuilder() : GraphQueryBuilder<TaxonomyCategoryConnection>("query taxonomyCategoryConnection")
{
    public TaxonomyCategoryConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public TaxonomyCategoryConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public TaxonomyCategoryConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}