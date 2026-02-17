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
    public sealed class InventoryShipmentAddItemsOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentAddItemsPayload, InventoryShipmentAddItemsOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentAddItemsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentAddItemsArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentAddItemsOperationQueryBuilder Self => this;

        public InventoryShipmentAddItemsOperationQueryBuilder() : this("inventoryShipmentAddItems")
        {
        }

        public InventoryShipmentAddItemsOperationQueryBuilder(string name) : base(new Query<InventoryShipmentAddItemsPayload>(name))
        {
            Arguments = new InventoryShipmentAddItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentAddItemsOperationQueryBuilder(IQuery<InventoryShipmentAddItemsPayload> query) : base(query)
        {
            Arguments = new InventoryShipmentAddItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentAddItemsOperationQueryBuilder AddedItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItem>("addedItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItem>(query);
            return this;
        }

        public InventoryShipmentAddItemsOperationQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentAddItemsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentAddItemsUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentAddItemsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentAddItemsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentAddItemsUserError>(query);
            return this;
        }
    }
}