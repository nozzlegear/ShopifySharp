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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class AppInstallationsOperationQueryBuilder : FieldsQueryBuilderBase<AppInstallationConnection, AppInstallationsOperationQueryBuilder>, IGraphOperationQueryBuilder<AppInstallationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AppInstallationsArgumentsBuilder Arguments { get; }
        protected override AppInstallationsOperationQueryBuilder Self => this;

        public AppInstallationsOperationQueryBuilder() : this("appInstallations")
        {
        }

        public AppInstallationsOperationQueryBuilder(string name) : base(new Query<AppInstallationConnection>(name))
        {
            Arguments = new AppInstallationsArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationsOperationQueryBuilder(IQuery<AppInstallationConnection> query) : base(query)
        {
            Arguments = new AppInstallationsArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationEdgeQueryBuilder> build)
        {
            var query = new Query<AppInstallationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallationEdge>(query);
            return this;
        }

        public AppInstallationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public AppInstallationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}