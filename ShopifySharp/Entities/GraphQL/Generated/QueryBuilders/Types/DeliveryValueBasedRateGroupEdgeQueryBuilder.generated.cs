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
    public sealed class DeliveryValueBasedRateGroupEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryValueBasedRateGroupEdge, DeliveryValueBasedRateGroupEdgeQueryBuilder>
    {
        protected override DeliveryValueBasedRateGroupEdgeQueryBuilder Self => this;

        public DeliveryValueBasedRateGroupEdgeQueryBuilder() : this("deliveryValueBasedRateGroupEdge")
        {
        }

        public DeliveryValueBasedRateGroupEdgeQueryBuilder(string name) : base(new Query<DeliveryValueBasedRateGroupEdge>(name))
        {
        }

        public DeliveryValueBasedRateGroupEdgeQueryBuilder(IQuery<DeliveryValueBasedRateGroupEdge> query) : base(query)
        {
        }

        public DeliveryValueBasedRateGroupEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryValueBasedRateGroupEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRateGroup>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRateGroup>(query);
            return this;
        }
    }
}