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
    public sealed class InventoryTransferSetItemsUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferSetItemsUserError, InventoryTransferSetItemsUserErrorQueryBuilder>
    {
        protected override InventoryTransferSetItemsUserErrorQueryBuilder Self => this;

        public InventoryTransferSetItemsUserErrorQueryBuilder() : this("inventoryTransferSetItemsUserError")
        {
        }

        public InventoryTransferSetItemsUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferSetItemsUserError>(name))
        {
        }

        public InventoryTransferSetItemsUserErrorQueryBuilder(IQuery<InventoryTransferSetItemsUserError> query) : base(query)
        {
        }

        public InventoryTransferSetItemsUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferSetItemsUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferSetItemsUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}