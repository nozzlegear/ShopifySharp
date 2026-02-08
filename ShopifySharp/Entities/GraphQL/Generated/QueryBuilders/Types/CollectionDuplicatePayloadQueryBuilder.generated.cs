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
    public sealed class CollectionDuplicatePayloadQueryBuilder : FieldsQueryBuilderBase<CollectionDuplicatePayload, CollectionDuplicatePayloadQueryBuilder>
    {
        protected override CollectionDuplicatePayloadQueryBuilder Self => this;

        public CollectionDuplicatePayloadQueryBuilder() : this("collectionDuplicatePayload")
        {
        }

        public CollectionDuplicatePayloadQueryBuilder(string name) : base(new Query<CollectionDuplicatePayload>(name))
        {
        }

        public CollectionDuplicatePayloadQueryBuilder(IQuery<CollectionDuplicatePayload> query) : base(query)
        {
        }

        public CollectionDuplicatePayloadQueryBuilder Collection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionDuplicatePayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CollectionDuplicatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionDuplicateUserErrorQueryBuilder> build)
        {
            var query = new Query<CollectionDuplicateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionDuplicateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionDuplicateUserError>(query);
            return this;
        }
    }
}