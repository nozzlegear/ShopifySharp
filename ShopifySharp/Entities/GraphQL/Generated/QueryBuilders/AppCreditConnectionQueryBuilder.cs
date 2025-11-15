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

public class AppCreditConnectionQueryBuilder() : GraphQueryBuilder<AppCreditConnection>("query appCreditConnection")
{
    public AppCreditConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public AppCreditConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public AppCreditConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}