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
    public sealed class ShopPayPaymentRequestQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequest, ShopPayPaymentRequestQueryBuilder>
    {
        protected override ShopPayPaymentRequestQueryBuilder Self => this;

        public ShopPayPaymentRequestQueryBuilder() : this("shopPayPaymentRequest")
        {
        }

        public ShopPayPaymentRequestQueryBuilder(string name) : base(new Query<ShopPayPaymentRequest>(name))
        {
        }

        public ShopPayPaymentRequestQueryBuilder(IQuery<ShopPayPaymentRequest> query) : base(query)
        {
        }

        public ShopPayPaymentRequestQueryBuilder Discounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestDiscountQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestDiscount>("discounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestDiscount>(query);
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestLineItemQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestLineItem>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestLineItem>(query);
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder PresentmentCurrency()
        {
            base.InnerQuery.AddField("presentmentCurrency");
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder SelectedDeliveryMethodType()
        {
            base.InnerQuery.AddField("selectedDeliveryMethodType");
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestContactFieldQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestContactField>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestContactFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestContactField>(query);
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder ShippingLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestShippingLineQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestShippingLine>("shippingLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestShippingLine>(query);
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder Subtotal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("subtotal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder Total(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("total");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder TotalShippingPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestTotalShippingPriceQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestTotalShippingPrice>("totalShippingPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestTotalShippingPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestTotalShippingPrice>(query);
            return this;
        }

        public ShopPayPaymentRequestQueryBuilder TotalTax(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalTax");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}