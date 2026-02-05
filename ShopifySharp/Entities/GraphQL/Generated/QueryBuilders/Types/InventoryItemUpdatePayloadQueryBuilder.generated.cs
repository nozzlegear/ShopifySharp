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
    public sealed class InventoryItemUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<InventoryItemUpdatePayload, InventoryItemUpdatePayloadQueryBuilder>
    {
        protected override InventoryItemUpdatePayloadQueryBuilder Self => this;

        public InventoryItemUpdatePayloadQueryBuilder() : this("inventoryItemUpdatePayload")
        {
        }

        public InventoryItemUpdatePayloadQueryBuilder(string name) : base(new Query<InventoryItemUpdatePayload>(name))
        {
        }

        public InventoryItemUpdatePayloadQueryBuilder(IQuery<InventoryItemUpdatePayload> query) : base(query)
        {
        }

        public InventoryItemUpdatePayloadQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryItemUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}