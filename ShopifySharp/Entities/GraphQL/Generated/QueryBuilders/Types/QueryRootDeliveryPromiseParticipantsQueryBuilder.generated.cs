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
    public sealed class QueryRootDeliveryPromiseParticipantsQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseParticipantConnection, QueryRootDeliveryPromiseParticipantsQueryBuilder>, IHasArguments<QueryRootDeliveryPromiseParticipantsArgumentsBuilder>
    {
        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder Arguments { get; }
        protected override QueryRootDeliveryPromiseParticipantsQueryBuilder Self => this;

        public QueryRootDeliveryPromiseParticipantsQueryBuilder(string name) : base(new Query<DeliveryPromiseParticipantConnection>(name))
        {
            Arguments = new QueryRootDeliveryPromiseParticipantsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDeliveryPromiseParticipantsQueryBuilder(IQuery<DeliveryPromiseParticipantConnection> query) : base(query)
        {
            Arguments = new QueryRootDeliveryPromiseParticipantsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDeliveryPromiseParticipantsQueryBuilder SetArguments(Action<QueryRootDeliveryPromiseParticipantsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipantEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipantEdge>(query);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipant>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipant>(query);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}