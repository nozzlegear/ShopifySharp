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
    public sealed class InventoryShipmentRemoveItemsPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentRemoveItemsPayload, InventoryShipmentRemoveItemsPayloadQueryBuilder>
    {
        protected override InventoryShipmentRemoveItemsPayloadQueryBuilder Self => this;

        public InventoryShipmentRemoveItemsPayloadQueryBuilder() : this("inventoryShipmentRemoveItemsPayload")
        {
        }

        public InventoryShipmentRemoveItemsPayloadQueryBuilder(string name) : base(new Query<InventoryShipmentRemoveItemsPayload>(name))
        {
        }

        public InventoryShipmentRemoveItemsPayloadQueryBuilder(IQuery<InventoryShipmentRemoveItemsPayload> query) : base(query)
        {
        }

        public InventoryShipmentRemoveItemsPayloadQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentRemoveItemsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentRemoveItemsUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentRemoveItemsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentRemoveItemsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentRemoveItemsUserError>(query);
            return this;
        }
    }
}