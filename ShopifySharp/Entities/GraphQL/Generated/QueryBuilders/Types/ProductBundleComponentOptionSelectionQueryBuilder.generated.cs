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
    public sealed class ProductBundleComponentOptionSelectionQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponentOptionSelection, ProductBundleComponentOptionSelectionQueryBuilder>
    {
        protected override ProductBundleComponentOptionSelectionQueryBuilder Self => this;

        public ProductBundleComponentOptionSelectionQueryBuilder() : this("productBundleComponentOptionSelection")
        {
        }

        public ProductBundleComponentOptionSelectionQueryBuilder(string name) : base(new Query<ProductBundleComponentOptionSelection>(name))
        {
        }

        public ProductBundleComponentOptionSelectionQueryBuilder(IQuery<ProductBundleComponentOptionSelection> query) : base(query)
        {
        }

        public ProductBundleComponentOptionSelectionQueryBuilder ComponentOption(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionQueryBuilder> build)
        {
            var query = new Query<ProductOption>("componentOption");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOption>(query);
            return this;
        }

        public ProductBundleComponentOptionSelectionQueryBuilder ParentOption(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionQueryBuilder> build)
        {
            var query = new Query<ProductOption>("parentOption");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOption>(query);
            return this;
        }

        public ProductBundleComponentOptionSelectionQueryBuilder Values(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentOptionSelectionValueQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentOptionSelectionValue>("values");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentOptionSelectionValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentOptionSelectionValue>(query);
            return this;
        }
    }
}