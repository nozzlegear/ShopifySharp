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
    public sealed class InventoryTransferDuplicatePayloadQueryBuilder : FieldsQueryBuilderBase<InventoryTransferDuplicatePayload, InventoryTransferDuplicatePayloadQueryBuilder>
    {
        protected override InventoryTransferDuplicatePayloadQueryBuilder Self => this;

        public InventoryTransferDuplicatePayloadQueryBuilder() : this("inventoryTransferDuplicatePayload")
        {
        }

        public InventoryTransferDuplicatePayloadQueryBuilder(string name) : base(new Query<InventoryTransferDuplicatePayload>(name))
        {
        }

        public InventoryTransferDuplicatePayloadQueryBuilder(IQuery<InventoryTransferDuplicatePayload> query) : base(query)
        {
        }

        public InventoryTransferDuplicatePayloadQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferDuplicatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferDuplicateUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferDuplicateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferDuplicateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferDuplicateUserError>(query);
            return this;
        }
    }
}