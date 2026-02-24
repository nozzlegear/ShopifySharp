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
    public sealed class QueryRootCompaniesQueryBuilder : FieldsQueryBuilderBase<CompanyConnection, QueryRootCompaniesQueryBuilder>, IHasArguments<QueryRootCompaniesArgumentsBuilder>
    {
        public QueryRootCompaniesArgumentsBuilder Arguments { get; }
        protected override QueryRootCompaniesQueryBuilder Self => this;

        public QueryRootCompaniesQueryBuilder(string name) : base(new Query<CompanyConnection>(name))
        {
            Arguments = new QueryRootCompaniesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompaniesQueryBuilder(IQuery<CompanyConnection> query) : base(query)
        {
            Arguments = new QueryRootCompaniesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompaniesQueryBuilder SetArguments(Action<QueryRootCompaniesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCompaniesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyEdge>(query);
            return this;
        }

        public QueryRootCompaniesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public QueryRootCompaniesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}