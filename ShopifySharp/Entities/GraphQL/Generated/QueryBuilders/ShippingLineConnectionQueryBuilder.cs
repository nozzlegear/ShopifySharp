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

public class ShippingLineConnectionQueryBuilder() : GraphQueryBuilder<ShippingLineConnection>("query shippingLineConnection")
{
    public ShippingLineConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ShippingLineConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ShippingLineConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}