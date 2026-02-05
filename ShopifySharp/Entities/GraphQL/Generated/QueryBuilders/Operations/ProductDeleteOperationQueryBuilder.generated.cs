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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ProductDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ProductDeletePayload, ProductDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductDeleteArgumentsBuilder Arguments { get; }
        protected override ProductDeleteOperationQueryBuilder Self => this;

        public ProductDeleteOperationQueryBuilder() : this("productDelete")
        {
        }

        public ProductDeleteOperationQueryBuilder(string name) : base(new Query<ProductDeletePayload>(name))
        {
            Arguments = new ProductDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ProductDeleteOperationQueryBuilder(IQuery<ProductDeletePayload> query) : base(query)
        {
            Arguments = new ProductDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ProductDeleteOperationQueryBuilder DeletedProductId()
        {
            base.InnerQuery.AddField("deletedProductId");
            return this;
        }

        public ProductDeleteOperationQueryBuilder ProductDeleteOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductDeleteOperationQueryBuilder> build)
        {
            var query = new Query<ProductDeleteOperation>("productDeleteOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductDeleteOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductDeleteOperation>(query);
            return this;
        }

        public ProductDeleteOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
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