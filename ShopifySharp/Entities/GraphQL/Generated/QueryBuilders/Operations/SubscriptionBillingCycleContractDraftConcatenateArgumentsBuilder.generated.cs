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