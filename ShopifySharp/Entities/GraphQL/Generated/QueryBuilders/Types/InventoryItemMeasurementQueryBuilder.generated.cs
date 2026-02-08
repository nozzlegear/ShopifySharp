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
    public sealed class InventoryItemMeasurementQueryBuilder : FieldsQueryBuilderBase<InventoryItemMeasurement, InventoryItemMeasurementQueryBuilder>
    {
        protected override InventoryItemMeasurementQueryBuilder Self => this;

        public InventoryItemMeasurementQueryBuilder() : this("inventoryItemMeasurement")
        {
        }

        public InventoryItemMeasurementQueryBuilder(string name) : base(new Query<InventoryItemMeasurement>(name))
        {
        }

        public InventoryItemMeasurementQueryBuilder(IQuery<InventoryItemMeasurement> query) : base(query)
        {
        }

        public InventoryItemMeasurementQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryItemMeasurementQueryBuilder Weight(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("weight");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Weight>(query);
            return this;
        }
    }
}