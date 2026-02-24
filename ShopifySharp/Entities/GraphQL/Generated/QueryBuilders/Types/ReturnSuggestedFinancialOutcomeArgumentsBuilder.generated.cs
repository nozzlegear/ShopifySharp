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
    public sealed class ReturnSuggestedFinancialOutcomeArgumentsBuilder : ArgumentsBuilderBase<SuggestedReturnFinancialOutcome?, ReturnSuggestedFinancialOutcomeArgumentsBuilder>
    {
        protected override ReturnSuggestedFinancialOutcomeArgumentsBuilder Self => this;

        public ReturnSuggestedFinancialOutcomeArgumentsBuilder(IQuery<SuggestedReturnFinancialOutcome?> query) : base(query)
        {
        }

        public ReturnSuggestedFinancialOutcomeArgumentsBuilder ExchangeLineItems(ICollection<SuggestedOutcomeExchangeLineItemInput>? exchangeLineItems)
        {
            base.InnerQuery.AddArgument("exchangeLineItems", exchangeLineItems);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeArgumentsBuilder RefundDuties(ICollection<RefundDutyInput>? refundDuties)
        {
            base.InnerQuery.AddArgument("refundDuties", refundDuties);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeArgumentsBuilder RefundMethodAllocation(RefundMethodAllocation? refundMethodAllocation)
        {
            base.InnerQuery.AddArgument("refundMethodAllocation", refundMethodAllocation);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeArgumentsBuilder RefundShipping(RefundShippingInput? refundShipping)
        {
            base.InnerQuery.AddArgument("refundShipping", refundShipping);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeArgumentsBuilder ReturnLineItems(ICollection<SuggestedOutcomeReturnLineItemInput>? returnLineItems)
        {
            base.InnerQuery.AddArgument("returnLineItems", returnLineItems);
            return this;
        }
    }
}