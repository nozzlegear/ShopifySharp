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
    public sealed class QueryRootCompanyLocationsQueryBuilder : FieldsQueryBuilderBase<CompanyLocationConnection, QueryRootCompanyLocationsQueryBuilder>, IHasArguments<QueryRootCompanyLocationsArgumentsBuilder>
    {
        public QueryRootCompanyLocationsArgumentsBuilder Arguments { get; }
        protected override QueryRootCompanyLocationsQueryBuilder Self => this;

        public QueryRootCompanyLocationsQueryBuilder(string name) : base(new Query<CompanyLocationConnection>(name))
        {
            Arguments = new QueryRootCompanyLocationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompanyLocationsQueryBuilder(IQuery<CompanyLocationConnection> query) : base(query)
        {
            Arguments = new QueryRootCompanyLocationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompanyLocationsQueryBuilder SetArguments(Action<QueryRootCompanyLocationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCompanyLocationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyLocationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationEdge>(query);
            return this;
        }

        public QueryRootCompanyLocationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public QueryRootCompanyLocationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}