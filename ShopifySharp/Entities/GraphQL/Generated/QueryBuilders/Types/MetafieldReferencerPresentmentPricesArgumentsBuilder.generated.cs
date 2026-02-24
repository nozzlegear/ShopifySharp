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
    public sealed class MetafieldReferencerPresentmentPricesArgumentsBuilder : ArgumentsBuilderBase<ProductVariantPricePairConnection?, MetafieldReferencerPresentmentPricesArgumentsBuilder>
    {
        protected override MetafieldReferencerPresentmentPricesArgumentsBuilder Self => this;

        public MetafieldReferencerPresentmentPricesArgumentsBuilder(IQuery<ProductVariantPricePairConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerPresentmentPricesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerPresentmentPricesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerPresentmentPricesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerPresentmentPricesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerPresentmentPricesArgumentsBuilder PresentmentCurrencies(ICollection<CurrencyCode>? presentmentCurrencies)
        {
            base.InnerQuery.AddArgument("presentmentCurrencies", presentmentCurrencies);
            return this;
        }

        public MetafieldReferencerPresentmentPricesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}