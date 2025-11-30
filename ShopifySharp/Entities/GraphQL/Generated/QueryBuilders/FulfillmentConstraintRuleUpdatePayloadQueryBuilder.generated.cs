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

public class FulfillmentConstraintRuleUpdatePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentConstraintRuleUpdatePayload>("fulfillmentConstraintRuleUpdatePayload")
{
    public FulfillmentConstraintRuleUpdatePayloadQueryBuilder AddFieldFulfillmentConstraintRule(Func<FulfillmentConstraintRuleQueryBuilder, FulfillmentConstraintRuleQueryBuilder> build)
    {
        AddField<FulfillmentConstraintRule, FulfillmentConstraintRuleQueryBuilder>("fulfillmentConstraintRule", build);
        return this;
    }

    public FulfillmentConstraintRuleUpdatePayloadQueryBuilder AddFieldUserErrors(Func<FulfillmentConstraintRuleUpdateUserErrorQueryBuilder, FulfillmentConstraintRuleUpdateUserErrorQueryBuilder> build)
    {
        AddField<FulfillmentConstraintRuleUpdateUserError, FulfillmentConstraintRuleUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}