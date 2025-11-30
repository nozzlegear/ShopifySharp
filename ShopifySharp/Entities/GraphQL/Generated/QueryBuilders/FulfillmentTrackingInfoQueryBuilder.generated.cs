#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class FulfillmentTrackingInfoQueryBuilder() : GraphQueryBuilder<FulfillmentTrackingInfo>("fulfillmentTrackingInfo")
{
    public FulfillmentTrackingInfoQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public FulfillmentTrackingInfoQueryBuilder AddFieldNumber()
    {
        AddField("number");
        return this;
    }

    public FulfillmentTrackingInfoQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}