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
    public sealed class DeliveryWeightBasedRateGroupEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedRateGroupEdge, DeliveryWeightBasedRateGroupEdgeQueryBuilder>
    {
        protected override DeliveryWeightBasedRateGroupEdgeQueryBuilder Self => this;

        public DeliveryWeightBasedRateGroupEdgeQueryBuilder() : this("deliveryWeightBasedRateGroupEdge")
        {
        }

        public DeliveryWeightBasedRateGroupEdgeQueryBuilder(string name) : base(new Query<DeliveryWeightBasedRateGroupEdge>(name))
        {
        }

        public DeliveryWeightBasedRateGroupEdgeQueryBuilder(IQuery<DeliveryWeightBasedRateGroupEdge> query) : base(query)
        {
        }

        public DeliveryWeightBasedRateGroupEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryWeightBasedRateGroupEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateGroup>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateGroup>(query);
            return this;
        }
    }
}