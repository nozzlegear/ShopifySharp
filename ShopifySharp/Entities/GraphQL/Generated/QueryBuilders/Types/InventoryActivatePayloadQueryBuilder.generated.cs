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
    public sealed class InventoryActivatePayloadQueryBuilder : FieldsQueryBuilderBase<InventoryActivatePayload, InventoryActivatePayloadQueryBuilder>
    {
        protected override InventoryActivatePayloadQueryBuilder Self => this;

        public InventoryActivatePayloadQueryBuilder() : this("inventoryActivatePayload")
        {
        }

        public InventoryActivatePayloadQueryBuilder(string name) : base(new Query<InventoryActivatePayload>(name))
        {
        }

        public InventoryActivatePayloadQueryBuilder(IQuery<InventoryActivatePayload> query) : base(query)
        {
        }

        public InventoryActivatePayloadQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryActivatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}