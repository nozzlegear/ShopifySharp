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
    public sealed class InventoryBulkToggleActivationPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryBulkToggleActivationPayload, InventoryBulkToggleActivationPayloadQueryBuilder>
    {
        protected override InventoryBulkToggleActivationPayloadQueryBuilder Self => this;

        public InventoryBulkToggleActivationPayloadQueryBuilder() : this("inventoryBulkToggleActivationPayload")
        {
        }

        public InventoryBulkToggleActivationPayloadQueryBuilder(string name) : base(new Query<InventoryBulkToggleActivationPayload>(name))
        {
        }

        public InventoryBulkToggleActivationPayloadQueryBuilder(IQuery<InventoryBulkToggleActivationPayload> query) : base(query)
        {
        }

        public InventoryBulkToggleActivationPayloadQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryBulkToggleActivationPayloadQueryBuilder InventoryLevels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryBulkToggleActivationPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryBulkToggleActivationUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryBulkToggleActivationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryBulkToggleActivationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryBulkToggleActivationUserError>(query);
            return this;
        }
    }
}