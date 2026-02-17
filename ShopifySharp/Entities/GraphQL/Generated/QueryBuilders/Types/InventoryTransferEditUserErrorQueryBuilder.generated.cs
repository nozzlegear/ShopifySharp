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
    public sealed class InventoryTransferEditUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferEditUserError, InventoryTransferEditUserErrorQueryBuilder>
    {
        protected override InventoryTransferEditUserErrorQueryBuilder Self => this;

        public InventoryTransferEditUserErrorQueryBuilder() : this("inventoryTransferEditUserError")
        {
        }

        public InventoryTransferEditUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferEditUserError>(name))
        {
        }

        public InventoryTransferEditUserErrorQueryBuilder(IQuery<InventoryTransferEditUserError> query) : base(query)
        {
        }

        public InventoryTransferEditUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferEditUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferEditUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}