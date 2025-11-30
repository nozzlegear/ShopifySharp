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

public class FulfillmentConstraintRuleDeletePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentConstraintRuleDeletePayload>("query fulfillmentConstraintRuleDeletePayload")
{
    public FulfillmentConstraintRuleDeletePayloadQueryBuilder AddFieldSuccess()
    {
        AddField("success");
        return this;
    }

    public FulfillmentConstraintRuleDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}