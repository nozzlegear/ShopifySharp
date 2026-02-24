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
    public sealed class QueryRootSubscriptionBillingCycleArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycle?, QueryRootSubscriptionBillingCycleArgumentsBuilder>
    {
        protected override QueryRootSubscriptionBillingCycleArgumentsBuilder Self => this;

        public QueryRootSubscriptionBillingCycleArgumentsBuilder(IQuery<SubscriptionBillingCycle?> query) : base(query)
        {
        }

        public QueryRootSubscriptionBillingCycleArgumentsBuilder BillingCycleInput(SubscriptionBillingCycleInput? billingCycleInput)
        {
            base.InnerQuery.AddArgument("billingCycleInput", billingCycleInput);
            return this;
        }
    }
}