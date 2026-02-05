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
    public sealed class InventoryTransferCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferCreateUserError, InventoryTransferCreateUserErrorQueryBuilder>
    {
        protected override InventoryTransferCreateUserErrorQueryBuilder Self => this;

        public InventoryTransferCreateUserErrorQueryBuilder() : this("inventoryTransferCreateUserError")
        {
        }

        public InventoryTransferCreateUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferCreateUserError>(name))
        {
        }

        public InventoryTransferCreateUserErrorQueryBuilder(IQuery<InventoryTransferCreateUserError> query) : base(query)
        {
        }

        public InventoryTransferCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}