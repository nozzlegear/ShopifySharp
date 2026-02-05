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
    public sealed class InventoryShipmentAddItemsUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentAddItemsUserError, InventoryShipmentAddItemsUserErrorQueryBuilder>
    {
        protected override InventoryShipmentAddItemsUserErrorQueryBuilder Self => this;

        public InventoryShipmentAddItemsUserErrorQueryBuilder() : this("inventoryShipmentAddItemsUserError")
        {
        }

        public InventoryShipmentAddItemsUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentAddItemsUserError>(name))
        {
        }

        public InventoryShipmentAddItemsUserErrorQueryBuilder(IQuery<InventoryShipmentAddItemsUserError> query) : base(query)
        {
        }

        public InventoryShipmentAddItemsUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentAddItemsUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentAddItemsUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}