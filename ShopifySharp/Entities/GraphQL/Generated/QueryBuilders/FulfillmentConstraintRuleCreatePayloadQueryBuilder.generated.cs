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

public class FulfillmentConstraintRuleCreatePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentConstraintRuleCreatePayload>("fulfillmentConstraintRuleCreatePayload")
{
    public FulfillmentConstraintRuleCreatePayloadQueryBuilder AddFieldFulfillmentConstraintRule(Func<FulfillmentConstraintRuleQueryBuilder, FulfillmentConstraintRuleQueryBuilder> build)
    {
        AddField<FulfillmentConstraintRule, FulfillmentConstraintRuleQueryBuilder>("fulfillmentConstraintRule", build);
        return this;
    }

    public FulfillmentConstraintRuleCreatePayloadQueryBuilder AddFieldUserErrors(Func<FulfillmentConstraintRuleCreateUserErrorQueryBuilder, FulfillmentConstraintRuleCreateUserErrorQueryBuilder> build)
    {
        AddField<FulfillmentConstraintRuleCreateUserError, FulfillmentConstraintRuleCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}