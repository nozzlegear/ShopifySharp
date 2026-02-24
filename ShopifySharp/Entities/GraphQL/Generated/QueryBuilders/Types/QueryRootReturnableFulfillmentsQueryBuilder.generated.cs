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
    public sealed class QueryRootReturnableFulfillmentsQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillmentConnection, QueryRootReturnableFulfillmentsQueryBuilder>, IHasArguments<QueryRootReturnableFulfillmentsArgumentsBuilder>
    {
        public QueryRootReturnableFulfillmentsArgumentsBuilder Arguments { get; }
        protected override QueryRootReturnableFulfillmentsQueryBuilder Self => this;

        public QueryRootReturnableFulfillmentsQueryBuilder(string name) : base(new Query<ReturnableFulfillmentConnection>(name))
        {
            Arguments = new QueryRootReturnableFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReturnableFulfillmentsQueryBuilder(IQuery<ReturnableFulfillmentConnection> query) : base(query)
        {
            Arguments = new QueryRootReturnableFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReturnableFulfillmentsQueryBuilder SetArguments(Action<QueryRootReturnableFulfillmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootReturnableFulfillmentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentEdge>(query);
            return this;
        }

        public QueryRootReturnableFulfillmentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillment>(query);
            return this;
        }

        public QueryRootReturnableFulfillmentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}