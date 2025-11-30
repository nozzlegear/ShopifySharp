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

public class FulfillmentOrderLineItemWarningQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLineItemWarning>("query fulfillmentOrderLineItemWarning")
{
    public FulfillmentOrderLineItemWarningQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public FulfillmentOrderLineItemWarningQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}