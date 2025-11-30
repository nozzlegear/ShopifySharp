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

public class FulfillmentConstraintRuleQueryBuilder() : GraphQueryBuilder<FulfillmentConstraintRule>("fulfillmentConstraintRule")
{
    public FulfillmentConstraintRuleQueryBuilder AddFieldDeliveryMethodTypes()
    {
        AddField("deliveryMethodTypes");
        return this;
    }

    public FulfillmentConstraintRuleQueryBuilder AddFieldFunction(Func<ShopifyFunctionQueryBuilder, ShopifyFunctionQueryBuilder> build)
    {
        AddField<ShopifyFunction, ShopifyFunctionQueryBuilder>("function", build);
        return this;
    }

    public FulfillmentConstraintRuleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentConstraintRuleQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public FulfillmentConstraintRuleQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }
}