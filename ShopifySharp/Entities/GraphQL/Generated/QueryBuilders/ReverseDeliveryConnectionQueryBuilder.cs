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

public class ReverseDeliveryConnectionQueryBuilder() : GraphQueryBuilder<ReverseDeliveryConnection>("query reverseDeliveryConnection")
{
    public ReverseDeliveryConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ReverseDeliveryConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ReverseDeliveryConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}