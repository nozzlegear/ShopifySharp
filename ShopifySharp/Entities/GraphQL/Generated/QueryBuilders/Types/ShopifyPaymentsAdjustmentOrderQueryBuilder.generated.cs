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
    public sealed class ShopifyPaymentsAdjustmentOrderQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsAdjustmentOrder, ShopifyPaymentsAdjustmentOrderQueryBuilder>
    {
        protected override ShopifyPaymentsAdjustmentOrderQueryBuilder Self => this;

        public ShopifyPaymentsAdjustmentOrderQueryBuilder() : this("shopifyPaymentsAdjustmentOrder")
        {
        }

        public ShopifyPaymentsAdjustmentOrderQueryBuilder(string name) : base(new Query<ShopifyPaymentsAdjustmentOrder>(name))
        {
        }

        public ShopifyPaymentsAdjustmentOrderQueryBuilder(IQuery<ShopifyPaymentsAdjustmentOrder> query) : base(query)
        {
        }

        public ShopifyPaymentsAdjustmentOrderQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsAdjustmentOrderQueryBuilder Fees(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("fees");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsAdjustmentOrderQueryBuilder Link()
        {
            base.InnerQuery.AddField("link");
            return this;
        }

        public ShopifyPaymentsAdjustmentOrderQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ShopifyPaymentsAdjustmentOrderQueryBuilder Net(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("net");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsAdjustmentOrderQueryBuilder OrderTransactionId()
        {
            base.InnerQuery.AddField("orderTransactionId");
            return this;
        }
    }
}