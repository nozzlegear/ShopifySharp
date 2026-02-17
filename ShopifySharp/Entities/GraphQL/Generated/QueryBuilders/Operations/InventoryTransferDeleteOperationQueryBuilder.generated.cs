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
    public sealed class InventoryTransferDeleteOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferDeletePayload, InventoryTransferDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferDeleteArgumentsBuilder Arguments { get; }
        protected override InventoryTransferDeleteOperationQueryBuilder Self => this;

        public InventoryTransferDeleteOperationQueryBuilder() : this("inventoryTransferDelete")
        {
        }

        public InventoryTransferDeleteOperationQueryBuilder(string name) : base(new Query<InventoryTransferDeletePayload>(name))
        {
            Arguments = new InventoryTransferDeleteArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferDeleteOperationQueryBuilder(IQuery<InventoryTransferDeletePayload> query) : base(query)
        {
            Arguments = new InventoryTransferDeleteArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public InventoryTransferDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferDeleteUserError>(query);
            return this;
        }
    }
}