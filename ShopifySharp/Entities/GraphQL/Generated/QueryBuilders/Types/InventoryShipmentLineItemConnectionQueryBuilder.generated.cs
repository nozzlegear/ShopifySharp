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
    public sealed class InventoryShipmentLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentLineItemConnection, InventoryShipmentLineItemConnectionQueryBuilder>
    {
        protected override InventoryShipmentLineItemConnectionQueryBuilder Self => this;

        public InventoryShipmentLineItemConnectionQueryBuilder() : this("inventoryShipmentLineItemConnection")
        {
        }

        public InventoryShipmentLineItemConnectionQueryBuilder(string name) : base(new Query<InventoryShipmentLineItemConnection>(name))
        {
        }

        public InventoryShipmentLineItemConnectionQueryBuilder(IQuery<InventoryShipmentLineItemConnection> query) : base(query)
        {
        }

        public InventoryShipmentLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItemEdge>(query);
            return this;
        }

        public InventoryShipmentLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItem>(query);
            return this;
        }

        public InventoryShipmentLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}