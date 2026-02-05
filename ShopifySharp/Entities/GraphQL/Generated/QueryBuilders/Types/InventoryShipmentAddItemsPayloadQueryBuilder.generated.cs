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
    public sealed class InventoryShipmentAddItemsPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentAddItemsPayload, InventoryShipmentAddItemsPayloadQueryBuilder>
    {
        protected override InventoryShipmentAddItemsPayloadQueryBuilder Self => this;

        public InventoryShipmentAddItemsPayloadQueryBuilder() : this("inventoryShipmentAddItemsPayload")
        {
        }

        public InventoryShipmentAddItemsPayloadQueryBuilder(string name) : base(new Query<InventoryShipmentAddItemsPayload>(name))
        {
        }

        public InventoryShipmentAddItemsPayloadQueryBuilder(IQuery<InventoryShipmentAddItemsPayload> query) : base(query)
        {
        }

        public InventoryShipmentAddItemsPayloadQueryBuilder AddedItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItem>("addedItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItem>(query);
            return this;
        }

        public InventoryShipmentAddItemsPayloadQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentAddItemsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentAddItemsUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentAddItemsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentAddItemsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentAddItemsUserError>(query);
            return this;
        }
    }
}