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
    public sealed class InventoryTransferCreatePayloadQueryBuilder : FieldsQueryBuilderBase<InventoryTransferCreatePayload, InventoryTransferCreatePayloadQueryBuilder>
    {
        protected override InventoryTransferCreatePayloadQueryBuilder Self => this;

        public InventoryTransferCreatePayloadQueryBuilder() : this("inventoryTransferCreatePayload")
        {
        }

        public InventoryTransferCreatePayloadQueryBuilder(string name) : base(new Query<InventoryTransferCreatePayload>(name))
        {
        }

        public InventoryTransferCreatePayloadQueryBuilder(IQuery<InventoryTransferCreatePayload> query) : base(query)
        {
        }

        public InventoryTransferCreatePayloadQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferCreateUserError>(query);
            return this;
        }
    }
}