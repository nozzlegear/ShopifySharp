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

public class SaleConnectionQueryBuilder() : GraphQueryBuilder<SaleConnection>("query saleConnection")
{
    public SaleConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SaleConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SaleConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}