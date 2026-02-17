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
    public sealed class InventoryItemUpdateOperationQueryBuilder : FieldsQueryBuilderBase<InventoryItemUpdatePayload, InventoryItemUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryItemUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryItemUpdateArgumentsBuilder Arguments { get; }
        protected override InventoryItemUpdateOperationQueryBuilder Self => this;

        public InventoryItemUpdateOperationQueryBuilder() : this("inventoryItemUpdate")
        {
        }

        public InventoryItemUpdateOperationQueryBuilder(string name) : base(new Query<InventoryItemUpdatePayload>(name))
        {
            Arguments = new InventoryItemUpdateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryItemUpdateOperationQueryBuilder(IQuery<InventoryItemUpdatePayload> query) : base(query)
        {
            Arguments = new InventoryItemUpdateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryItemUpdateOperationQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryItemUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}