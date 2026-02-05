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
    public sealed class StorefrontAccessTokenConnectionQueryBuilder : FieldsQueryBuilderBase<StorefrontAccessTokenConnection, StorefrontAccessTokenConnectionQueryBuilder>
    {
        protected override StorefrontAccessTokenConnectionQueryBuilder Self => this;

        public StorefrontAccessTokenConnectionQueryBuilder() : this("storefrontAccessTokenConnection")
        {
        }

        public StorefrontAccessTokenConnectionQueryBuilder(string name) : base(new Query<StorefrontAccessTokenConnection>(name))
        {
        }

        public StorefrontAccessTokenConnectionQueryBuilder(IQuery<StorefrontAccessTokenConnection> query) : base(query)
        {
        }

        public StorefrontAccessTokenConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenEdgeQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessTokenEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessTokenEdge>(query);
            return this;
        }

        public StorefrontAccessTokenConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessToken>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessToken>(query);
            return this;
        }

        public StorefrontAccessTokenConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}