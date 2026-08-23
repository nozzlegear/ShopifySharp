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
    public sealed class DeliveryValueBasedRateEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryValueBasedRateEdge, DeliveryValueBasedRateEdgeQueryBuilder>
    {
        protected override DeliveryValueBasedRateEdgeQueryBuilder Self => this;

        public DeliveryValueBasedRateEdgeQueryBuilder() : this("deliveryValueBasedRateEdge")
        {
        }

        public DeliveryValueBasedRateEdgeQueryBuilder(string name) : base(new Query<DeliveryValueBasedRateEdge>(name))
        {
        }

        public DeliveryValueBasedRateEdgeQueryBuilder(IQuery<DeliveryValueBasedRateEdge> query) : base(query)
        {
        }

        public DeliveryValueBasedRateEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryValueBasedRateEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRate>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRate>(query);
            return this;
        }
    }
}