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
    public sealed class StorefrontAccessTokenEdgeQueryBuilder : FieldsQueryBuilderBase<StorefrontAccessTokenEdge, StorefrontAccessTokenEdgeQueryBuilder>
    {
        protected override StorefrontAccessTokenEdgeQueryBuilder Self => this;

        public StorefrontAccessTokenEdgeQueryBuilder() : this("storefrontAccessTokenEdge")
        {
        }

        public StorefrontAccessTokenEdgeQueryBuilder(string name) : base(new Query<StorefrontAccessTokenEdge>(name))
        {
        }

        public StorefrontAccessTokenEdgeQueryBuilder(IQuery<StorefrontAccessTokenEdge> query) : base(query)
        {
        }

        public StorefrontAccessTokenEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public StorefrontAccessTokenEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessToken>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessToken>(query);
            return this;
        }
    }
}