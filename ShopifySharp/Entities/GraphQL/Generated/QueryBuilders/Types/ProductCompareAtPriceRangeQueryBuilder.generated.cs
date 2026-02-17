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
    public sealed class ProductCompareAtPriceRangeQueryBuilder : FieldsQueryBuilderBase<ProductCompareAtPriceRange, ProductCompareAtPriceRangeQueryBuilder>
    {
        protected override ProductCompareAtPriceRangeQueryBuilder Self => this;

        public ProductCompareAtPriceRangeQueryBuilder() : this("productCompareAtPriceRange")
        {
        }

        public ProductCompareAtPriceRangeQueryBuilder(string name) : base(new Query<ProductCompareAtPriceRange>(name))
        {
        }

        public ProductCompareAtPriceRangeQueryBuilder(IQuery<ProductCompareAtPriceRange> query) : base(query)
        {
        }

        public ProductCompareAtPriceRangeQueryBuilder MaxVariantCompareAtPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("maxVariantCompareAtPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ProductCompareAtPriceRangeQueryBuilder MinVariantCompareAtPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("minVariantCompareAtPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}