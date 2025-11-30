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

public class QuantityRulesAddQueryBuilder() : GraphQueryBuilder<QuantityRulesAddPayload>("quantityRulesAdd"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public QuantityRulesAddQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }

    public QuantityRulesAddQueryBuilder AddArgumentQuantityRules(ICollection<QuantityRuleInput>? quantityRules)
    {
        AddArgument("quantityRules", quantityRules);
        return this;
    }
}