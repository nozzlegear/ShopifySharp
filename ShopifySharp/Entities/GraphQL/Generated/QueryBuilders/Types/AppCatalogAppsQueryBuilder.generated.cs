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
    public sealed class AppCatalogAppsQueryBuilder : FieldsQueryBuilderBase<AppConnection, AppCatalogAppsQueryBuilder>, IHasArguments<AppCatalogAppsArgumentsBuilder>
    {
        public AppCatalogAppsArgumentsBuilder Arguments { get; }
        protected override AppCatalogAppsQueryBuilder Self => this;

        public AppCatalogAppsQueryBuilder(string name) : base(new Query<AppConnection>(name))
        {
            Arguments = new AppCatalogAppsArgumentsBuilder(base.InnerQuery);
        }

        public AppCatalogAppsQueryBuilder(IQuery<AppConnection> query) : base(query)
        {
            Arguments = new AppCatalogAppsArgumentsBuilder(base.InnerQuery);
        }

        public AppCatalogAppsQueryBuilder SetArguments(Action<AppCatalogAppsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AppCatalogAppsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppEdgeQueryBuilder> build)
        {
            var query = new Query<AppEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppEdge>(query);
            return this;
        }

        public AppCatalogAppsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppCatalogAppsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}