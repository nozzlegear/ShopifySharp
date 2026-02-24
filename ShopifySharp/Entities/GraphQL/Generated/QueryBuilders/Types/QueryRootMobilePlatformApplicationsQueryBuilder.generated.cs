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
    public sealed class QueryRootMobilePlatformApplicationsQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationConnection, QueryRootMobilePlatformApplicationsQueryBuilder>, IHasArguments<QueryRootMobilePlatformApplicationsArgumentsBuilder>
    {
        public QueryRootMobilePlatformApplicationsArgumentsBuilder Arguments { get; }
        protected override QueryRootMobilePlatformApplicationsQueryBuilder Self => this;

        public QueryRootMobilePlatformApplicationsQueryBuilder(string name) : base(new Query<MobilePlatformApplicationConnection>(name))
        {
            Arguments = new QueryRootMobilePlatformApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMobilePlatformApplicationsQueryBuilder(IQuery<MobilePlatformApplicationConnection> query) : base(query)
        {
            Arguments = new QueryRootMobilePlatformApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMobilePlatformApplicationsQueryBuilder SetArguments(Action<QueryRootMobilePlatformApplicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMobilePlatformApplicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MobilePlatformApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MobilePlatformApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationEdge>(query);
            return this;
        }

        public QueryRootMobilePlatformApplicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public QueryRootMobilePlatformApplicationsQueryBuilder Nodes(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("nodes");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}