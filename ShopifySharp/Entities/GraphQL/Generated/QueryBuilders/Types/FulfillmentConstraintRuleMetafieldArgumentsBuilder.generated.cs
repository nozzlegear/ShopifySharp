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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class FulfillmentConstraintRuleMetafieldArgumentsBuilder : ArgumentsBuilderBase<Metafield?, FulfillmentConstraintRuleMetafieldArgumentsBuilder>
    {
        protected override FulfillmentConstraintRuleMetafieldArgumentsBuilder Self => this;

        public FulfillmentConstraintRuleMetafieldArgumentsBuilder(IQuery<Metafield?> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleMetafieldArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public FulfillmentConstraintRuleMetafieldArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }
    }
}