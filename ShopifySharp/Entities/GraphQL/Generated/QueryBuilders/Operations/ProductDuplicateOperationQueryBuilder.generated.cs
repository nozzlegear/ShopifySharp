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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ProductDuplicateOperationQueryBuilder : FieldsQueryBuilderBase<ProductDuplicatePayload, ProductDuplicateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductDuplicatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductDuplicateArgumentsBuilder Arguments { get; }
        protected override ProductDuplicateOperationQueryBuilder Self => this;

        public ProductDuplicateOperationQueryBuilder() : this("productDuplicate")
        {
        }

        public ProductDuplicateOperationQueryBuilder(string name) : base(new Query<ProductDuplicatePayload>(name))
        {
            Arguments = new ProductDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public ProductDuplicateOperationQueryBuilder(IQuery<ProductDuplicatePayload> query) : base(query)
        {
            Arguments = new ProductDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public ProductDuplicateOperationQueryBuilder ImageJob(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("imageJob");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public ProductDuplicateOperationQueryBuilder NewProduct(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("newProduct");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductDuplicateOperationQueryBuilder ProductDuplicateOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder> build)
        {
            var query = new Query<ProductDuplicateOperation>("productDuplicateOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductDuplicateOperation>(query);
            return this;
        }

        public ProductDuplicateOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public ProductDuplicateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}