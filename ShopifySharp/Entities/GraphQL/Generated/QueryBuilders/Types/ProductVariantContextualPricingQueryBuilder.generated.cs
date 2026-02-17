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
    public sealed class ProductVariantContextualPricingQueryBuilder : FieldsQueryBuilderBase<ProductVariantContextualPricing, ProductVariantContextualPricingQueryBuilder>
    {
        protected override ProductVariantContextualPricingQueryBuilder Self => this;

        public ProductVariantContextualPricingQueryBuilder() : this("productVariantContextualPricing")
        {
        }

        public ProductVariantContextualPricingQueryBuilder(string name) : base(new Query<ProductVariantContextualPricing>(name))
        {
        }

        public ProductVariantContextualPricingQueryBuilder(IQuery<ProductVariantContextualPricing> query) : base(query)
        {
        }

        public ProductVariantContextualPricingQueryBuilder CompareAtPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("compareAtPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ProductVariantContextualPricingQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ProductVariantContextualPricingQueryBuilder QuantityPriceBreaks(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakConnectionQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreakConnection>("quantityPriceBreaks");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreakConnection>(query);
            return this;
        }

        public ProductVariantContextualPricingQueryBuilder QuantityRule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder> build)
        {
            var query = new Query<QuantityRule>("quantityRule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRule>(query);
            return this;
        }

        public ProductVariantContextualPricingQueryBuilder UnitPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}