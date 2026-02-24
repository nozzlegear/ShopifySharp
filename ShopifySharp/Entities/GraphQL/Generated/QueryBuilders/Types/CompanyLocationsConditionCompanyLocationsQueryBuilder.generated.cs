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
    public sealed class CompanyLocationsConditionCompanyLocationsQueryBuilder : FieldsQueryBuilderBase<CompanyLocationConnection, CompanyLocationsConditionCompanyLocationsQueryBuilder>, IHasArguments<CompanyLocationsConditionCompanyLocationsArgumentsBuilder>
    {
        public CompanyLocationsConditionCompanyLocationsArgumentsBuilder Arguments { get; }
        protected override CompanyLocationsConditionCompanyLocationsQueryBuilder Self => this;

        public CompanyLocationsConditionCompanyLocationsQueryBuilder(string name) : base(new Query<CompanyLocationConnection>(name))
        {
            Arguments = new CompanyLocationsConditionCompanyLocationsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationsConditionCompanyLocationsQueryBuilder(IQuery<CompanyLocationConnection> query) : base(query)
        {
            Arguments = new CompanyLocationsConditionCompanyLocationsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationsConditionCompanyLocationsQueryBuilder SetArguments(Action<CompanyLocationsConditionCompanyLocationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CompanyLocationsConditionCompanyLocationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyLocationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationEdge>(query);
            return this;
        }

        public CompanyLocationsConditionCompanyLocationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationsConditionCompanyLocationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}