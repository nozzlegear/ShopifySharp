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
    public sealed class InventoryTransferCreateAsReadyToShipPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryTransferCreateAsReadyToShipPayload, InventoryTransferCreateAsReadyToShipPayloadQueryBuilder>
    {
        protected override InventoryTransferCreateAsReadyToShipPayloadQueryBuilder Self => this;

        public InventoryTransferCreateAsReadyToShipPayloadQueryBuilder() : this("inventoryTransferCreateAsReadyToShipPayload")
        {
        }

        public InventoryTransferCreateAsReadyToShipPayloadQueryBuilder(string name) : base(new Query<InventoryTransferCreateAsReadyToShipPayload>(name))
        {
        }

        public InventoryTransferCreateAsReadyToShipPayloadQueryBuilder(IQuery<InventoryTransferCreateAsReadyToShipPayload> query) : base(query)
        {
        }

        public InventoryTransferCreateAsReadyToShipPayloadQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferCreateAsReadyToShipPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferCreateAsReadyToShipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferCreateAsReadyToShipUserError>(query);
            return this;
        }
    }
}