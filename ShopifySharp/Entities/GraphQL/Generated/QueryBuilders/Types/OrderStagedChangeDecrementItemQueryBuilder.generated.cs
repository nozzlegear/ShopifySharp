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
    public sealed class OrderStagedChangeDecrementItemQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeDecrementItem, OrderStagedChangeDecrementItemQueryBuilder>
    {
        protected override OrderStagedChangeDecrementItemQueryBuilder Self => this;

        public OrderStagedChangeDecrementItemQueryBuilder() : this("orderStagedChangeDecrementItem")
        {
        }

        public OrderStagedChangeDecrementItemQueryBuilder(string name) : base(new Query<OrderStagedChangeDecrementItem>(name))
        {
        }

        public OrderStagedChangeDecrementItemQueryBuilder(IQuery<OrderStagedChangeDecrementItem> query) : base(query)
        {
        }

        public OrderStagedChangeDecrementItemQueryBuilder Delta()
        {
            base.InnerQuery.AddField("delta");
            return this;
        }

        public OrderStagedChangeDecrementItemQueryBuilder LineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("lineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public OrderStagedChangeDecrementItemQueryBuilder Restock()
        {
            base.InnerQuery.AddField("restock");
            return this;
        }
    }
}