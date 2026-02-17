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