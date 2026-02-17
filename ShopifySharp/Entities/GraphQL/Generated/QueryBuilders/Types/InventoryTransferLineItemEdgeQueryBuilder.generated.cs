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
    public sealed class InventoryTransferLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<InventoryTransferLineItemEdge, InventoryTransferLineItemEdgeQueryBuilder>
    {
        protected override InventoryTransferLineItemEdgeQueryBuilder Self => this;

        public InventoryTransferLineItemEdgeQueryBuilder() : this("inventoryTransferLineItemEdge")
        {
        }

        public InventoryTransferLineItemEdgeQueryBuilder(string name) : base(new Query<InventoryTransferLineItemEdge>(name))
        {
        }

        public InventoryTransferLineItemEdgeQueryBuilder(IQuery<InventoryTransferLineItemEdge> query) : base(query)
        {
        }

        public InventoryTransferLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public InventoryTransferLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItem>(query);
            return this;
        }
    }
}