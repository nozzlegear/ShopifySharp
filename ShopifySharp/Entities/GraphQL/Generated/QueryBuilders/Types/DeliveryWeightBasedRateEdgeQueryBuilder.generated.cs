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
    public sealed class DeliveryWeightBasedRateEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedRateEdge, DeliveryWeightBasedRateEdgeQueryBuilder>
    {
        protected override DeliveryWeightBasedRateEdgeQueryBuilder Self => this;

        public DeliveryWeightBasedRateEdgeQueryBuilder() : this("deliveryWeightBasedRateEdge")
        {
        }

        public DeliveryWeightBasedRateEdgeQueryBuilder(string name) : base(new Query<DeliveryWeightBasedRateEdge>(name))
        {
        }

        public DeliveryWeightBasedRateEdgeQueryBuilder(IQuery<DeliveryWeightBasedRateEdge> query) : base(query)
        {
        }

        public DeliveryWeightBasedRateEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryWeightBasedRateEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRate>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRate>(query);
            return this;
        }
    }
}