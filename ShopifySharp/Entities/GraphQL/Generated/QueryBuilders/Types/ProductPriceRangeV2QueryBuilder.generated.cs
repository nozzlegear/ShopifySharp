#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ProductPriceRangeV2QueryBuilder : FieldsQueryBuilderBase<ProductPriceRangeV2, ProductPriceRangeV2QueryBuilder>
    {
        protected override ProductPriceRangeV2QueryBuilder Self => this;

        public ProductPriceRangeV2QueryBuilder() : this("productPriceRangeV2")
        {
        }

        public ProductPriceRangeV2QueryBuilder(string name) : base(new Query<ProductPriceRangeV2>(name))
        {
        }

        public ProductPriceRangeV2QueryBuilder(IQuery<ProductPriceRangeV2> query) : base(query)
        {
        }

        public ProductPriceRangeV2QueryBuilder MaxVariantPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("maxVariantPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ProductPriceRangeV2QueryBuilder MinVariantPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("minVariantPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}