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
    [Obsolete("Use `publishablePublish` instead.")]
    public sealed class CollectionPublishOperationQueryBuilder : FieldsQueryBuilderBase<CollectionPublishPayload, CollectionPublishOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionPublishPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionPublishArgumentsBuilder Arguments { get; }
        protected override CollectionPublishOperationQueryBuilder Self => this;

        public CollectionPublishOperationQueryBuilder() : this("collectionPublish")
        {
        }

        public CollectionPublishOperationQueryBuilder(string name) : base(new Query<CollectionPublishPayload>(name))
        {
            Arguments = new CollectionPublishArgumentsBuilder(base.InnerQuery);
        }

        public CollectionPublishOperationQueryBuilder(IQuery<CollectionPublishPayload> query) : base(query)
        {
            Arguments = new CollectionPublishArgumentsBuilder(base.InnerQuery);
        }

        public CollectionPublishOperationQueryBuilder Collection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionPublishOperationQueryBuilder CollectionPublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionPublicationQueryBuilder> build)
        {
            var query = new Query<CollectionPublication>("collectionPublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionPublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionPublication>(query);
            return this;
        }

        public CollectionPublishOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public CollectionPublishOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}