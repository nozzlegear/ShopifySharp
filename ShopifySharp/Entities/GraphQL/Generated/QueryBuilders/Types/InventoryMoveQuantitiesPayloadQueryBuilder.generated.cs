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
    public sealed class InventoryMoveQuantitiesPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryMoveQuantitiesPayload, InventoryMoveQuantitiesPayloadQueryBuilder>
    {
        protected override InventoryMoveQuantitiesPayloadQueryBuilder Self => this;

        public InventoryMoveQuantitiesPayloadQueryBuilder() : this("inventoryMoveQuantitiesPayload")
        {
        }

        public InventoryMoveQuantitiesPayloadQueryBuilder(string name) : base(new Query<InventoryMoveQuantitiesPayload>(name))
        {
        }

        public InventoryMoveQuantitiesPayloadQueryBuilder(IQuery<InventoryMoveQuantitiesPayload> query) : base(query)
        {
        }

        public InventoryMoveQuantitiesPayloadQueryBuilder InventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("inventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustmentGroup>(query);
            return this;
        }

        public InventoryMoveQuantitiesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryMoveQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryMoveQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryMoveQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryMoveQuantitiesUserError>(query);
            return this;
        }
    }
}