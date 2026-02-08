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
    public sealed class SubscriptionDraftDiscountUpdateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftDiscountUpdatePayload, SubscriptionDraftDiscountUpdateArgumentsBuilder>
    {
        protected override SubscriptionDraftDiscountUpdateArgumentsBuilder Self => this;

        public SubscriptionDraftDiscountUpdateArgumentsBuilder(IQuery<SubscriptionDraftDiscountUpdatePayload> query) : base(query)
        {
        }

        public SubscriptionDraftDiscountUpdateArgumentsBuilder DiscountId(string? discountId)
        {
            base.InnerQuery.AddArgument("discountId", discountId);
            return this;
        }

        public SubscriptionDraftDiscountUpdateArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftDiscountUpdateArgumentsBuilder Input(SubscriptionManualDiscountInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}