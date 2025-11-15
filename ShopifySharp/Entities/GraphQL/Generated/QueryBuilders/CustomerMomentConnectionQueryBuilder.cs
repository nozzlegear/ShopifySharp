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

public class CustomerMomentConnectionQueryBuilder() : GraphQueryBuilder<CustomerMomentConnection>("query customerMomentConnection")
{
    public CustomerMomentConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CustomerMomentConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CustomerMomentConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}