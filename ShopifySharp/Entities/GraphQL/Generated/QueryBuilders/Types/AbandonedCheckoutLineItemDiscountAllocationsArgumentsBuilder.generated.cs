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
    public sealed class AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder : ArgumentsBuilderBase<DiscountAllocationConnection?, AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder>
    {
        protected override AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder Self => this;

        public AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder(IQuery<DiscountAllocationConnection?> query) : base(query)
        {
        }

        public AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AbandonedCheckoutLineItemDiscountAllocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}