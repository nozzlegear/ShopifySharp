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
    public sealed class CollectionPublishPayloadQueryBuilder : FieldsQueryBuilderBase<CollectionPublishPayload, CollectionPublishPayloadQueryBuilder>
    {
        protected override CollectionPublishPayloadQueryBuilder Self => this;

        public CollectionPublishPayloadQueryBuilder() : this("collectionPublishPayload")
        {
        }

        public CollectionPublishPayloadQueryBuilder(string name) : base(new Query<CollectionPublishPayload>(name))
        {
        }

        public CollectionPublishPayloadQueryBuilder(IQuery<CollectionPublishPayload> query) : base(query)
        {
        }

        public CollectionPublishPayloadQueryBuilder Collection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionPublishPayloadQueryBuilder CollectionPublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionPublicationQueryBuilder> build)
        {
            var query = new Query<CollectionPublication>("collectionPublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionPublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionPublication>(query);
            return this;
        }

        public CollectionPublishPayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public CollectionPublishPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}