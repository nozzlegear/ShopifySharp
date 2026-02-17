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
    public sealed class SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftFreeShippingDiscountUpdatePayload, SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder>
    {
        protected override SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder Self => this;

        public SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder(IQuery<SubscriptionDraftFreeShippingDiscountUpdatePayload> query) : base(query)
        {
        }

        public SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder DiscountId(string? discountId)
        {
            base.InnerQuery.AddArgument("discountId", discountId);
            return this;
        }

        public SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder Input(SubscriptionFreeShippingDiscountInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}