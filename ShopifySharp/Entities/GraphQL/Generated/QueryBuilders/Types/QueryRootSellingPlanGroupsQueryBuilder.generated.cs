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
    public sealed class QueryRootSellingPlanGroupsQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupConnection, QueryRootSellingPlanGroupsQueryBuilder>, IHasArguments<QueryRootSellingPlanGroupsArgumentsBuilder>
    {
        public QueryRootSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override QueryRootSellingPlanGroupsQueryBuilder Self => this;

        public QueryRootSellingPlanGroupsQueryBuilder(string name) : base(new Query<SellingPlanGroupConnection>(name))
        {
            Arguments = new QueryRootSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSellingPlanGroupsQueryBuilder(IQuery<SellingPlanGroupConnection> query) : base(query)
        {
            Arguments = new QueryRootSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSellingPlanGroupsQueryBuilder SetArguments(Action<QueryRootSellingPlanGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSellingPlanGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupEdge>(query);
            return this;
        }

        public QueryRootSellingPlanGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public QueryRootSellingPlanGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}