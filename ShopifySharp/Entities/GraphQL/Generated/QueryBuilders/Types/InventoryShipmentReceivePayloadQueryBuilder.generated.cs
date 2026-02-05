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
    public sealed class InventoryShipmentReceivePayloadQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentReceivePayload, InventoryShipmentReceivePayloadQueryBuilder>
    {
        protected override InventoryShipmentReceivePayloadQueryBuilder Self => this;

        public InventoryShipmentReceivePayloadQueryBuilder() : this("inventoryShipmentReceivePayload")
        {
        }

        public InventoryShipmentReceivePayloadQueryBuilder(string name) : base(new Query<InventoryShipmentReceivePayload>(name))
        {
        }

        public InventoryShipmentReceivePayloadQueryBuilder(IQuery<InventoryShipmentReceivePayload> query) : base(query)
        {
        }

        public InventoryShipmentReceivePayloadQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentReceivePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentReceiveUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentReceiveUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentReceiveUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentReceiveUserError>(query);
            return this;
        }
    }
}