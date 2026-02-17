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
    public sealed class InventoryTransferMarkAsReadyToShipOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferMarkAsReadyToShipPayload, InventoryTransferMarkAsReadyToShipOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferMarkAsReadyToShipPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferMarkAsReadyToShipArgumentsBuilder Arguments { get; }
        protected override InventoryTransferMarkAsReadyToShipOperationQueryBuilder Self => this;

        public InventoryTransferMarkAsReadyToShipOperationQueryBuilder() : this("inventoryTransferMarkAsReadyToShip")
        {
        }

        public InventoryTransferMarkAsReadyToShipOperationQueryBuilder(string name) : base(new Query<InventoryTransferMarkAsReadyToShipPayload>(name))
        {
            Arguments = new InventoryTransferMarkAsReadyToShipArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferMarkAsReadyToShipOperationQueryBuilder(IQuery<InventoryTransferMarkAsReadyToShipPayload> query) : base(query)
        {
            Arguments = new InventoryTransferMarkAsReadyToShipArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferMarkAsReadyToShipOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferMarkAsReadyToShipOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferMarkAsReadyToShipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferMarkAsReadyToShipUserError>(query);
            return this;
        }
    }
}