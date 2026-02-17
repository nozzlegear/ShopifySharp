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
    public sealed class SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleContractDraftConcatenatePayload, SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder Self => this;

        public SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder(IQuery<SubscriptionBillingCycleContractDraftConcatenatePayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder ConcatenatedBillingCycleContracts(ICollection<SubscriptionBillingCycleInput>? concatenatedBillingCycleContracts)
        {
            base.InnerQuery.AddArgument("concatenatedBillingCycleContracts", concatenatedBillingCycleContracts);
            return this;
        }

        public SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }
    }
}