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
    public sealed class DeliveryPromiseParticipantConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseParticipantConnection, DeliveryPromiseParticipantConnectionQueryBuilder>
    {
        protected override DeliveryPromiseParticipantConnectionQueryBuilder Self => this;

        public DeliveryPromiseParticipantConnectionQueryBuilder() : this("deliveryPromiseParticipantConnection")
        {
        }

        public DeliveryPromiseParticipantConnectionQueryBuilder(string name) : base(new Query<DeliveryPromiseParticipantConnection>(name))
        {
        }

        public DeliveryPromiseParticipantConnectionQueryBuilder(IQuery<DeliveryPromiseParticipantConnection> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipantEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipantEdge>(query);
            return this;
        }

        public DeliveryPromiseParticipantConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipant>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipant>(query);
            return this;
        }

        public DeliveryPromiseParticipantConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}