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
    public sealed class CollectionDuplicateOperationQueryBuilder : FieldsQueryBuilderBase<CollectionDuplicatePayload, CollectionDuplicateOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionDuplicatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionDuplicateArgumentsBuilder Arguments { get; }
        protected override CollectionDuplicateOperationQueryBuilder Self => this;

        public CollectionDuplicateOperationQueryBuilder() : this("collectionDuplicate")
        {
        }

        public CollectionDuplicateOperationQueryBuilder(string name) : base(new Query<CollectionDuplicatePayload>(name))
        {
            Arguments = new CollectionDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionDuplicateOperationQueryBuilder(IQuery<CollectionDuplicatePayload> query) : base(query)
        {
            Arguments = new CollectionDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionDuplicateOperationQueryBuilder Collection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionDuplicateOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CollectionDuplicateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionDuplicateUserErrorQueryBuilder> build)
        {
            var query = new Query<CollectionDuplicateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionDuplicateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionDuplicateUserError>(query);
            return this;
        }
    }
}