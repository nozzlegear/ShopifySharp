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
    public sealed class InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentUpdateItemQuantitiesPayload, InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentUpdateItemQuantitiesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentUpdateItemQuantitiesArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder Self => this;

        public InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder() : this("inventoryShipmentUpdateItemQuantities")
        {
        }

        public InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder(string name) : base(new Query<InventoryShipmentUpdateItemQuantitiesPayload>(name))
        {
            Arguments = new InventoryShipmentUpdateItemQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder(IQuery<InventoryShipmentUpdateItemQuantitiesPayload> query) : base(query)
        {
            Arguments = new InventoryShipmentUpdateItemQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder Shipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("shipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder UpdatedLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItem>("updatedLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItem>(query);
            return this;
        }

        public InventoryShipmentUpdateItemQuantitiesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentUpdateItemQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentUpdateItemQuantitiesUserError>(query);
            return this;
        }
    }
}