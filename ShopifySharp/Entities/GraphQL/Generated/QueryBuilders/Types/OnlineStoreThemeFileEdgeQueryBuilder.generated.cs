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
    public sealed class OnlineStoreThemeFileEdgeQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFileEdge, OnlineStoreThemeFileEdgeQueryBuilder>
    {
        protected override OnlineStoreThemeFileEdgeQueryBuilder Self => this;

        public OnlineStoreThemeFileEdgeQueryBuilder() : this("onlineStoreThemeFileEdge")
        {
        }

        public OnlineStoreThemeFileEdgeQueryBuilder(string name) : base(new Query<OnlineStoreThemeFileEdge>(name))
        {
        }

        public OnlineStoreThemeFileEdgeQueryBuilder(IQuery<OnlineStoreThemeFileEdge> query) : base(query)
        {
        }

        public OnlineStoreThemeFileEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public OnlineStoreThemeFileEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFileQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFile>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFile>(query);
            return this;
        }
    }
}