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

public class QuantityRulesDeletePayloadQueryBuilder() : GraphQueryBuilder<QuantityRulesDeletePayload>("quantityRulesDeletePayload")
{
    public QuantityRulesDeletePayloadQueryBuilder AddFieldDeletedQuantityRulesVariantIds()
    {
        AddField("deletedQuantityRulesVariantIds");
        return this;
    }

    public QuantityRulesDeletePayloadQueryBuilder AddFieldUserErrors(Func<QuantityRuleUserErrorQueryBuilder, QuantityRuleUserErrorQueryBuilder> build)
    {
        AddField<QuantityRuleUserError, QuantityRuleUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}