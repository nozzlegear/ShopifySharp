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
    public sealed class DeliveryCarrierServiceEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierServiceEdge, DeliveryCarrierServiceEdgeQueryBuilder>
    {
        protected override DeliveryCarrierServiceEdgeQueryBuilder Self => this;

        public DeliveryCarrierServiceEdgeQueryBuilder() : this("deliveryCarrierServiceEdge")
        {
        }

        public DeliveryCarrierServiceEdgeQueryBuilder(string name) : base(new Query<DeliveryCarrierServiceEdge>(name))
        {
        }

        public DeliveryCarrierServiceEdgeQueryBuilder(IQuery<DeliveryCarrierServiceEdge> query) : base(query)
        {
        }

        public DeliveryCarrierServiceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryCarrierServiceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }
    }
}