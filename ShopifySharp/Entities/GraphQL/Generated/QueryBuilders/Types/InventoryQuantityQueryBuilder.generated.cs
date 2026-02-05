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
    public sealed class InventoryQuantityQueryBuilder : FieldsQueryBuilderBase<InventoryQuantity, InventoryQuantityQueryBuilder>
    {
        protected override InventoryQuantityQueryBuilder Self => this;

        public InventoryQuantityQueryBuilder() : this("inventoryQuantity")
        {
        }

        public InventoryQuantityQueryBuilder(string name) : base(new Query<InventoryQuantity>(name))
        {
        }

        public InventoryQuantityQueryBuilder(IQuery<InventoryQuantity> query) : base(query)
        {
        }

        public InventoryQuantityQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryQuantityQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public InventoryQuantityQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public InventoryQuantityQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}