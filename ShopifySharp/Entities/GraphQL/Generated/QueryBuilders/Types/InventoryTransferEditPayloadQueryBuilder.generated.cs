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
    public sealed class InventoryTransferEditPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryTransferEditPayload, InventoryTransferEditPayloadQueryBuilder>
    {
        protected override InventoryTransferEditPayloadQueryBuilder Self => this;

        public InventoryTransferEditPayloadQueryBuilder() : this("inventoryTransferEditPayload")
        {
        }

        public InventoryTransferEditPayloadQueryBuilder(string name) : base(new Query<InventoryTransferEditPayload>(name))
        {
        }

        public InventoryTransferEditPayloadQueryBuilder(IQuery<InventoryTransferEditPayload> query) : base(query)
        {
        }

        public InventoryTransferEditPayloadQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferEditPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferEditUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferEditUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferEditUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferEditUserError>(query);
            return this;
        }
    }
}