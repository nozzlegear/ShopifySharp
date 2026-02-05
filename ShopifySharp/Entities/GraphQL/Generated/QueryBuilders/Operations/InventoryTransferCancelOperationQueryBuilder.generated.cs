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
    public sealed class InventoryTransferCancelOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferCancelPayload, InventoryTransferCancelOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferCancelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferCancelArgumentsBuilder Arguments { get; }
        protected override InventoryTransferCancelOperationQueryBuilder Self => this;

        public InventoryTransferCancelOperationQueryBuilder() : this("inventoryTransferCancel")
        {
        }

        public InventoryTransferCancelOperationQueryBuilder(string name) : base(new Query<InventoryTransferCancelPayload>(name))
        {
            Arguments = new InventoryTransferCancelArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferCancelOperationQueryBuilder(IQuery<InventoryTransferCancelPayload> query) : base(query)
        {
            Arguments = new InventoryTransferCancelArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferCancelOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCancelUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferCancelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferCancelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferCancelUserError>(query);
            return this;
        }
    }
}