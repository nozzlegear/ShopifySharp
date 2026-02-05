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
    public sealed class EventConnectionQueryBuilder : FieldsQueryBuilderBase<EventConnection, EventConnectionQueryBuilder>
    {
        protected override EventConnectionQueryBuilder Self => this;

        public EventConnectionQueryBuilder() : this("eventConnection")
        {
        }

        public EventConnectionQueryBuilder(string name) : base(new Query<EventConnection>(name))
        {
        }

        public EventConnectionQueryBuilder(IQuery<EventConnection> query) : base(query)
        {
        }

        public EventConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventEdgeQueryBuilder> build)
        {
            var query = new Query<EventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventEdge>(query);
            return this;
        }

        public EventConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventQueryBuilder> build)
        {
            var query = new Query<IEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IEvent>(query);
            return this;
        }

        public EventConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}