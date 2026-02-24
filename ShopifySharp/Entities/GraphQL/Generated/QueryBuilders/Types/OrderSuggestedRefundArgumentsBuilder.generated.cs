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
    public sealed class OrderSuggestedRefundArgumentsBuilder : ArgumentsBuilderBase<SuggestedRefund?, OrderSuggestedRefundArgumentsBuilder>
    {
        protected override OrderSuggestedRefundArgumentsBuilder Self => this;

        public OrderSuggestedRefundArgumentsBuilder(IQuery<SuggestedRefund?> query) : base(query)
        {
        }

        public OrderSuggestedRefundArgumentsBuilder RefundDuties(ICollection<RefundDutyInput>? refundDuties)
        {
            base.InnerQuery.AddArgument("refundDuties", refundDuties);
            return this;
        }

        public OrderSuggestedRefundArgumentsBuilder RefundLineItems(ICollection<RefundLineItemInput>? refundLineItems)
        {
            base.InnerQuery.AddArgument("refundLineItems", refundLineItems);
            return this;
        }

        public OrderSuggestedRefundArgumentsBuilder RefundMethodAllocation(RefundMethodAllocation? refundMethodAllocation)
        {
            base.InnerQuery.AddArgument("refundMethodAllocation", refundMethodAllocation);
            return this;
        }

        public OrderSuggestedRefundArgumentsBuilder RefundShipping(bool? refundShipping)
        {
            base.InnerQuery.AddArgument("refundShipping", refundShipping);
            return this;
        }

        public OrderSuggestedRefundArgumentsBuilder ShippingAmount(decimal? shippingAmount)
        {
            base.InnerQuery.AddArgument("shippingAmount", shippingAmount);
            return this;
        }

        public OrderSuggestedRefundArgumentsBuilder SuggestFullRefund(bool? suggestFullRefund)
        {
            base.InnerQuery.AddArgument("suggestFullRefund", suggestFullRefund);
            return this;
        }
    }
}