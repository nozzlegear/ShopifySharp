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

public class AppDiscountTypeConnectionQueryBuilder() : GraphQueryBuilder<AppDiscountTypeConnection>("query appDiscountTypeConnection")
{
    public AppDiscountTypeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public AppDiscountTypeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public AppDiscountTypeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}