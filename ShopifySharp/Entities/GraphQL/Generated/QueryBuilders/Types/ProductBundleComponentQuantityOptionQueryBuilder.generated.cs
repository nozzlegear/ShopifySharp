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
    public sealed class ProductBundleComponentQuantityOptionQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponentQuantityOption, ProductBundleComponentQuantityOptionQueryBuilder>
    {
        protected override ProductBundleComponentQuantityOptionQueryBuilder Self => this;

        public ProductBundleComponentQuantityOptionQueryBuilder() : this("productBundleComponentQuantityOption")
        {
        }

        public ProductBundleComponentQuantityOptionQueryBuilder(string name) : base(new Query<ProductBundleComponentQuantityOption>(name))
        {
        }

        public ProductBundleComponentQuantityOptionQueryBuilder(IQuery<ProductBundleComponentQuantityOption> query) : base(query)
        {
        }

        public ProductBundleComponentQuantityOptionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ProductBundleComponentQuantityOptionQueryBuilder ParentOption(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionQueryBuilder> build)
        {
            var query = new Query<ProductOption>("parentOption");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOption>(query);
            return this;
        }

        public ProductBundleComponentQuantityOptionQueryBuilder Values(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentQuantityOptionValueQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentQuantityOptionValue>("values");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentQuantityOptionValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentQuantityOptionValue>(query);
            return this;
        }
    }
}