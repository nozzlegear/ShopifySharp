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
    public sealed class DeliveryPromiseParticipantEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseParticipantEdge, DeliveryPromiseParticipantEdgeQueryBuilder>
    {
        protected override DeliveryPromiseParticipantEdgeQueryBuilder Self => this;

        public DeliveryPromiseParticipantEdgeQueryBuilder() : this("deliveryPromiseParticipantEdge")
        {
        }

        public DeliveryPromiseParticipantEdgeQueryBuilder(string name) : base(new Query<DeliveryPromiseParticipantEdge>(name))
        {
        }

        public DeliveryPromiseParticipantEdgeQueryBuilder(IQuery<DeliveryPromiseParticipantEdge> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryPromiseParticipantEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipant>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipant>(query);
            return this;
        }
    }
}