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
    public sealed class MetafieldReferenceSuggestedRefundArgumentsBuilder : ArgumentsBuilderBase<SuggestedRefund?, MetafieldReferenceSuggestedRefundArgumentsBuilder>
    {
        protected override MetafieldReferenceSuggestedRefundArgumentsBuilder Self => this;

        public MetafieldReferenceSuggestedRefundArgumentsBuilder(IQuery<SuggestedRefund?> query) : base(query)
        {
        }

        public MetafieldReferenceSuggestedRefundArgumentsBuilder RefundDuties(ICollection<RefundDutyInput>? refundDuties)
        {
            base.InnerQuery.AddArgument("refundDuties", refundDuties);
            return this;
        }

        public MetafieldReferenceSuggestedRefundArgumentsBuilder RefundLineItems(ICollection<RefundLineItemInput>? refundLineItems)
        {
            base.InnerQuery.AddArgument("refundLineItems", refundLineItems);
            return this;
        }

        public MetafieldReferenceSuggestedRefundArgumentsBuilder RefundMethodAllocation(RefundMethodAllocation? refundMethodAllocation)
        {
            base.InnerQuery.AddArgument("refundMethodAllocation", refundMethodAllocation);
            return this;
        }

        public MetafieldReferenceSuggestedRefundArgumentsBuilder RefundShipping(bool? refundShipping)
        {
            base.InnerQuery.AddArgument("refundShipping", refundShipping);
            return this;
        }

        public MetafieldReferenceSuggestedRefundArgumentsBuilder ShippingAmount(decimal? shippingAmount)
        {
            base.InnerQuery.AddArgument("shippingAmount", shippingAmount);
            return this;
        }

        public MetafieldReferenceSuggestedRefundArgumentsBuilder SuggestFullRefund(bool? suggestFullRefund)
        {
            base.InnerQuery.AddArgument("suggestFullRefund", suggestFullRefund);
            return this;
        }
    }
}