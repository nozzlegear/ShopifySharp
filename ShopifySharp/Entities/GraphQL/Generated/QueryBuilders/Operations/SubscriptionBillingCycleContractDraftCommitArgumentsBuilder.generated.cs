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
    public sealed class SubscriptionBillingCycleContractDraftCommitArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleContractDraftCommitPayload, SubscriptionBillingCycleContractDraftCommitArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleContractDraftCommitArgumentsBuilder Self => this;

        public SubscriptionBillingCycleContractDraftCommitArgumentsBuilder(IQuery<SubscriptionBillingCycleContractDraftCommitPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleContractDraftCommitArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }
    }
}