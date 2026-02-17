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
    public sealed class ShippingRefundQueryBuilder : FieldsQueryBuilderBase<ShippingRefund, ShippingRefundQueryBuilder>
    {
        protected override ShippingRefundQueryBuilder Self => this;

        public ShippingRefundQueryBuilder() : this("shippingRefund")
        {
        }

        public ShippingRefundQueryBuilder(string name) : base(new Query<ShippingRefund>(name))
        {
        }

        public ShippingRefundQueryBuilder(IQuery<ShippingRefund> query) : base(query)
        {
        }

        [Obsolete("Use `amountSet` instead.")]
        public ShippingRefundQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public ShippingRefundQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `maximumRefundableSet` instead.")]
        public ShippingRefundQueryBuilder MaximumRefundable()
        {
            base.InnerQuery.AddField("maximumRefundable");
            return this;
        }

        public ShippingRefundQueryBuilder MaximumRefundableSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundableSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `taxSet` instead.")]
        public ShippingRefundQueryBuilder Tax()
        {
            base.InnerQuery.AddField("tax");
            return this;
        }

        public ShippingRefundQueryBuilder TaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("taxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}