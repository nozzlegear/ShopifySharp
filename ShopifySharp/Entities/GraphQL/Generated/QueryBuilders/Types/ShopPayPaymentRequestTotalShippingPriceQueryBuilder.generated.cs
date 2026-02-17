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
    public sealed class ShopPayPaymentRequestTotalShippingPriceQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestTotalShippingPrice, ShopPayPaymentRequestTotalShippingPriceQueryBuilder>
    {
        protected override ShopPayPaymentRequestTotalShippingPriceQueryBuilder Self => this;

        public ShopPayPaymentRequestTotalShippingPriceQueryBuilder() : this("shopPayPaymentRequestTotalShippingPrice")
        {
        }

        public ShopPayPaymentRequestTotalShippingPriceQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestTotalShippingPrice>(name))
        {
        }

        public ShopPayPaymentRequestTotalShippingPriceQueryBuilder(IQuery<ShopPayPaymentRequestTotalShippingPrice> query) : base(query)
        {
        }

        public ShopPayPaymentRequestTotalShippingPriceQueryBuilder Discounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestDiscountQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestDiscount>("discounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestDiscount>(query);
            return this;
        }

        public ShopPayPaymentRequestTotalShippingPriceQueryBuilder FinalTotal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("finalTotal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopPayPaymentRequestTotalShippingPriceQueryBuilder OriginalTotal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalTotal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}