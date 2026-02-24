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
    public sealed class SuggestedReturnRefundArgumentsBuilder : ArgumentsBuilderBase<SuggestedReturnRefund, SuggestedReturnRefundArgumentsBuilder>
    {
        protected override SuggestedReturnRefundArgumentsBuilder Self => this;

        public SuggestedReturnRefundArgumentsBuilder(IQuery<SuggestedReturnRefund> query) : base(query)
        {
        }

        public SuggestedReturnRefundArgumentsBuilder RefundDuties(ICollection<RefundDutyInput>? refundDuties)
        {
            base.InnerQuery.AddArgument("refundDuties", refundDuties);
            return this;
        }

        public SuggestedReturnRefundArgumentsBuilder RefundShipping(RefundShippingInput? refundShipping)
        {
            base.InnerQuery.AddArgument("refundShipping", refundShipping);
            return this;
        }

        public SuggestedReturnRefundArgumentsBuilder ReturnRefundLineItems(ICollection<ReturnRefundLineItemInput>? returnRefundLineItems)
        {
            base.InnerQuery.AddArgument("returnRefundLineItems", returnRefundLineItems);
            return this;
        }
    }
}