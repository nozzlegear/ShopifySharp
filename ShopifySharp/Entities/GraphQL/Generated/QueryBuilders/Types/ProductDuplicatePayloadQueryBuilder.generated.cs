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
    public sealed class ProductDuplicatePayloadQueryBuilder : FieldsQueryBuilderBase<ProductDuplicatePayload, ProductDuplicatePayloadQueryBuilder>
    {
        protected override ProductDuplicatePayloadQueryBuilder Self => this;

        public ProductDuplicatePayloadQueryBuilder() : this("productDuplicatePayload")
        {
        }

        public ProductDuplicatePayloadQueryBuilder(string name) : base(new Query<ProductDuplicatePayload>(name))
        {
        }

        public ProductDuplicatePayloadQueryBuilder(IQuery<ProductDuplicatePayload> query) : base(query)
        {
        }

        public ProductDuplicatePayloadQueryBuilder ImageJob(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("imageJob");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public ProductDuplicatePayloadQueryBuilder NewProduct(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("newProduct");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductDuplicatePayloadQueryBuilder ProductDuplicateOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder> build)
        {
            var query = new Query<ProductDuplicateOperation>("productDuplicateOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductDuplicateOperation>(query);
            return this;
        }

        public ProductDuplicatePayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public ProductDuplicatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}