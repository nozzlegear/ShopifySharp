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
    public sealed class InventoryShipmentSetTrackingOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentSetTrackingPayload, InventoryShipmentSetTrackingOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentSetTrackingPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentSetTrackingArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentSetTrackingOperationQueryBuilder Self => this;

        public InventoryShipmentSetTrackingOperationQueryBuilder() : this("inventoryShipmentSetTracking")
        {
        }

        public InventoryShipmentSetTrackingOperationQueryBuilder(string name) : base(new Query<InventoryShipmentSetTrackingPayload>(name))
        {
            Arguments = new InventoryShipmentSetTrackingArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentSetTrackingOperationQueryBuilder(IQuery<InventoryShipmentSetTrackingPayload> query) : base(query)
        {
            Arguments = new InventoryShipmentSetTrackingArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentSetTrackingOperationQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentSetTrackingOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentSetTrackingUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentSetTrackingUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentSetTrackingUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentSetTrackingUserError>(query);
            return this;
        }
    }
}