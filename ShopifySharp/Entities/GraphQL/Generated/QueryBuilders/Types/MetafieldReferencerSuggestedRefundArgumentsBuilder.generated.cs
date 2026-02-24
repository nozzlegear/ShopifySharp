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
    public sealed class MetafieldReferencerSuggestedRefundArgumentsBuilder : ArgumentsBuilderBase<SuggestedRefund?, MetafieldReferencerSuggestedRefundArgumentsBuilder>
    {
        protected override MetafieldReferencerSuggestedRefundArgumentsBuilder Self => this;

        public MetafieldReferencerSuggestedRefundArgumentsBuilder(IQuery<SuggestedRefund?> query) : base(query)
        {
        }

        public MetafieldReferencerSuggestedRefundArgumentsBuilder RefundDuties(ICollection<RefundDutyInput>? refundDuties)
        {
            base.InnerQuery.AddArgument("refundDuties", refundDuties);
            return this;
        }

        public MetafieldReferencerSuggestedRefundArgumentsBuilder RefundLineItems(ICollection<RefundLineItemInput>? refundLineItems)
        {
            base.InnerQuery.AddArgument("refundLineItems", refundLineItems);
            return this;
        }

        public MetafieldReferencerSuggestedRefundArgumentsBuilder RefundMethodAllocation(RefundMethodAllocation? refundMethodAllocation)
        {
            base.InnerQuery.AddArgument("refundMethodAllocation", refundMethodAllocation);
            return this;
        }

        public MetafieldReferencerSuggestedRefundArgumentsBuilder RefundShipping(bool? refundShipping)
        {
            base.InnerQuery.AddArgument("refundShipping", refundShipping);
            return this;
        }

        public MetafieldReferencerSuggestedRefundArgumentsBuilder ShippingAmount(decimal? shippingAmount)
        {
            base.InnerQuery.AddArgument("shippingAmount", shippingAmount);
            return this;
        }

        public MetafieldReferencerSuggestedRefundArgumentsBuilder SuggestFullRefund(bool? suggestFullRefund)
        {
            base.InnerQuery.AddArgument("suggestFullRefund", suggestFullRefund);
            return this;
        }
    }
}