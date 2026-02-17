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
    public sealed class ProductPriceRangeQueryBuilder : FieldsQueryBuilderBase<ProductPriceRange, ProductPriceRangeQueryBuilder>
    {
        protected override ProductPriceRangeQueryBuilder Self => this;

        public ProductPriceRangeQueryBuilder() : this("productPriceRange")
        {
        }

        public ProductPriceRangeQueryBuilder(string name) : base(new Query<ProductPriceRange>(name))
        {
        }

        public ProductPriceRangeQueryBuilder(IQuery<ProductPriceRange> query) : base(query)
        {
        }

        public ProductPriceRangeQueryBuilder MaxVariantPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("maxVariantPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ProductPriceRangeQueryBuilder MinVariantPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("minVariantPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}