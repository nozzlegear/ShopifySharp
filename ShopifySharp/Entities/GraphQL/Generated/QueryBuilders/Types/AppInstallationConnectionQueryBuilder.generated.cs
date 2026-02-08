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
    public sealed class AppInstallationConnectionQueryBuilder : FieldsQueryBuilderBase<AppInstallationConnection, AppInstallationConnectionQueryBuilder>
    {
        protected override AppInstallationConnectionQueryBuilder Self => this;

        public AppInstallationConnectionQueryBuilder() : this("appInstallationConnection")
        {
        }

        public AppInstallationConnectionQueryBuilder(string name) : base(new Query<AppInstallationConnection>(name))
        {
        }

        public AppInstallationConnectionQueryBuilder(IQuery<AppInstallationConnection> query) : base(query)
        {
        }

        public AppInstallationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationEdgeQueryBuilder> build)
        {
            var query = new Query<AppInstallationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallationEdge>(query);
            return this;
        }

        public AppInstallationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public AppInstallationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}