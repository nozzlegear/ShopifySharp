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
    public sealed class InventoryAdjustQuantitiesUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryAdjustQuantitiesUserError, InventoryAdjustQuantitiesUserErrorQueryBuilder>
    {
        protected override InventoryAdjustQuantitiesUserErrorQueryBuilder Self => this;

        public InventoryAdjustQuantitiesUserErrorQueryBuilder() : this("inventoryAdjustQuantitiesUserError")
        {
        }

        public InventoryAdjustQuantitiesUserErrorQueryBuilder(string name) : base(new Query<InventoryAdjustQuantitiesUserError>(name))
        {
        }

        public InventoryAdjustQuantitiesUserErrorQueryBuilder(IQuery<InventoryAdjustQuantitiesUserError> query) : base(query)
        {
        }

        public InventoryAdjustQuantitiesUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryAdjustQuantitiesUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryAdjustQuantitiesUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}