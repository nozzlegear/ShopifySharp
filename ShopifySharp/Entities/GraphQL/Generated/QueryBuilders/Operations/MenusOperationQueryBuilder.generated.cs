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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class MenusOperationQueryBuilder : FieldsQueryBuilderBase<MenuConnection, MenusOperationQueryBuilder>, IGraphOperationQueryBuilder<MenuConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MenusArgumentsBuilder Arguments { get; }
        protected override MenusOperationQueryBuilder Self => this;

        public MenusOperationQueryBuilder() : this("menus")
        {
        }

        public MenusOperationQueryBuilder(string name) : base(new Query<MenuConnection>(name))
        {
            Arguments = new MenusArgumentsBuilder(base.InnerQuery);
        }

        public MenusOperationQueryBuilder(IQuery<MenuConnection> query) : base(query)
        {
            Arguments = new MenusArgumentsBuilder(base.InnerQuery);
        }

        public MenusOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuEdgeQueryBuilder> build)
        {
            var query = new Query<MenuEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuEdge>(query);
            return this;
        }

        public MenusOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public MenusOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}