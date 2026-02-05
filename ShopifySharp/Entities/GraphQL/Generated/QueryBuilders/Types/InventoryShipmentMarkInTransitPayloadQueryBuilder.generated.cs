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
    public sealed class InventoryShipmentMarkInTransitPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentMarkInTransitPayload, InventoryShipmentMarkInTransitPayloadQueryBuilder>
    {
        protected override InventoryShipmentMarkInTransitPayloadQueryBuilder Self => this;

        public InventoryShipmentMarkInTransitPayloadQueryBuilder() : this("inventoryShipmentMarkInTransitPayload")
        {
        }

        public InventoryShipmentMarkInTransitPayloadQueryBuilder(string name) : base(new Query<InventoryShipmentMarkInTransitPayload>(name))
        {
        }

        public InventoryShipmentMarkInTransitPayloadQueryBuilder(IQuery<InventoryShipmentMarkInTransitPayload> query) : base(query)
        {
        }

        public InventoryShipmentMarkInTransitPayloadQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentMarkInTransitPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentMarkInTransitUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentMarkInTransitUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentMarkInTransitUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentMarkInTransitUserError>(query);
            return this;
        }
    }
}