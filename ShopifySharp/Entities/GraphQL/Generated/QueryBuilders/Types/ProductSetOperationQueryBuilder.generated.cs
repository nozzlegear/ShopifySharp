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
    public sealed class ProductSetOperationQueryBuilder : FieldsQueryBuilderBase<ProductSetOperation, ProductSetOperationQueryBuilder>
    {
        protected override ProductSetOperationQueryBuilder Self => this;

        public ProductSetOperationQueryBuilder() : this("productSetOperation")
        {
        }

        public ProductSetOperationQueryBuilder(string name) : base(new Query<ProductSetOperation>(name))
        {
        }

        public ProductSetOperationQueryBuilder(IQuery<ProductSetOperation> query) : base(query)
        {
        }

        public ProductSetOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductSetOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductSetOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ProductSetOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductSetUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductSetUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductSetUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductSetUserError>(query);
            return this;
        }
    }
}