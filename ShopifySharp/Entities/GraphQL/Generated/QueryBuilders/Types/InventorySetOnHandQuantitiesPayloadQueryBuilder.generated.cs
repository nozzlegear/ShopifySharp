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
    public sealed class InventorySetOnHandQuantitiesPayloadQueryBuilder : FieldsQueryBuilderBase<InventorySetOnHandQuantitiesPayload, InventorySetOnHandQuantitiesPayloadQueryBuilder>
    {
        protected override InventorySetOnHandQuantitiesPayloadQueryBuilder Self => this;

        public InventorySetOnHandQuantitiesPayloadQueryBuilder() : this("inventorySetOnHandQuantitiesPayload")
        {
        }

        public InventorySetOnHandQuantitiesPayloadQueryBuilder(string name) : base(new Query<InventorySetOnHandQuantitiesPayload>(name))
        {
        }

        public InventorySetOnHandQuantitiesPayloadQueryBuilder(IQuery<InventorySetOnHandQuantitiesPayload> query) : base(query)
        {
        }

        public InventorySetOnHandQuantitiesPayloadQueryBuilder InventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("inventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustmentGroup>(query);
            return this;
        }

        public InventorySetOnHandQuantitiesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetOnHandQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventorySetOnHandQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetOnHandQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventorySetOnHandQuantitiesUserError>(query);
            return this;
        }
    }
}