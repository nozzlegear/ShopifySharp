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
    public sealed class ProductContextualPricingQueryBuilder : FieldsQueryBuilderBase<ProductContextualPricing, ProductContextualPricingQueryBuilder>
    {
        protected override ProductContextualPricingQueryBuilder Self => this;

        public ProductContextualPricingQueryBuilder() : this("productContextualPricing")
        {
        }

        public ProductContextualPricingQueryBuilder(string name) : base(new Query<ProductContextualPricing>(name))
        {
        }

        public ProductContextualPricingQueryBuilder(IQuery<ProductContextualPricing> query) : base(query)
        {
        }

        public ProductContextualPricingQueryBuilder FixedQuantityRulesCount()
        {
            base.InnerQuery.AddField("fixedQuantityRulesCount");
            return this;
        }

        public ProductContextualPricingQueryBuilder MaxVariantPricing(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductVariantContextualPricing>("maxVariantPricing");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantContextualPricing>(query);
            return this;
        }

        public ProductContextualPricingQueryBuilder MinVariantPricing(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductVariantContextualPricing>("minVariantPricing");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantContextualPricing>(query);
            return this;
        }

        public ProductContextualPricingQueryBuilder PriceRange(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeV2QueryBuilder> build)
        {
            var query = new Query<ProductPriceRangeV2>("priceRange");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPriceRangeV2>(query);
            return this;
        }
    }
}