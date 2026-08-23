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
    public sealed class SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder>
    {
        protected override SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder Self => this;

        public SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionBillingAttemptErrorInsufficientStockProductVariantsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}