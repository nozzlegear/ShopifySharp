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
    public sealed class QueryRootAppInstallationsQueryBuilder : FieldsQueryBuilderBase<AppInstallationConnection, QueryRootAppInstallationsQueryBuilder>, IHasArguments<QueryRootAppInstallationsArgumentsBuilder>
    {
        public QueryRootAppInstallationsArgumentsBuilder Arguments { get; }
        protected override QueryRootAppInstallationsQueryBuilder Self => this;

        public QueryRootAppInstallationsQueryBuilder(string name) : base(new Query<AppInstallationConnection>(name))
        {
            Arguments = new QueryRootAppInstallationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAppInstallationsQueryBuilder(IQuery<AppInstallationConnection> query) : base(query)
        {
            Arguments = new QueryRootAppInstallationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAppInstallationsQueryBuilder SetArguments(Action<QueryRootAppInstallationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootAppInstallationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationEdgeQueryBuilder> build)
        {
            var query = new Query<AppInstallationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallationEdge>(query);
            return this;
        }

        public QueryRootAppInstallationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public QueryRootAppInstallationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}