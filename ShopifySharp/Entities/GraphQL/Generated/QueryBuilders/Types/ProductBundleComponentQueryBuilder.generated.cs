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
    public sealed class ProductBundleComponentQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponent, ProductBundleComponentQueryBuilder>
    {
        protected override ProductBundleComponentQueryBuilder Self => this;

        public ProductBundleComponentQueryBuilder() : this("productBundleComponent")
        {
        }

        public ProductBundleComponentQueryBuilder(string name) : base(new Query<ProductBundleComponent>(name))
        {
        }

        public ProductBundleComponentQueryBuilder(IQuery<ProductBundleComponent> query) : base(query)
        {
        }

        public ProductBundleComponentQueryBuilder ComponentProduct(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("componentProduct");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductBundleComponentQueryBuilder ComponentVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("componentVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public ProductBundleComponentQueryBuilder ComponentVariantsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("componentVariantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductBundleComponentQueryBuilder OptionSelections(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentOptionSelectionQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentOptionSelection>("optionSelections");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentOptionSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentOptionSelection>(query);
            return this;
        }

        public ProductBundleComponentQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public ProductBundleComponentQueryBuilder QuantityOption(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentQuantityOptionQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentQuantityOption>("quantityOption");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentQuantityOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentQuantityOption>(query);
            return this;
        }
    }
}