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
    public sealed class OrderAdjustmentQueryBuilder : FieldsQueryBuilderBase<OrderAdjustment, OrderAdjustmentQueryBuilder>
    {
        protected override OrderAdjustmentQueryBuilder Self => this;

        public OrderAdjustmentQueryBuilder() : this("orderAdjustment")
        {
        }

        public OrderAdjustmentQueryBuilder(string name) : base(new Query<OrderAdjustment>(name))
        {
        }

        public OrderAdjustmentQueryBuilder(IQuery<OrderAdjustment> query) : base(query)
        {
        }

        public OrderAdjustmentQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderAdjustmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public OrderAdjustmentQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }

        public OrderAdjustmentQueryBuilder TaxAmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("taxAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}