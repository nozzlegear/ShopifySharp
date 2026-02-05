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
    public sealed class SubscriptionContractSetNextBillingDateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractSetNextBillingDatePayload, SubscriptionContractSetNextBillingDateArgumentsBuilder>
    {
        protected override SubscriptionContractSetNextBillingDateArgumentsBuilder Self => this;

        public SubscriptionContractSetNextBillingDateArgumentsBuilder(IQuery<SubscriptionContractSetNextBillingDatePayload> query) : base(query)
        {
        }

        public SubscriptionContractSetNextBillingDateArgumentsBuilder ContractId(string? contractId)
        {
            base.InnerQuery.AddArgument("contractId", contractId);
            return this;
        }

        public SubscriptionContractSetNextBillingDateArgumentsBuilder Date(DateTimeOffset? date)
        {
            base.InnerQuery.AddArgument("date", date);
            return this;
        }
    }
}