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
    public sealed class InventoryShipmentSetBarcodeOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentSetBarcodePayload, InventoryShipmentSetBarcodeOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentSetBarcodePayload>, IHasArguments<InventoryShipmentSetBarcodeArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentSetBarcodeArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentSetBarcodeOperationQueryBuilder Self => this;

        public InventoryShipmentSetBarcodeOperationQueryBuilder() : this("inventoryShipmentSetBarcode")
        {
        }

        public InventoryShipmentSetBarcodeOperationQueryBuilder(string name) : base(new Query<InventoryShipmentSetBarcodePayload>(name))
        {
            Arguments = new InventoryShipmentSetBarcodeArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentSetBarcodeOperationQueryBuilder(IQuery<InventoryShipmentSetBarcodePayload> query) : base(query)
        {
            Arguments = new InventoryShipmentSetBarcodeArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentSetBarcodeOperationQueryBuilder SetArguments(Action<InventoryShipmentSetBarcodeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryShipmentSetBarcodeOperationQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentSetBarcodeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentSetBarcodeUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentSetBarcodeUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentSetBarcodeUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentSetBarcodeUserError>(query);
            return this;
        }
    }
}