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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class InventoryTransferCreateOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferCreatePayload, InventoryTransferCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferCreateArgumentsBuilder Arguments { get; }
        protected override InventoryTransferCreateOperationQueryBuilder Self => this;

        public InventoryTransferCreateOperationQueryBuilder() : this("inventoryTransferCreate")
        {
        }

        public InventoryTransferCreateOperationQueryBuilder(string name) : base(new Query<InventoryTransferCreatePayload>(name))
        {
            Arguments = new InventoryTransferCreateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferCreateOperationQueryBuilder(IQuery<InventoryTransferCreatePayload> query) : base(query)
        {
            Arguments = new InventoryTransferCreateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferCreateOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferCreateUserError>(query);
            return this;
        }
    }
}