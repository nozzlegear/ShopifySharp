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
    public sealed class InventoryShipmentRemoveItemsUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentRemoveItemsUserError, InventoryShipmentRemoveItemsUserErrorQueryBuilder>
    {
        protected override InventoryShipmentRemoveItemsUserErrorQueryBuilder Self => this;

        public InventoryShipmentRemoveItemsUserErrorQueryBuilder() : this("inventoryShipmentRemoveItemsUserError")
        {
        }

        public InventoryShipmentRemoveItemsUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentRemoveItemsUserError>(name))
        {
        }

        public InventoryShipmentRemoveItemsUserErrorQueryBuilder(IQuery<InventoryShipmentRemoveItemsUserError> query) : base(query)
        {
        }

        public InventoryShipmentRemoveItemsUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentRemoveItemsUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentRemoveItemsUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}