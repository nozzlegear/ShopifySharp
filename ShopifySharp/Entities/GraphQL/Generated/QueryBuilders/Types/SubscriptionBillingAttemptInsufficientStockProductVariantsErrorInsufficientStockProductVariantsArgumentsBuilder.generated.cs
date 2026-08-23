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
    public sealed class SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder>
    {
        protected override SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder Self => this;

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorInsufficientStockProductVariantsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}