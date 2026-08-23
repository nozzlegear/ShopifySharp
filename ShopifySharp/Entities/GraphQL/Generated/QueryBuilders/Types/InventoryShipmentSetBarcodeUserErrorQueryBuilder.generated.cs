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
    public sealed class InventoryShipmentSetBarcodeUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentSetBarcodeUserError, InventoryShipmentSetBarcodeUserErrorQueryBuilder>
    {
        protected override InventoryShipmentSetBarcodeUserErrorQueryBuilder Self => this;

        public InventoryShipmentSetBarcodeUserErrorQueryBuilder() : this("inventoryShipmentSetBarcodeUserError")
        {
        }

        public InventoryShipmentSetBarcodeUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentSetBarcodeUserError>(name))
        {
        }

        public InventoryShipmentSetBarcodeUserErrorQueryBuilder(IQuery<InventoryShipmentSetBarcodeUserError> query) : base(query)
        {
        }

        public InventoryShipmentSetBarcodeUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentSetBarcodeUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentSetBarcodeUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}