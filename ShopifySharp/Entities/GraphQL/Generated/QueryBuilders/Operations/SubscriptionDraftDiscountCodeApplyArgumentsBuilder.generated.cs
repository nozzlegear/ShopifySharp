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