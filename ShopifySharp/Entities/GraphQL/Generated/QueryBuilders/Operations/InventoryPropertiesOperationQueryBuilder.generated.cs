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

        public InventoryPropertiesOperationQueryBuilder QuantityNames(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityNameQueryBuilder> build)
        {
            var query = new Query<InventoryQuantityName>("quantityNames");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityNameQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryQuantityName>(query);
            return this;
        }
    }
}