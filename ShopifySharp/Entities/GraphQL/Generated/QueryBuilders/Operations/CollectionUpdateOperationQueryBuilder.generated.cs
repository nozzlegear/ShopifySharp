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
    public sealed class CollectionUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CollectionUpdatePayload, CollectionUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionUpdateArgumentsBuilder Arguments { get; }
        protected override CollectionUpdateOperationQueryBuilder Self => this;

        public CollectionUpdateOperationQueryBuilder() : this("collectionUpdate")
        {
        }

        public CollectionUpdateOperationQueryBuilder(string name) : base(new Query<CollectionUpdatePayload>(name))
        {
            Arguments = new CollectionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionUpdateOperationQueryBuilder(IQuery<CollectionUpdatePayload> query) : base(query)
        {
            Arguments = new CollectionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionUpdateOperationQueryBuilder Collection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionUpdateOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CollectionUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}