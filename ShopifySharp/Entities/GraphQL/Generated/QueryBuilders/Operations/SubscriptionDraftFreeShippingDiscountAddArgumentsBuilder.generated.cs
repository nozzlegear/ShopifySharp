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
    public sealed class SubscriptionDraftFreeShippingDiscountAddArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftFreeShippingDiscountAddPayload, SubscriptionDraftFreeShippingDiscountAddArgumentsBuilder>
    {
        protected override SubscriptionDraftFreeShippingDiscountAddArgumentsBuilder Self => this;

        public SubscriptionDraftFreeShippingDiscountAddArgumentsBuilder(IQuery<SubscriptionDraftFreeShippingDiscountAddPayload> query) : base(query)
        {
        }

        public SubscriptionDraftFreeShippingDiscountAddArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftFreeShippingDiscountAddArgumentsBuilder Input(SubscriptionFreeShippingDiscountInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}