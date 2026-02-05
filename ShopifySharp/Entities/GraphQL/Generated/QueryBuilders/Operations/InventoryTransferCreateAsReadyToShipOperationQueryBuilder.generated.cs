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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class InventoryTransferCreateAsReadyToShipOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferCreateAsReadyToShipPayload, InventoryTransferCreateAsReadyToShipOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferCreateAsReadyToShipPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferCreateAsReadyToShipArgumentsBuilder Arguments { get; }
        protected override InventoryTransferCreateAsReadyToShipOperationQueryBuilder Self => this;

        public InventoryTransferCreateAsReadyToShipOperationQueryBuilder() : this("inventoryTransferCreateAsReadyToShip")
        {
        }

        public InventoryTransferCreateAsReadyToShipOperationQueryBuilder(string name) : base(new Query<InventoryTransferCreateAsReadyToShipPayload>(name))
        {
            Arguments = new InventoryTransferCreateAsReadyToShipArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferCreateAsReadyToShipOperationQueryBuilder(IQuery<InventoryTransferCreateAsReadyToShipPayload> query) : base(query)
        {
            Arguments = new InventoryTransferCreateAsReadyToShipArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferCreateAsReadyToShipOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferCreateAsReadyToShipOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferCreateAsReadyToShipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferCreateAsReadyToShipUserError>(query);
            return this;
        }
    }
}