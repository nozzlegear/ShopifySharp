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
    public sealed class ThemesOperationQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeConnection, ThemesOperationQueryBuilder>, IGraphOperationQueryBuilder<OnlineStoreThemeConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ThemesArgumentsBuilder Arguments { get; }
        protected override ThemesOperationQueryBuilder Self => this;

        public ThemesOperationQueryBuilder() : this("themes")
        {
        }

        public ThemesOperationQueryBuilder(string name) : base(new Query<OnlineStoreThemeConnection>(name))
        {
            Arguments = new ThemesArgumentsBuilder(base.InnerQuery);
        }

        public ThemesOperationQueryBuilder(IQuery<OnlineStoreThemeConnection> query) : base(query)
        {
            Arguments = new ThemesArgumentsBuilder(base.InnerQuery);
        }

        public ThemesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeEdgeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeEdge>(query);
            return this;
        }

        public ThemesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public ThemesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}