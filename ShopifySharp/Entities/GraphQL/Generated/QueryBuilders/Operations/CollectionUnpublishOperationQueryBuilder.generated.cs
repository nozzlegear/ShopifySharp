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
    [Obsolete("Use `publishableUnpublish` instead.")]
    public sealed class CollectionUnpublishOperationQueryBuilder : FieldsQueryBuilderBase<CollectionUnpublishPayload, CollectionUnpublishOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionUnpublishPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionUnpublishArgumentsBuilder Arguments { get; }
        protected override CollectionUnpublishOperationQueryBuilder Self => this;

        public CollectionUnpublishOperationQueryBuilder() : this("collectionUnpublish")
        {
        }

        public CollectionUnpublishOperationQueryBuilder(string name) : base(new Query<CollectionUnpublishPayload>(name))
        {
            Arguments = new CollectionUnpublishArgumentsBuilder(base.InnerQuery);
        }

        public CollectionUnpublishOperationQueryBuilder(IQuery<CollectionUnpublishPayload> query) : base(query)
        {
            Arguments = new CollectionUnpublishArgumentsBuilder(base.InnerQuery);
        }

        public CollectionUnpublishOperationQueryBuilder Collection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionUnpublishOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public CollectionUnpublishOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}