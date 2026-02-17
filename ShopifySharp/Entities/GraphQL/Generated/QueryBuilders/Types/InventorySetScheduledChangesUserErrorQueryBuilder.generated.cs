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
    public sealed class InventorySetScheduledChangesUserErrorQueryBuilder : FieldsQueryBuilderBase<InventorySetScheduledChangesUserError, InventorySetScheduledChangesUserErrorQueryBuilder>
    {
        protected override InventorySetScheduledChangesUserErrorQueryBuilder Self => this;

        public InventorySetScheduledChangesUserErrorQueryBuilder() : this("inventorySetScheduledChangesUserError")
        {
        }

        public InventorySetScheduledChangesUserErrorQueryBuilder(string name) : base(new Query<InventorySetScheduledChangesUserError>(name))
        {
        }

        public InventorySetScheduledChangesUserErrorQueryBuilder(IQuery<InventorySetScheduledChangesUserError> query) : base(query)
        {
        }

        public InventorySetScheduledChangesUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventorySetScheduledChangesUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventorySetScheduledChangesUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}