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
    public sealed class SuggestedReturnFinancialOutcomeArgumentsBuilder : ArgumentsBuilderBase<SuggestedReturnFinancialOutcome, SuggestedReturnFinancialOutcomeArgumentsBuilder>
    {
        protected override SuggestedReturnFinancialOutcomeArgumentsBuilder Self => this;

        public SuggestedReturnFinancialOutcomeArgumentsBuilder(IQuery<SuggestedReturnFinancialOutcome> query) : base(query)
        {
        }

        public SuggestedReturnFinancialOutcomeArgumentsBuilder ExchangeLineItems(ICollection<SuggestedOutcomeExchangeLineItemInput>? exchangeLineItems)
        {
            base.InnerQuery.AddArgument("exchangeLineItems", exchangeLineItems);
            return this;
        }

        public SuggestedReturnFinancialOutcomeArgumentsBuilder RefundDuties(ICollection<RefundDutyInput>? refundDuties)
        {
            base.InnerQuery.AddArgument("refundDuties", refundDuties);
            return this;
        }

        public SuggestedReturnFinancialOutcomeArgumentsBuilder RefundMethodAllocation(RefundMethodAllocation? refundMethodAllocation)
        {
            base.InnerQuery.AddArgument("refundMethodAllocation", refundMethodAllocation);
            return this;
        }

        public SuggestedReturnFinancialOutcomeArgumentsBuilder RefundShipping(RefundShippingInput? refundShipping)
        {
            base.InnerQuery.AddArgument("refundShipping", refundShipping);
            return this;
        }

        public SuggestedReturnFinancialOutcomeArgumentsBuilder ReturnLineItems(ICollection<SuggestedOutcomeReturnLineItemInput>? returnLineItems)
        {
            base.InnerQuery.AddArgument("returnLineItems", returnLineItems);
            return this;
        }

        public SuggestedReturnFinancialOutcomeArgumentsBuilder TipLineId(string? tipLineId)
        {
            base.InnerQuery.AddArgument("tipLineId", tipLineId);
            return this;
        }
    }
}