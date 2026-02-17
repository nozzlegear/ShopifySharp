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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CompanyLocationsOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationConnection, CompanyLocationsOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CompanyLocationsArgumentsBuilder Arguments { get; }
        protected override CompanyLocationsOperationQueryBuilder Self => this;

        public CompanyLocationsOperationQueryBuilder() : this("companyLocations")
        {
        }

        public CompanyLocationsOperationQueryBuilder(string name) : base(new Query<CompanyLocationConnection>(name))
        {
            Arguments = new CompanyLocationsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationsOperationQueryBuilder(IQuery<CompanyLocationConnection> query) : base(query)
        {
            Arguments = new CompanyLocationsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyLocationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationEdge>(query);
            return this;
        }

        public CompanyLocationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}