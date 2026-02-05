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
    public sealed class SubscriptionDraftDiscountCodeApplyArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftDiscountCodeApplyPayload, SubscriptionDraftDiscountCodeApplyArgumentsBuilder>
    {
        protected override SubscriptionDraftDiscountCodeApplyArgumentsBuilder Self => this;

        public SubscriptionDraftDiscountCodeApplyArgumentsBuilder(IQuery<SubscriptionDraftDiscountCodeApplyPayload> query) : base(query)
        {
        }

        public SubscriptionDraftDiscountCodeApplyArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftDiscountCodeApplyArgumentsBuilder RedeemCode(string? redeemCode)
        {
            base.InnerQuery.AddArgument("redeemCode", redeemCode);
            return this;
        }
    }
}