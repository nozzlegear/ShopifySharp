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
    public sealed class FulfillmentEventsQueryBuilder : FieldsQueryBuilderBase<FulfillmentEventConnection, FulfillmentEventsQueryBuilder>, IHasArguments<FulfillmentEventsArgumentsBuilder>
    {
        public FulfillmentEventsArgumentsBuilder Arguments { get; }
        protected override FulfillmentEventsQueryBuilder Self => this;

        public FulfillmentEventsQueryBuilder(string name) : base(new Query<FulfillmentEventConnection>(name))
        {
            Arguments = new FulfillmentEventsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentEventsQueryBuilder(IQuery<FulfillmentEventConnection> query) : base(query)
        {
            Arguments = new FulfillmentEventsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentEventsQueryBuilder SetArguments(Action<FulfillmentEventsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentEventsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentEventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEventEdge>(query);
            return this;
        }

        public FulfillmentEventsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventQueryBuilder> build)
        {
            var query = new Query<FulfillmentEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEvent>(query);
            return this;
        }

        public FulfillmentEventsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}