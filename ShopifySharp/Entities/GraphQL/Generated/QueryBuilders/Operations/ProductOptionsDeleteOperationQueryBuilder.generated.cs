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
    public sealed class ProductOptionsDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ProductOptionsDeletePayload, ProductOptionsDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductOptionsDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductOptionsDeleteArgumentsBuilder Arguments { get; }
        protected override ProductOptionsDeleteOperationQueryBuilder Self => this;

        public ProductOptionsDeleteOperationQueryBuilder() : this("productOptionsDelete")
        {
        }

        public ProductOptionsDeleteOperationQueryBuilder(string name) : base(new Query<ProductOptionsDeletePayload>(name))
        {
            Arguments = new ProductOptionsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionsDeleteOperationQueryBuilder(IQuery<ProductOptionsDeletePayload> query) : base(query)
        {
            Arguments = new ProductOptionsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionsDeleteOperationQueryBuilder DeletedOptionsIds()
        {
            base.InnerQuery.AddField("deletedOptionsIds");
            return this;
        }

        public ProductOptionsDeleteOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOptionsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductOptionsDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionsDeleteUserError>(query);
            return this;
        }
    }
}