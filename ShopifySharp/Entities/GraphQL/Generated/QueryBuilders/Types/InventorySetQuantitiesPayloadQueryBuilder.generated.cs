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
    public sealed class InventorySetQuantitiesPayloadQueryBuilder : FieldsQueryBuilderBase<InventorySetQuantitiesPayload, InventorySetQuantitiesPayloadQueryBuilder>
    {
        protected override InventorySetQuantitiesPayloadQueryBuilder Self => this;

        public InventorySetQuantitiesPayloadQueryBuilder() : this("inventorySetQuantitiesPayload")
        {
        }

        public InventorySetQuantitiesPayloadQueryBuilder(string name) : base(new Query<InventorySetQuantitiesPayload>(name))
        {
        }

        public InventorySetQuantitiesPayloadQueryBuilder(IQuery<InventorySetQuantitiesPayload> query) : base(query)
        {
        }

        public InventorySetQuantitiesPayloadQueryBuilder InventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("inventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustmentGroup>(query);
            return this;
        }

        public InventorySetQuantitiesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventorySetQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventorySetQuantitiesUserError>(query);
            return this;
        }
    }
}