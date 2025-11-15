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

public class CustomerConnectionQueryBuilder() : GraphQueryBuilder<CustomerConnection>("query customerConnection")
{
    public CustomerConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CustomerConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CustomerConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}