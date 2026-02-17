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
    public sealed class EventEdgeQueryBuilder : FieldsQueryBuilderBase<EventEdge, EventEdgeQueryBuilder>
    {
        protected override EventEdgeQueryBuilder Self => this;

        public EventEdgeQueryBuilder() : this("eventEdge")
        {
        }

        public EventEdgeQueryBuilder(string name) : base(new Query<EventEdge>(name))
        {
        }

        public EventEdgeQueryBuilder(IQuery<EventEdge> query) : base(query)
        {
        }

        public EventEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public EventEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventQueryBuilder> build)
        {
            var query = new Query<IEvent>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IEvent>(query);
            return this;
        }
    }
}