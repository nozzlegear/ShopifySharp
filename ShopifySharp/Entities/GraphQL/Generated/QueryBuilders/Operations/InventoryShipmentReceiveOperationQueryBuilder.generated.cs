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
    public sealed class InventoryShipmentReceiveOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentReceivePayload, InventoryShipmentReceiveOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentReceivePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentReceiveArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentReceiveOperationQueryBuilder Self => this;

        public InventoryShipmentReceiveOperationQueryBuilder() : this("inventoryShipmentReceive")
        {
        }

        public InventoryShipmentReceiveOperationQueryBuilder(string name) : base(new Query<InventoryShipmentReceivePayload>(name))
        {
            Arguments = new InventoryShipmentReceiveArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentReceiveOperationQueryBuilder(IQuery<InventoryShipmentReceivePayload> query) : base(query)
        {
            Arguments = new InventoryShipmentReceiveArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentReceiveOperationQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentReceiveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentReceiveUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentReceiveUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentReceiveUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentReceiveUserError>(query);
            return this;
        }
    }
}