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

public class AbandonedCheckoutLineItemConnectionQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutLineItemConnection>("query abandonedCheckoutLineItemConnection")
{
    public AbandonedCheckoutLineItemConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public AbandonedCheckoutLineItemConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public AbandonedCheckoutLineItemConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}