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
    public sealed class CollectionDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CollectionDeletePayload, CollectionDeletePayloadQueryBuilder>
    {
        protected override CollectionDeletePayloadQueryBuilder Self => this;

        public CollectionDeletePayloadQueryBuilder() : this("collectionDeletePayload")
        {
        }

        public CollectionDeletePayloadQueryBuilder(string name) : base(new Query<CollectionDeletePayload>(name))
        {
        }

        public CollectionDeletePayloadQueryBuilder(IQuery<CollectionDeletePayload> query) : base(query)
        {
        }

        public CollectionDeletePayloadQueryBuilder DeletedCollectionId()
        {
            base.InnerQuery.AddField("deletedCollectionId");
            return this;
        }

        public CollectionDeletePayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public CollectionDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}