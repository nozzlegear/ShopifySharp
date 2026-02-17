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
    public sealed class InventoryShipmentCreateOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentCreatePayload, InventoryShipmentCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryShipmentCreateArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentCreateOperationQueryBuilder Self => this;

        public InventoryShipmentCreateOperationQueryBuilder() : this("inventoryShipmentCreate")
        {
        }

        public InventoryShipmentCreateOperationQueryBuilder(string name) : base(new Query<InventoryShipmentCreatePayload>(name))
        {
            Arguments = new InventoryShipmentCreateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentCreateOperationQueryBuilder(IQuery<InventoryShipmentCreatePayload> query) : base(query)
        {
            Arguments = new InventoryShipmentCreateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentCreateOperationQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentCreateUserError>(query);
            return this;
        }
    }
}