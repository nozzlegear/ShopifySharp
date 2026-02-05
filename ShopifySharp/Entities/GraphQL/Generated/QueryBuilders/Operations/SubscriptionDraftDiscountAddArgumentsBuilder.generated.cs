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
    public sealed class SubscriptionDraftDiscountAddArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftDiscountAddPayload, SubscriptionDraftDiscountAddArgumentsBuilder>
    {
        protected override SubscriptionDraftDiscountAddArgumentsBuilder Self => this;

        public SubscriptionDraftDiscountAddArgumentsBuilder(IQuery<SubscriptionDraftDiscountAddPayload> query) : base(query)
        {
        }

        public SubscriptionDraftDiscountAddArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftDiscountAddArgumentsBuilder Input(SubscriptionManualDiscountInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}