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
    public sealed class ProductDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ProductDeleteOperation, ProductDeleteOperationQueryBuilder>
    {
        protected override ProductDeleteOperationQueryBuilder Self => this;

        public ProductDeleteOperationQueryBuilder() : this("productDeleteOperation")
        {
        }

        public ProductDeleteOperationQueryBuilder(string name) : base(new Query<ProductDeleteOperation>(name))
        {
        }

        public ProductDeleteOperationQueryBuilder(IQuery<ProductDeleteOperation> query) : base(query)
        {
        }

        public ProductDeleteOperationQueryBuilder DeletedProductId()
        {
            base.InnerQuery.AddField("deletedProductId");
            return this;
        }

        public ProductDeleteOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductDeleteOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductDeleteOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ProductDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}