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
    public sealed class OrderStagedChangeAddCustomItemQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeAddCustomItem, OrderStagedChangeAddCustomItemQueryBuilder>
    {
        protected override OrderStagedChangeAddCustomItemQueryBuilder Self => this;

        public OrderStagedChangeAddCustomItemQueryBuilder() : this("orderStagedChangeAddCustomItem")
        {
        }

        public OrderStagedChangeAddCustomItemQueryBuilder(string name) : base(new Query<OrderStagedChangeAddCustomItem>(name))
        {
        }

        public OrderStagedChangeAddCustomItemQueryBuilder(IQuery<OrderStagedChangeAddCustomItem> query) : base(query)
        {
        }

        public OrderStagedChangeAddCustomItemQueryBuilder OriginalUnitPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalUnitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public OrderStagedChangeAddCustomItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public OrderStagedChangeAddCustomItemQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}