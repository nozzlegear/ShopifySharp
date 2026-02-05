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
    public sealed class ProductBundleOperationQueryBuilder : FieldsQueryBuilderBase<ProductBundleOperation, ProductBundleOperationQueryBuilder>
    {
        protected override ProductBundleOperationQueryBuilder Self => this;

        public ProductBundleOperationQueryBuilder() : this("productBundleOperation")
        {
        }

        public ProductBundleOperationQueryBuilder(string name) : base(new Query<ProductBundleOperation>(name))
        {
        }

        public ProductBundleOperationQueryBuilder(IQuery<ProductBundleOperation> query) : base(query)
        {
        }

        public ProductBundleOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductBundleOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductBundleOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ProductBundleOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleMutationUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductBundleMutationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleMutationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleMutationUserError>(query);
            return this;
        }
    }
}