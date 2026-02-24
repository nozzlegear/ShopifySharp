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
    public sealed class ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder : ArgumentsBuilderBase<QuantityPriceBreakConnection?, ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder>
    {
        protected override ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder Self => this;

        public ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder(IQuery<QuantityPriceBreakConnection?> query) : base(query)
        {
        }

        public ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ProductVariantContextualPricingQuantityPriceBreaksArgumentsBuilder SortKey(QuantityPriceBreakSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}