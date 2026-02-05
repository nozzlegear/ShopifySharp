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
    public sealed class InventoryTransferDeletePayloadQueryBuilder : FieldsQueryBuilderBase<InventoryTransferDeletePayload, InventoryTransferDeletePayloadQueryBuilder>
    {
        protected override InventoryTransferDeletePayloadQueryBuilder Self => this;

        public InventoryTransferDeletePayloadQueryBuilder() : this("inventoryTransferDeletePayload")
        {
        }

        public InventoryTransferDeletePayloadQueryBuilder(string name) : base(new Query<InventoryTransferDeletePayload>(name))
        {
        }

        public InventoryTransferDeletePayloadQueryBuilder(IQuery<InventoryTransferDeletePayload> query) : base(query)
        {
        }

        public InventoryTransferDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public InventoryTransferDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferDeleteUserError>(query);
            return this;
        }
    }
}