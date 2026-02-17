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
    public sealed class InventoryShipmentSetTrackingUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentSetTrackingUserError, InventoryShipmentSetTrackingUserErrorQueryBuilder>
    {
        protected override InventoryShipmentSetTrackingUserErrorQueryBuilder Self => this;

        public InventoryShipmentSetTrackingUserErrorQueryBuilder() : this("inventoryShipmentSetTrackingUserError")
        {
        }

        public InventoryShipmentSetTrackingUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentSetTrackingUserError>(name))
        {
        }

        public InventoryShipmentSetTrackingUserErrorQueryBuilder(IQuery<InventoryShipmentSetTrackingUserError> query) : base(query)
        {
        }

        public InventoryShipmentSetTrackingUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentSetTrackingUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentSetTrackingUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}