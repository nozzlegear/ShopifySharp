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
    public sealed class InventoryShipmentMarkInTransitOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentMarkInTransitPayload, InventoryShipmentMarkInTransitOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentMarkInTransitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentMarkInTransitArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentMarkInTransitOperationQueryBuilder Self => this;

        public InventoryShipmentMarkInTransitOperationQueryBuilder() : this("inventoryShipmentMarkInTransit")
        {
        }

        public InventoryShipmentMarkInTransitOperationQueryBuilder(string name) : base(new Query<InventoryShipmentMarkInTransitPayload>(name))
        {
            Arguments = new InventoryShipmentMarkInTransitArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentMarkInTransitOperationQueryBuilder(IQuery<InventoryShipmentMarkInTransitPayload> query) : base(query)
        {
            Arguments = new InventoryShipmentMarkInTransitArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentMarkInTransitOperationQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentMarkInTransitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentMarkInTransitUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentMarkInTransitUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentMarkInTransitUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentMarkInTransitUserError>(query);
            return this;
        }
    }
}