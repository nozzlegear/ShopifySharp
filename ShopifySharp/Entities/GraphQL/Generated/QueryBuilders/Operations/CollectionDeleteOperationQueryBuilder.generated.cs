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
    public sealed class CollectionDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CollectionDeletePayload, CollectionDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionDeleteArgumentsBuilder Arguments { get; }
        protected override CollectionDeleteOperationQueryBuilder Self => this;

        public CollectionDeleteOperationQueryBuilder() : this("collectionDelete")
        {
        }

        public CollectionDeleteOperationQueryBuilder(string name) : base(new Query<CollectionDeletePayload>(name))
        {
            Arguments = new CollectionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CollectionDeleteOperationQueryBuilder(IQuery<CollectionDeletePayload> query) : base(query)
        {
            Arguments = new CollectionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CollectionDeleteOperationQueryBuilder DeletedCollectionId()
        {
            base.InnerQuery.AddField("deletedCollectionId");
            return this;
        }

        public CollectionDeleteOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public CollectionDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}