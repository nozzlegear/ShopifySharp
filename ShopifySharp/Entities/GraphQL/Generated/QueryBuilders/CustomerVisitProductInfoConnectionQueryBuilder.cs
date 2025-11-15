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

public class CustomerVisitProductInfoConnectionQueryBuilder() : GraphQueryBuilder<CustomerVisitProductInfoConnection>("query customerVisitProductInfoConnection")
{
    public CustomerVisitProductInfoConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CustomerVisitProductInfoConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CustomerVisitProductInfoConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}