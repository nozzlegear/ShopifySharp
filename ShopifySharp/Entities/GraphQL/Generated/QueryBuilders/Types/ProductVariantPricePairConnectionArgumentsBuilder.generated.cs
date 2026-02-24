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
    public sealed class ProductVariantPricePairConnectionArgumentsBuilder : ArgumentsBuilderBase<ProductVariantPricePairConnection, ProductVariantPricePairConnectionArgumentsBuilder>
    {
        protected override ProductVariantPricePairConnectionArgumentsBuilder Self => this;

        public ProductVariantPricePairConnectionArgumentsBuilder(IQuery<ProductVariantPricePairConnection> query) : base(query)
        {
        }

        public ProductVariantPricePairConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ProductVariantPricePairConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ProductVariantPricePairConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ProductVariantPricePairConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ProductVariantPricePairConnectionArgumentsBuilder PresentmentCurrencies(ICollection<CurrencyCode>? presentmentCurrencies)
        {
            base.InnerQuery.AddArgument("presentmentCurrencies", presentmentCurrencies);
            return this;
        }

        public ProductVariantPricePairConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}