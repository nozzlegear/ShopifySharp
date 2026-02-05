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
    public sealed class InventoryPropertiesOperationQueryBuilder : FieldsQueryBuilderBase<InventoryProperties, InventoryPropertiesOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryProperties>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override InventoryPropertiesOperationQueryBuilder Self => this;

        public InventoryPropertiesOperationQueryBuilder() : this("inventoryProperties")
        {
        }

        public InventoryPropertiesOperationQueryBuilder(string name) : base(new Query<InventoryProperties>(name))
        {
        }

        public InventoryPropertiesOperationQueryBuilder(IQuery<InventoryProperties> query) : base(query)
        {
        }

        public InventoryPropertiesOperationQueryBuilder QuantityNames(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryQuantityNameQueryBuilder> build)
        {
            var query = new Query<InventoryQuantityName>("quantityNames");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryQuantityNameQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryQuantityName>(query);
            return this;
        }
    }
}