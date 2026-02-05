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
    public sealed class InventoryShipmentSetTrackingPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentSetTrackingPayload, InventoryShipmentSetTrackingPayloadQueryBuilder>
    {
        protected override InventoryShipmentSetTrackingPayloadQueryBuilder Self => this;

        public InventoryShipmentSetTrackingPayloadQueryBuilder() : this("inventoryShipmentSetTrackingPayload")
        {
        }

        public InventoryShipmentSetTrackingPayloadQueryBuilder(string name) : base(new Query<InventoryShipmentSetTrackingPayload>(name))
        {
        }

        public InventoryShipmentSetTrackingPayloadQueryBuilder(IQuery<InventoryShipmentSetTrackingPayload> query) : base(query)
        {
        }

        public InventoryShipmentSetTrackingPayloadQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentSetTrackingPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentSetTrackingUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentSetTrackingUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentSetTrackingUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentSetTrackingUserError>(query);
            return this;
        }
    }
}