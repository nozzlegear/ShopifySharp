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

public class FulfillmentConstraintRuleQueryBuilder() : GraphQueryBuilder<FulfillmentConstraintRule>("query fulfillmentConstraintRule")
{
    public FulfillmentConstraintRuleQueryBuilder AddFieldDeliveryMethodTypes()
    {
        AddField("deliveryMethodTypes");
        return this;
    }

    public FulfillmentConstraintRuleQueryBuilder AddFieldFunction()
    {
        AddField("function");
        return this;
    }

    public FulfillmentConstraintRuleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentConstraintRuleQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    public FulfillmentConstraintRuleQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }
}