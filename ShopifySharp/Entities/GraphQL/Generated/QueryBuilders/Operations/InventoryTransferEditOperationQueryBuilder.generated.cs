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
    public sealed class InventoryTransferEditOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferEditPayload, InventoryTransferEditOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferEditPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferEditArgumentsBuilder Arguments { get; }
        protected override InventoryTransferEditOperationQueryBuilder Self => this;

        public InventoryTransferEditOperationQueryBuilder() : this("inventoryTransferEdit")
        {
        }

        public InventoryTransferEditOperationQueryBuilder(string name) : base(new Query<InventoryTransferEditPayload>(name))
        {
            Arguments = new InventoryTransferEditArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferEditOperationQueryBuilder(IQuery<InventoryTransferEditPayload> query) : base(query)
        {
            Arguments = new InventoryTransferEditArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferEditOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferEditOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferEditUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferEditUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferEditUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferEditUserError>(query);
            return this;
        }
    }
}