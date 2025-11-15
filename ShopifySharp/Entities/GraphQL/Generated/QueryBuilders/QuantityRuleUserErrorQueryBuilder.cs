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

public class QuantityRuleUserErrorQueryBuilder() : GraphQueryBuilder<QuantityRuleUserError>("query quantityRuleUserError")
{
    public QuantityRuleUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public QuantityRuleUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public QuantityRuleUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}