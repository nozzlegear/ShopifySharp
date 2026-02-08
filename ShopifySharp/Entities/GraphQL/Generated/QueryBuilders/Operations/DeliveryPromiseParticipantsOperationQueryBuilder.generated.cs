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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class DeliveryPromiseParticipantsOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseParticipantConnection, DeliveryPromiseParticipantsOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryPromiseParticipantConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DeliveryPromiseParticipantsArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseParticipantsOperationQueryBuilder Self => this;

        public DeliveryPromiseParticipantsOperationQueryBuilder() : this("deliveryPromiseParticipants")
        {
        }

        public DeliveryPromiseParticipantsOperationQueryBuilder(string name) : base(new Query<DeliveryPromiseParticipantConnection>(name))
        {
            Arguments = new DeliveryPromiseParticipantsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantsOperationQueryBuilder(IQuery<DeliveryPromiseParticipantConnection> query) : base(query)
        {
            Arguments = new DeliveryPromiseParticipantsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipantEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipantEdge>(query);
            return this;
        }

        public DeliveryPromiseParticipantsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipant>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipant>(query);
            return this;
        }

        public DeliveryPromiseParticipantsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}