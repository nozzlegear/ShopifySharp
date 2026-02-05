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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class InventoryTransferEdgeQueryBuilder : FieldsQueryBuilderBase<InventoryTransferEdge, InventoryTransferEdgeQueryBuilder>
    {
        protected override InventoryTransferEdgeQueryBuilder Self => this;

        public InventoryTransferEdgeQueryBuilder() : this("inventoryTransferEdge")
        {
        }

        public InventoryTransferEdgeQueryBuilder(string name) : base(new Query<InventoryTransferEdge>(name))
        {
        }

        public InventoryTransferEdgeQueryBuilder(IQuery<InventoryTransferEdge> query) : base(query)
        {
        }

        public InventoryTransferEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public InventoryTransferEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }
    }
}