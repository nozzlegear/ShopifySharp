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
    public sealed class InventoryAdjustQuantitiesPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryAdjustQuantitiesPayload, InventoryAdjustQuantitiesPayloadQueryBuilder>
    {
        protected override InventoryAdjustQuantitiesPayloadQueryBuilder Self => this;

        public InventoryAdjustQuantitiesPayloadQueryBuilder() : this("inventoryAdjustQuantitiesPayload")
        {
        }

        public InventoryAdjustQuantitiesPayloadQueryBuilder(string name) : base(new Query<InventoryAdjustQuantitiesPayload>(name))
        {
        }

        public InventoryAdjustQuantitiesPayloadQueryBuilder(IQuery<InventoryAdjustQuantitiesPayload> query) : base(query)
        {
        }

        public InventoryAdjustQuantitiesPayloadQueryBuilder InventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("inventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustmentGroup>(query);
            return this;
        }

        public InventoryAdjustQuantitiesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustQuantitiesUserError>(query);
            return this;
        }
    }
}