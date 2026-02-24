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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class SuggestedRefundArgumentsBuilder : ArgumentsBuilderBase<SuggestedRefund, SuggestedRefundArgumentsBuilder>
    {
        protected override SuggestedRefundArgumentsBuilder Self => this;

        public SuggestedRefundArgumentsBuilder(IQuery<SuggestedRefund> query) : base(query)
        {
        }

        public SuggestedRefundArgumentsBuilder RefundDuties(ICollection<RefundDutyInput>? refundDuties)
        {
            base.InnerQuery.AddArgument("refundDuties", refundDuties);
            return this;
        }

        public SuggestedRefundArgumentsBuilder RefundLineItems(ICollection<RefundLineItemInput>? refundLineItems)
        {
            base.InnerQuery.AddArgument("refundLineItems", refundLineItems);
            return this;
        }

        public SuggestedRefundArgumentsBuilder RefundMethodAllocation(RefundMethodAllocation? refundMethodAllocation)
        {
            base.InnerQuery.AddArgument("refundMethodAllocation", refundMethodAllocation);
            return this;
        }

        public SuggestedRefundArgumentsBuilder RefundShipping(bool? refundShipping)
        {
            base.InnerQuery.AddArgument("refundShipping", refundShipping);
            return this;
        }

        public SuggestedRefundArgumentsBuilder ShippingAmount(decimal? shippingAmount)
        {
            base.InnerQuery.AddArgument("shippingAmount", shippingAmount);
            return this;
        }

        public SuggestedRefundArgumentsBuilder SuggestFullRefund(bool? suggestFullRefund)
        {
            base.InnerQuery.AddArgument("suggestFullRefund", suggestFullRefund);
            return this;
        }
    }
}