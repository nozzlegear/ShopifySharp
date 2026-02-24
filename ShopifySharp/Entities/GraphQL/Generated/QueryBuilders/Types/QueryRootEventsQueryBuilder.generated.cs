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
    public sealed class QueryRootEventsQueryBuilder : FieldsQueryBuilderBase<EventConnection, QueryRootEventsQueryBuilder>, IHasArguments<QueryRootEventsArgumentsBuilder>
    {
        public QueryRootEventsArgumentsBuilder Arguments { get; }
        protected override QueryRootEventsQueryBuilder Self => this;

        public QueryRootEventsQueryBuilder(string name) : base(new Query<EventConnection>(name))
        {
            Arguments = new QueryRootEventsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootEventsQueryBuilder(IQuery<EventConnection> query) : base(query)
        {
            Arguments = new QueryRootEventsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootEventsQueryBuilder SetArguments(Action<QueryRootEventsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootEventsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventEdgeQueryBuilder> build)
        {
            var query = new Query<EventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventEdge>(query);
            return this;
        }

        public QueryRootEventsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventQueryBuilder> build)
        {
            var query = new Query<IEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IEvent>(query);
            return this;
        }

        public QueryRootEventsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}