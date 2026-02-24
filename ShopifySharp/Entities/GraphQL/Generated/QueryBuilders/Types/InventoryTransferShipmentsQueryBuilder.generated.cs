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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class InventoryTransferShipmentsQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentConnection, InventoryTransferShipmentsQueryBuilder>, IHasArguments<InventoryTransferShipmentsArgumentsBuilder>
    {
        public InventoryTransferShipmentsArgumentsBuilder Arguments { get; }
        protected override InventoryTransferShipmentsQueryBuilder Self => this;

        public InventoryTransferShipmentsQueryBuilder(string name) : base(new Query<InventoryShipmentConnection>(name))
        {
            Arguments = new InventoryTransferShipmentsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferShipmentsQueryBuilder(IQuery<InventoryShipmentConnection> query) : base(query)
        {
            Arguments = new InventoryTransferShipmentsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferShipmentsQueryBuilder SetArguments(Action<InventoryTransferShipmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryTransferShipmentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentEdge>(query);
            return this;
        }

        public InventoryTransferShipmentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public InventoryTransferShipmentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}