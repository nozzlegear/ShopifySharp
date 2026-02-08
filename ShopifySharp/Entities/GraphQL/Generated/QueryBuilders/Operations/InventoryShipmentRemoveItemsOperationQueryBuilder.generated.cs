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
    public sealed class InventoryShipmentRemoveItemsOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentRemoveItemsPayload, InventoryShipmentRemoveItemsOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentRemoveItemsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentRemoveItemsArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentRemoveItemsOperationQueryBuilder Self => this;

        public InventoryShipmentRemoveItemsOperationQueryBuilder() : this("inventoryShipmentRemoveItems")
        {
        }

        public InventoryShipmentRemoveItemsOperationQueryBuilder(string name) : base(new Query<InventoryShipmentRemoveItemsPayload>(name))
        {
            Arguments = new InventoryShipmentRemoveItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentRemoveItemsOperationQueryBuilder(IQuery<InventoryShipmentRemoveItemsPayload> query) : base(query)
        {
            Arguments = new InventoryShipmentRemoveItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentRemoveItemsOperationQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentRemoveItemsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentRemoveItemsUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentRemoveItemsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentRemoveItemsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentRemoveItemsUserError>(query);
            return this;
        }
    }
}