#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class QuantityRulesAddArgumentsBuilder : ArgumentsBuilderBase<QuantityRulesAddPayload, QuantityRulesAddArgumentsBuilder>
    {
        protected override QuantityRulesAddArgumentsBuilder Self => this;

        public QuantityRulesAddArgumentsBuilder(IQuery<QuantityRulesAddPayload> query) : base(query)
        {
        }

        public QuantityRulesAddArgumentsBuilder PriceListId(string? priceListId)
        {
            base.InnerQuery.AddArgument("priceListId", priceListId);
            return this;
        }

        public QuantityRulesAddArgumentsBuilder QuantityRules(ICollection<QuantityRuleInput>? quantityRules)
        {
            base.InnerQuery.AddArgument("quantityRules", quantityRules);
            return this;
        }
    }
}