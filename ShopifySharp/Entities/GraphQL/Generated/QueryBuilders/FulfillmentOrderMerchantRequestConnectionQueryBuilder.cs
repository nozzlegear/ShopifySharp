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

public class FulfillmentOrderMerchantRequestConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentOrderMerchantRequestConnection>("query fulfillmentOrderMerchantRequestConnection")
{
    public FulfillmentOrderMerchantRequestConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public FulfillmentOrderMerchantRequestConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public FulfillmentOrderMerchantRequestConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}