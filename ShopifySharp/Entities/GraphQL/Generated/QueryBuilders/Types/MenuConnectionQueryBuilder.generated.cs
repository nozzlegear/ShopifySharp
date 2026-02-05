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
    public sealed class MenuConnectionQueryBuilder : FieldsQueryBuilderBase<MenuConnection, MenuConnectionQueryBuilder>
    {
        protected override MenuConnectionQueryBuilder Self => this;

        public MenuConnectionQueryBuilder() : this("menuConnection")
        {
        }

        public MenuConnectionQueryBuilder(string name) : base(new Query<MenuConnection>(name))
        {
        }

        public MenuConnectionQueryBuilder(IQuery<MenuConnection> query) : base(query)
        {
        }

        public MenuConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuEdgeQueryBuilder> build)
        {
            var query = new Query<MenuEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuEdge>(query);
            return this;
        }

        public MenuConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public MenuConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}