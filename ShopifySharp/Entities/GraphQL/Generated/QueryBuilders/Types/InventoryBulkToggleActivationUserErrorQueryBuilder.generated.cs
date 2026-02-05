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
    public sealed class InventoryBulkToggleActivationUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryBulkToggleActivationUserError, InventoryBulkToggleActivationUserErrorQueryBuilder>
    {
        protected override InventoryBulkToggleActivationUserErrorQueryBuilder Self => this;

        public InventoryBulkToggleActivationUserErrorQueryBuilder() : this("inventoryBulkToggleActivationUserError")
        {
        }

        public InventoryBulkToggleActivationUserErrorQueryBuilder(string name) : base(new Query<InventoryBulkToggleActivationUserError>(name))
        {
        }

        public InventoryBulkToggleActivationUserErrorQueryBuilder(IQuery<InventoryBulkToggleActivationUserError> query) : base(query)
        {
        }

        public InventoryBulkToggleActivationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryBulkToggleActivationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryBulkToggleActivationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}