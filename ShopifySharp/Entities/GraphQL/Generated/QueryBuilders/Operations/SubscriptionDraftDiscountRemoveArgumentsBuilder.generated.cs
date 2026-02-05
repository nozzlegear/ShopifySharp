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
    public sealed class SubscriptionDraftDiscountRemoveArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftDiscountRemovePayload, SubscriptionDraftDiscountRemoveArgumentsBuilder>
    {
        protected override SubscriptionDraftDiscountRemoveArgumentsBuilder Self => this;

        public SubscriptionDraftDiscountRemoveArgumentsBuilder(IQuery<SubscriptionDraftDiscountRemovePayload> query) : base(query)
        {
        }

        public SubscriptionDraftDiscountRemoveArgumentsBuilder DiscountId(string? discountId)
        {
            base.InnerQuery.AddArgument("discountId", discountId);
            return this;
        }

        public SubscriptionDraftDiscountRemoveArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }
    }
}