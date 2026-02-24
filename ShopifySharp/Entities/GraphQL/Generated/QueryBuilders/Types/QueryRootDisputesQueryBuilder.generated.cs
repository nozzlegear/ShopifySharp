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
    public sealed class QueryRootDisputesQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeConnection, QueryRootDisputesQueryBuilder>, IHasArguments<QueryRootDisputesArgumentsBuilder>
    {
        public QueryRootDisputesArgumentsBuilder Arguments { get; }
        protected override QueryRootDisputesQueryBuilder Self => this;

        public QueryRootDisputesQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeConnection>(name))
        {
            Arguments = new QueryRootDisputesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDisputesQueryBuilder(IQuery<ShopifyPaymentsDisputeConnection> query) : base(query)
        {
            Arguments = new QueryRootDisputesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDisputesQueryBuilder SetArguments(Action<QueryRootDisputesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDisputesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEdge>(query);
            return this;
        }

        public QueryRootDisputesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDispute>(query);
            return this;
        }

        public QueryRootDisputesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}