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
    public sealed class InventoryShipmentEdgeQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentEdge, InventoryShipmentEdgeQueryBuilder>
    {
        protected override InventoryShipmentEdgeQueryBuilder Self => this;

        public InventoryShipmentEdgeQueryBuilder() : this("inventoryShipmentEdge")
        {
        }

        public InventoryShipmentEdgeQueryBuilder(string name) : base(new Query<InventoryShipmentEdge>(name))
        {
        }

        public InventoryShipmentEdgeQueryBuilder(IQuery<InventoryShipmentEdge> query) : base(query)
        {
        }

        public InventoryShipmentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public InventoryShipmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }
    }
}