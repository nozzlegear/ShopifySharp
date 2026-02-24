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
    public sealed class ShopStorefrontAccessTokensQueryBuilder : FieldsQueryBuilderBase<StorefrontAccessTokenConnection, ShopStorefrontAccessTokensQueryBuilder>, IHasArguments<ShopStorefrontAccessTokensArgumentsBuilder>
    {
        public ShopStorefrontAccessTokensArgumentsBuilder Arguments { get; }
        protected override ShopStorefrontAccessTokensQueryBuilder Self => this;

        public ShopStorefrontAccessTokensQueryBuilder(string name) : base(new Query<StorefrontAccessTokenConnection>(name))
        {
            Arguments = new ShopStorefrontAccessTokensArgumentsBuilder(base.InnerQuery);
        }

        public ShopStorefrontAccessTokensQueryBuilder(IQuery<StorefrontAccessTokenConnection> query) : base(query)
        {
            Arguments = new ShopStorefrontAccessTokensArgumentsBuilder(base.InnerQuery);
        }

        public ShopStorefrontAccessTokensQueryBuilder SetArguments(Action<ShopStorefrontAccessTokensArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopStorefrontAccessTokensQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenEdgeQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessTokenEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessTokenEdge>(query);
            return this;
        }

        public ShopStorefrontAccessTokensQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessToken>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessToken>(query);
            return this;
        }

        public ShopStorefrontAccessTokensQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}