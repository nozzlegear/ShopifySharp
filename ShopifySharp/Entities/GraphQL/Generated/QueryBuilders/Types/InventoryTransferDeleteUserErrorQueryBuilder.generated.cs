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
    public sealed class InventoryTransferDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferDeleteUserError, InventoryTransferDeleteUserErrorQueryBuilder>
    {
        protected override InventoryTransferDeleteUserErrorQueryBuilder Self => this;

        public InventoryTransferDeleteUserErrorQueryBuilder() : this("inventoryTransferDeleteUserError")
        {
        }

        public InventoryTransferDeleteUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferDeleteUserError>(name))
        {
        }

        public InventoryTransferDeleteUserErrorQueryBuilder(IQuery<InventoryTransferDeleteUserError> query) : base(query)
        {
        }

        public InventoryTransferDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}