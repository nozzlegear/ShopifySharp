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
    public sealed class SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder>
    {
        protected override SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder Self => this;

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionBillingAttemptInventoryErrorInsufficientStockProductVariantsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}