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
    public sealed class SavedSearchDeletePayloadQueryBuilder : FieldsQueryBuilderBase<SavedSearchDeletePayload, SavedSearchDeletePayloadQueryBuilder>
    {
        protected override SavedSearchDeletePayloadQueryBuilder Self => this;

        public SavedSearchDeletePayloadQueryBuilder() : this("savedSearchDeletePayload")
        {
        }

        public SavedSearchDeletePayloadQueryBuilder(string name) : base(new Query<SavedSearchDeletePayload>(name))
        {
        }

        public SavedSearchDeletePayloadQueryBuilder(IQuery<SavedSearchDeletePayload> query) : base(query)
        {
        }

        public SavedSearchDeletePayloadQueryBuilder DeletedSavedSearchId()
        {
            base.InnerQuery.AddField("deletedSavedSearchId");
            return this;
        }

        public SavedSearchDeletePayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public SavedSearchDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}