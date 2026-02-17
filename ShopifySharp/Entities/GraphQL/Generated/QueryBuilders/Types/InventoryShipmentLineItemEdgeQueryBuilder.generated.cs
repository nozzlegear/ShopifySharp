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
    public sealed class InventoryShipmentLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentLineItemEdge, InventoryShipmentLineItemEdgeQueryBuilder>
    {
        protected override InventoryShipmentLineItemEdgeQueryBuilder Self => this;

        public InventoryShipmentLineItemEdgeQueryBuilder() : this("inventoryShipmentLineItemEdge")
        {
        }

        public InventoryShipmentLineItemEdgeQueryBuilder(string name) : base(new Query<InventoryShipmentLineItemEdge>(name))
        {
        }

        public InventoryShipmentLineItemEdgeQueryBuilder(IQuery<InventoryShipmentLineItemEdge> query) : base(query)
        {
        }

        public InventoryShipmentLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public InventoryShipmentLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItem>(query);
            return this;
        }
    }
}