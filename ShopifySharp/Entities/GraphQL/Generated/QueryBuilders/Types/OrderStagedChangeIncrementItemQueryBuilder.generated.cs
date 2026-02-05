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
    public sealed class OrderStagedChangeIncrementItemQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeIncrementItem, OrderStagedChangeIncrementItemQueryBuilder>
    {
        protected override OrderStagedChangeIncrementItemQueryBuilder Self => this;

        public OrderStagedChangeIncrementItemQueryBuilder() : this("orderStagedChangeIncrementItem")
        {
        }

        public OrderStagedChangeIncrementItemQueryBuilder(string name) : base(new Query<OrderStagedChangeIncrementItem>(name))
        {
        }

        public OrderStagedChangeIncrementItemQueryBuilder(IQuery<OrderStagedChangeIncrementItem> query) : base(query)
        {
        }

        public OrderStagedChangeIncrementItemQueryBuilder Delta()
        {
            base.InnerQuery.AddField("delta");
            return this;
        }

        public OrderStagedChangeIncrementItemQueryBuilder LineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("lineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }
    }
}