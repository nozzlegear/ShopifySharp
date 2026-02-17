#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class InventoryTransferDuplicateOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferDuplicatePayload, InventoryTransferDuplicateOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferDuplicatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferDuplicateArgumentsBuilder Arguments { get; }
        protected override InventoryTransferDuplicateOperationQueryBuilder Self => this;

        public InventoryTransferDuplicateOperationQueryBuilder() : this("inventoryTransferDuplicate")
        {
        }

        public InventoryTransferDuplicateOperationQueryBuilder(string name) : base(new Query<InventoryTransferDuplicatePayload>(name))
        {
            Arguments = new InventoryTransferDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferDuplicateOperationQueryBuilder(IQuery<InventoryTransferDuplicatePayload> query) : base(query)
        {
            Arguments = new InventoryTransferDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferDuplicateOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferDuplicateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferDuplicateUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferDuplicateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferDuplicateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferDuplicateUserError>(query);
            return this;
        }
    }
}