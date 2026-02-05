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
    public sealed class InventoryTransferCancelUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferCancelUserError, InventoryTransferCancelUserErrorQueryBuilder>
    {
        protected override InventoryTransferCancelUserErrorQueryBuilder Self => this;

        public InventoryTransferCancelUserErrorQueryBuilder() : this("inventoryTransferCancelUserError")
        {
        }

        public InventoryTransferCancelUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferCancelUserError>(name))
        {
        }

        public InventoryTransferCancelUserErrorQueryBuilder(IQuery<InventoryTransferCancelUserError> query) : base(query)
        {
        }

        public InventoryTransferCancelUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferCancelUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferCancelUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}