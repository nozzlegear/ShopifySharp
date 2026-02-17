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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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

        public InventoryTransferCreateAsReadyToShipOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferCreateAsReadyToShipOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferCreateAsReadyToShipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferCreateAsReadyToShipUserError>(query);
            return this;
        }
    }
}