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
    public sealed class InventoryDeactivateOperationQueryBuilder : FieldsQueryBuilderBase<InventoryDeactivatePayload, InventoryDeactivateOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryDeactivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryDeactivateArgumentsBuilder Arguments { get; }
        protected override InventoryDeactivateOperationQueryBuilder Self => this;

        public InventoryDeactivateOperationQueryBuilder() : this("inventoryDeactivate")
        {
        }

        public InventoryDeactivateOperationQueryBuilder(string name) : base(new Query<InventoryDeactivatePayload>(name))
        {
            Arguments = new InventoryDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryDeactivateOperationQueryBuilder(IQuery<InventoryDeactivatePayload> query) : base(query)
        {
            Arguments = new InventoryDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public InventoryDeactivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}