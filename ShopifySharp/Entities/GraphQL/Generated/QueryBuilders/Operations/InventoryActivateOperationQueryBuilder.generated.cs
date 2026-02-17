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
    public sealed class InventoryActivateOperationQueryBuilder : FieldsQueryBuilderBase<InventoryActivatePayload, InventoryActivateOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryActivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryActivateArgumentsBuilder Arguments { get; }
        protected override InventoryActivateOperationQueryBuilder Self => this;

        public InventoryActivateOperationQueryBuilder() : this("inventoryActivate")
        {
        }

        public InventoryActivateOperationQueryBuilder(string name) : base(new Query<InventoryActivatePayload>(name))
        {
            Arguments = new InventoryActivateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryActivateOperationQueryBuilder(IQuery<InventoryActivatePayload> query) : base(query)
        {
            Arguments = new InventoryActivateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryActivateOperationQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryActivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}