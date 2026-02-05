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
    public sealed class AppInstallationEdgeQueryBuilder : FieldsQueryBuilderBase<AppInstallationEdge, AppInstallationEdgeQueryBuilder>
    {
        protected override AppInstallationEdgeQueryBuilder Self => this;

        public AppInstallationEdgeQueryBuilder() : this("appInstallationEdge")
        {
        }

        public AppInstallationEdgeQueryBuilder(string name) : base(new Query<AppInstallationEdge>(name))
        {
        }

        public AppInstallationEdgeQueryBuilder(IQuery<AppInstallationEdge> query) : base(query)
        {
        }

        public AppInstallationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AppInstallationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }
    }
}