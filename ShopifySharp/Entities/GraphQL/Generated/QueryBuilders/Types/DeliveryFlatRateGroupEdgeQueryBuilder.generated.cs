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
    public sealed class DeliveryFlatRateGroupEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryFlatRateGroupEdge, DeliveryFlatRateGroupEdgeQueryBuilder>
    {
        protected override DeliveryFlatRateGroupEdgeQueryBuilder Self => this;

        public DeliveryFlatRateGroupEdgeQueryBuilder() : this("deliveryFlatRateGroupEdge")
        {
        }

        public DeliveryFlatRateGroupEdgeQueryBuilder(string name) : base(new Query<DeliveryFlatRateGroupEdge>(name))
        {
        }

        public DeliveryFlatRateGroupEdgeQueryBuilder(IQuery<DeliveryFlatRateGroupEdge> query) : base(query)
        {
        }

        public DeliveryFlatRateGroupEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryFlatRateGroupEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRateGroup>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryFlatRateGroup>(query);
            return this;
        }
    }
}