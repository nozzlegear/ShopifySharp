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
    public sealed class DeliveryLocationGroupZoneEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryLocationGroupZoneEdge, DeliveryLocationGroupZoneEdgeQueryBuilder>
    {
        protected override DeliveryLocationGroupZoneEdgeQueryBuilder Self => this;

        public DeliveryLocationGroupZoneEdgeQueryBuilder() : this("deliveryLocationGroupZoneEdge")
        {
        }

        public DeliveryLocationGroupZoneEdgeQueryBuilder(string name) : base(new Query<DeliveryLocationGroupZoneEdge>(name))
        {
        }

        public DeliveryLocationGroupZoneEdgeQueryBuilder(IQuery<DeliveryLocationGroupZoneEdge> query) : base(query)
        {
        }

        public DeliveryLocationGroupZoneEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryLocationGroupZoneEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationGroupZoneQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationGroupZone>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationGroupZoneQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationGroupZone>(query);
            return this;
        }
    }
}