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
    public sealed class InventoryShipmentLineItemsQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentLineItemConnection, InventoryShipmentLineItemsQueryBuilder>, IHasArguments<InventoryShipmentLineItemsArgumentsBuilder>
    {
        public InventoryShipmentLineItemsArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentLineItemsQueryBuilder Self => this;

        public InventoryShipmentLineItemsQueryBuilder(string name) : base(new Query<InventoryShipmentLineItemConnection>(name))
        {
            Arguments = new InventoryShipmentLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentLineItemsQueryBuilder(IQuery<InventoryShipmentLineItemConnection> query) : base(query)
        {
            Arguments = new InventoryShipmentLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentLineItemsQueryBuilder SetArguments(Action<InventoryShipmentLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryShipmentLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItemEdge>(query);
            return this;
        }

        public InventoryShipmentLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItem>(query);
            return this;
        }

        public InventoryShipmentLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}