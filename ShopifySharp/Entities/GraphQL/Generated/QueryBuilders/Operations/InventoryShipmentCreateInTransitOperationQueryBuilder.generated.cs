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
    public sealed class InventoryShipmentCreateInTransitOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentCreateInTransitPayload, InventoryShipmentCreateInTransitOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentCreateInTransitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentCreateInTransitArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentCreateInTransitOperationQueryBuilder Self => this;

        public InventoryShipmentCreateInTransitOperationQueryBuilder() : this("inventoryShipmentCreateInTransit")
        {
        }

        public InventoryShipmentCreateInTransitOperationQueryBuilder(string name) : base(new Query<InventoryShipmentCreateInTransitPayload>(name))
        {
            Arguments = new InventoryShipmentCreateInTransitArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentCreateInTransitOperationQueryBuilder(IQuery<InventoryShipmentCreateInTransitPayload> query) : base(query)
        {
            Arguments = new InventoryShipmentCreateInTransitArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentCreateInTransitOperationQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentCreateInTransitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentCreateInTransitUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentCreateInTransitUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentCreateInTransitUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentCreateInTransitUserError>(query);
            return this;
        }
    }
}