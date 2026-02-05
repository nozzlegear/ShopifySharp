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
    public sealed class InventoryDeactivatePayloadQueryBuilder : FieldsQueryBuilderBase<InventoryDeactivatePayload, InventoryDeactivatePayloadQueryBuilder>
    {
        protected override InventoryDeactivatePayloadQueryBuilder Self => this;

        public InventoryDeactivatePayloadQueryBuilder() : this("inventoryDeactivatePayload")
        {
        }

        public InventoryDeactivatePayloadQueryBuilder(string name) : base(new Query<InventoryDeactivatePayload>(name))
        {
        }

        public InventoryDeactivatePayloadQueryBuilder(IQuery<InventoryDeactivatePayload> query) : base(query)
        {
        }

        public InventoryDeactivatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}