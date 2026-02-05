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
    public sealed class InventoryShipmentCreateInTransitPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentCreateInTransitPayload, InventoryShipmentCreateInTransitPayloadQueryBuilder>
    {
        protected override InventoryShipmentCreateInTransitPayloadQueryBuilder Self => this;

        public InventoryShipmentCreateInTransitPayloadQueryBuilder() : this("inventoryShipmentCreateInTransitPayload")
        {
        }

        public InventoryShipmentCreateInTransitPayloadQueryBuilder(string name) : base(new Query<InventoryShipmentCreateInTransitPayload>(name))
        {
        }

        public InventoryShipmentCreateInTransitPayloadQueryBuilder(IQuery<InventoryShipmentCreateInTransitPayload> query) : base(query)
        {
        }

        public InventoryShipmentCreateInTransitPayloadQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentCreateInTransitPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentCreateInTransitUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentCreateInTransitUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentCreateInTransitUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentCreateInTransitUserError>(query);
            return this;
        }
    }
}