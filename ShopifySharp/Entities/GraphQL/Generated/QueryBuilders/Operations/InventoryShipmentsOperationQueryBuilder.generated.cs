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
    public sealed class InventoryShipmentsOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentConnection, InventoryShipmentsOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipmentConnection>, IHasArguments<InventoryShipmentsArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public InventoryShipmentsArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentsOperationQueryBuilder Self => this;

        public InventoryShipmentsOperationQueryBuilder() : this("inventoryShipments")
        {
        }

        public InventoryShipmentsOperationQueryBuilder(string name) : base(new Query<InventoryShipmentConnection>(name))
        {
            Arguments = new InventoryShipmentsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentsOperationQueryBuilder(IQuery<InventoryShipmentConnection> query) : base(query)
        {
            Arguments = new InventoryShipmentsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentsOperationQueryBuilder SetArguments(Action<InventoryShipmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryShipmentsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentEdge>(query);
            return this;
        }

        public InventoryShipmentsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryShipmentsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}