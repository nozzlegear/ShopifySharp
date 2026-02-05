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
    public sealed class InventoryTransferDuplicateUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferDuplicateUserError, InventoryTransferDuplicateUserErrorQueryBuilder>
    {
        protected override InventoryTransferDuplicateUserErrorQueryBuilder Self => this;

        public InventoryTransferDuplicateUserErrorQueryBuilder() : this("inventoryTransferDuplicateUserError")
        {
        }

        public InventoryTransferDuplicateUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferDuplicateUserError>(name))
        {
        }

        public InventoryTransferDuplicateUserErrorQueryBuilder(IQuery<InventoryTransferDuplicateUserError> query) : base(query)
        {
        }

        public InventoryTransferDuplicateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferDuplicateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferDuplicateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}