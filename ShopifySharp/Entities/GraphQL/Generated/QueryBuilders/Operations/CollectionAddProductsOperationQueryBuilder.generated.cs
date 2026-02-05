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
    public sealed class CollectionAddProductsOperationQueryBuilder : FieldsQueryBuilderBase<CollectionAddProductsPayload, CollectionAddProductsOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionAddProductsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionAddProductsArgumentsBuilder Arguments { get; }
        protected override CollectionAddProductsOperationQueryBuilder Self => this;

        public CollectionAddProductsOperationQueryBuilder() : this("collectionAddProducts")
        {
        }

        public CollectionAddProductsOperationQueryBuilder(string name) : base(new Query<CollectionAddProductsPayload>(name))
        {
            Arguments = new CollectionAddProductsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionAddProductsOperationQueryBuilder(IQuery<CollectionAddProductsPayload> query) : base(query)
        {
            Arguments = new CollectionAddProductsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionAddProductsOperationQueryBuilder Collection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionAddProductsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}