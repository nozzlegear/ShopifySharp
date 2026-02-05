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
    public sealed class InventoryShipmentDeletePayloadQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentDeletePayload, InventoryShipmentDeletePayloadQueryBuilder>
    {
        protected override InventoryShipmentDeletePayloadQueryBuilder Self => this;

        public InventoryShipmentDeletePayloadQueryBuilder() : this("inventoryShipmentDeletePayload")
        {
        }

        public InventoryShipmentDeletePayloadQueryBuilder(string name) : base(new Query<InventoryShipmentDeletePayload>(name))
        {
        }

        public InventoryShipmentDeletePayloadQueryBuilder(IQuery<InventoryShipmentDeletePayload> query) : base(query)
        {
        }

        public InventoryShipmentDeletePayloadQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryShipmentDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentDeleteUserError>(query);
            return this;
        }
    }
}