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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class StorefrontAccessTokenQueryBuilder : FieldsQueryBuilderBase<StorefrontAccessToken, StorefrontAccessTokenQueryBuilder>
    {
        protected override StorefrontAccessTokenQueryBuilder Self => this;

        public StorefrontAccessTokenQueryBuilder() : this("storefrontAccessToken")
        {
        }

        public StorefrontAccessTokenQueryBuilder(string name) : base(new Query<StorefrontAccessToken>(name))
        {
        }

        public StorefrontAccessTokenQueryBuilder(IQuery<StorefrontAccessToken> query) : base(query)
        {
        }

        public StorefrontAccessTokenQueryBuilder AccessScopes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("accessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public StorefrontAccessTokenQueryBuilder AccessToken()
        {
            base.InnerQuery.AddField("accessToken");
            return this;
        }

        public StorefrontAccessTokenQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public StorefrontAccessTokenQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public StorefrontAccessTokenQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public StorefrontAccessTokenQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}