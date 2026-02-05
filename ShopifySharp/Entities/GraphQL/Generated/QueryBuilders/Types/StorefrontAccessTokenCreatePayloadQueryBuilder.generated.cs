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
    public sealed class StorefrontAccessTokenCreatePayloadQueryBuilder : FieldsQueryBuilderBase<StorefrontAccessTokenCreatePayload, StorefrontAccessTokenCreatePayloadQueryBuilder>
    {
        protected override StorefrontAccessTokenCreatePayloadQueryBuilder Self => this;

        public StorefrontAccessTokenCreatePayloadQueryBuilder() : this("storefrontAccessTokenCreatePayload")
        {
        }

        public StorefrontAccessTokenCreatePayloadQueryBuilder(string name) : base(new Query<StorefrontAccessTokenCreatePayload>(name))
        {
        }

        public StorefrontAccessTokenCreatePayloadQueryBuilder(IQuery<StorefrontAccessTokenCreatePayload> query) : base(query)
        {
        }

        public StorefrontAccessTokenCreatePayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public StorefrontAccessTokenCreatePayloadQueryBuilder StorefrontAccessToken(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessToken>("storefrontAccessToken");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessToken>(query);
            return this;
        }

        public StorefrontAccessTokenCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}