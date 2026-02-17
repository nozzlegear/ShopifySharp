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
    public sealed class InventoryTransferRemoveItemsUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferRemoveItemsUserError, InventoryTransferRemoveItemsUserErrorQueryBuilder>
    {
        protected override InventoryTransferRemoveItemsUserErrorQueryBuilder Self => this;

        public InventoryTransferRemoveItemsUserErrorQueryBuilder() : this("inventoryTransferRemoveItemsUserError")
        {
        }

        public InventoryTransferRemoveItemsUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferRemoveItemsUserError>(name))
        {
        }

        public InventoryTransferRemoveItemsUserErrorQueryBuilder(IQuery<InventoryTransferRemoveItemsUserError> query) : base(query)
        {
        }

        public InventoryTransferRemoveItemsUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferRemoveItemsUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferRemoveItemsUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}