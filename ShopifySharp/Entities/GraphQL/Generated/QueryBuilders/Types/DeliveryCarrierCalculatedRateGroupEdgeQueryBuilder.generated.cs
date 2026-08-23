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
    public sealed class DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierCalculatedRateGroupEdge, DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder>
    {
        protected override DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder Self => this;

        public DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder() : this("deliveryCarrierCalculatedRateGroupEdge")
        {
        }

        public DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder(string name) : base(new Query<DeliveryCarrierCalculatedRateGroupEdge>(name))
        {
        }

        public DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder(IQuery<DeliveryCarrierCalculatedRateGroupEdge> query) : base(query)
        {
        }

        public DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierCalculatedRateGroup>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierCalculatedRateGroup>(query);
            return this;
        }
    }
}