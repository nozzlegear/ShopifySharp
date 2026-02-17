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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class InventoryPropertiesQueryBuilder : FieldsQueryBuilderBase<InventoryProperties, InventoryPropertiesQueryBuilder>
    {
        protected override InventoryPropertiesQueryBuilder Self => this;

        public InventoryPropertiesQueryBuilder() : this("inventoryProperties")
        {
        }

        public InventoryPropertiesQueryBuilder(string name) : base(new Query<InventoryProperties>(name))
        {
        }

        public InventoryPropertiesQueryBuilder(IQuery<InventoryProperties> query) : base(query)
        {
        }

        public InventoryPropertiesQueryBuilder QuantityNames(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityNameQueryBuilder> build)
        {
            var query = new Query<InventoryQuantityName>("quantityNames");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityNameQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryQuantityName>(query);
            return this;
        }
    }
}