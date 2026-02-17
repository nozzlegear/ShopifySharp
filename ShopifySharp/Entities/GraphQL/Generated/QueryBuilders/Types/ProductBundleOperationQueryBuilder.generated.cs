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

        public ProductBundleOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductBundleOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ProductBundleOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleMutationUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductBundleMutationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleMutationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleMutationUserError>(query);
            return this;
        }
    }
}