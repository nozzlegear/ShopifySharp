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

public class FulfillmentOrdersSetFulfillmentDeadlineQueryBuilder() : GraphQueryBuilder<FulfillmentOrdersSetFulfillmentDeadlinePayload>("query fulfillmentOrdersSetFulfillmentDeadline")
{
    public FulfillmentOrdersSetFulfillmentDeadlineQueryBuilder AddArgumentFulfillmentDeadline(DateTime? fulfillmentDeadline)
    {
        AddArgument("fulfillmentDeadline", fulfillmentDeadline);
        return this;
    }

    public FulfillmentOrdersSetFulfillmentDeadlineQueryBuilder AddArgumentFulfillmentOrderIds(ICollection<string>? fulfillmentOrderIds)
    {
        AddArgument("fulfillmentOrderIds", fulfillmentOrderIds);
        return this;
    }
}