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
    public sealed class OnlineStoreThemeEdgeQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeEdge, OnlineStoreThemeEdgeQueryBuilder>
    {
        protected override OnlineStoreThemeEdgeQueryBuilder Self => this;

        public OnlineStoreThemeEdgeQueryBuilder() : this("onlineStoreThemeEdge")
        {
        }

        public OnlineStoreThemeEdgeQueryBuilder(string name) : base(new Query<OnlineStoreThemeEdge>(name))
        {
        }

        public OnlineStoreThemeEdgeQueryBuilder(IQuery<OnlineStoreThemeEdge> query) : base(query)
        {
        }

        public OnlineStoreThemeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public OnlineStoreThemeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }
    }
}