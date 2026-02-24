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
    public sealed class InventoryTransferLineItemsQueryBuilder : FieldsQueryBuilderBase<InventoryTransferLineItemConnection, InventoryTransferLineItemsQueryBuilder>, IHasArguments<InventoryTransferLineItemsArgumentsBuilder>
    {
        public InventoryTransferLineItemsArgumentsBuilder Arguments { get; }
        protected override InventoryTransferLineItemsQueryBuilder Self => this;

        public InventoryTransferLineItemsQueryBuilder(string name) : base(new Query<InventoryTransferLineItemConnection>(name))
        {
            Arguments = new InventoryTransferLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferLineItemsQueryBuilder(IQuery<InventoryTransferLineItemConnection> query) : base(query)
        {
            Arguments = new InventoryTransferLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferLineItemsQueryBuilder SetArguments(Action<InventoryTransferLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryTransferLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItemEdge>(query);
            return this;
        }

        public InventoryTransferLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItem>(query);
            return this;
        }

        public InventoryTransferLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}