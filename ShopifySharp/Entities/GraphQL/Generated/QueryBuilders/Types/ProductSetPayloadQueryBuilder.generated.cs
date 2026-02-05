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
    public sealed class ProductSetPayloadQueryBuilder : FieldsQueryBuilderBase<ProductSetPayload, ProductSetPayloadQueryBuilder>
    {
        protected override ProductSetPayloadQueryBuilder Self => this;

        public ProductSetPayloadQueryBuilder() : this("productSetPayload")
        {
        }

        public ProductSetPayloadQueryBuilder(string name) : base(new Query<ProductSetPayload>(name))
        {
        }

        public ProductSetPayloadQueryBuilder(IQuery<ProductSetPayload> query) : base(query)
        {
        }

        public ProductSetPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductSetPayloadQueryBuilder ProductSetOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductSetOperationQueryBuilder> build)
        {
            var query = new Query<ProductSetOperation>("productSetOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductSetOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductSetOperation>(query);
            return this;
        }

        public ProductSetPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductSetUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductSetUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductSetUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductSetUserError>(query);
            return this;
        }
    }
}