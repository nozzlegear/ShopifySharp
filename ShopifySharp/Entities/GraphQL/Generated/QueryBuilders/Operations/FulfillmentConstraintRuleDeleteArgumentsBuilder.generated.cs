#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class FulfillmentConstraintRuleDeleteArgumentsBuilder : ArgumentsBuilderBase<FulfillmentConstraintRuleDeletePayload, FulfillmentConstraintRuleDeleteArgumentsBuilder>
    {
        protected override FulfillmentConstraintRuleDeleteArgumentsBuilder Self => this;

        public FulfillmentConstraintRuleDeleteArgumentsBuilder(IQuery<FulfillmentConstraintRuleDeletePayload> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}