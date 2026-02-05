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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
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

        public InventoryPropertiesQueryBuilder QuantityNames(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryQuantityNameQueryBuilder> build)
        {
            var query = new Query<InventoryQuantityName>("quantityNames");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryQuantityNameQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryQuantityName>(query);
            return this;
        }
    }
}