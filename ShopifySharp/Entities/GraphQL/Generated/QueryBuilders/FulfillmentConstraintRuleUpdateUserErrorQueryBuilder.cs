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

public class FulfillmentConstraintRuleUpdateUserErrorQueryBuilder() : GraphQueryBuilder<FulfillmentConstraintRuleUpdateUserError>("query fulfillmentConstraintRuleUpdateUserError")
{
    public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}