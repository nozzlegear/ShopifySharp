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

public class DeliveryMethodDefinitionConnectionQueryBuilder() : GraphQueryBuilder<DeliveryMethodDefinitionConnection>("query deliveryMethodDefinitionConnection")
{
    public DeliveryMethodDefinitionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DeliveryMethodDefinitionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DeliveryMethodDefinitionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}