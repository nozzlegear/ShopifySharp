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
    public sealed class InventoryShipmentDeleteOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentDeletePayload, InventoryShipmentDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentDeleteArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentDeleteOperationQueryBuilder Self => this;

        public InventoryShipmentDeleteOperationQueryBuilder() : this("inventoryShipmentDelete")
        {
        }

        public InventoryShipmentDeleteOperationQueryBuilder(string name) : base(new Query<InventoryShipmentDeletePayload>(name))
        {
            Arguments = new InventoryShipmentDeleteArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentDeleteOperationQueryBuilder(IQuery<InventoryShipmentDeletePayload> query) : base(query)
        {
            Arguments = new InventoryShipmentDeleteArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentDeleteOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryShipmentDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentDeleteUserError>(query);
            return this;
        }
    }
}