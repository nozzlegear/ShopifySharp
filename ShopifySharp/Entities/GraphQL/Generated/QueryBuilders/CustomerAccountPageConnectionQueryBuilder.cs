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

public class CustomerAccountPageConnectionQueryBuilder() : GraphQueryBuilder<CustomerAccountPageConnection>("query customerAccountPageConnection")
{
    public CustomerAccountPageConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CustomerAccountPageConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CustomerAccountPageConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}