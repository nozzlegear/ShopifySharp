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
    public sealed class InventoryTransferMarkAsReadyToShipPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryTransferMarkAsReadyToShipPayload, InventoryTransferMarkAsReadyToShipPayloadQueryBuilder>
    {
        protected override InventoryTransferMarkAsReadyToShipPayloadQueryBuilder Self => this;

        public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder() : this("inventoryTransferMarkAsReadyToShipPayload")
        {
        }

        public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder(string name) : base(new Query<InventoryTransferMarkAsReadyToShipPayload>(name))
        {
        }

        public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder(IQuery<InventoryTransferMarkAsReadyToShipPayload> query) : base(query)
        {
        }

        public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferMarkAsReadyToShipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferMarkAsReadyToShipUserError>(query);
            return this;
        }
    }
}