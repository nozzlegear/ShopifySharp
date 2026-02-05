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
    public sealed class ShopPayPaymentRequestLineItemQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestLineItem, ShopPayPaymentRequestLineItemQueryBuilder>
    {
        protected override ShopPayPaymentRequestLineItemQueryBuilder Self => this;

        public ShopPayPaymentRequestLineItemQueryBuilder() : this("shopPayPaymentRequestLineItem")
        {
        }

        public ShopPayPaymentRequestLineItemQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestLineItem>(name))
        {
        }

        public ShopPayPaymentRequestLineItemQueryBuilder(IQuery<ShopPayPaymentRequestLineItem> query) : base(query)
        {
        }

        public ShopPayPaymentRequestLineItemQueryBuilder FinalItemPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("finalItemPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder FinalLinePrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("finalLinePrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestImageQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestImage>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestImage>(query);
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder ItemDiscounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestDiscountQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestDiscount>("itemDiscounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestDiscount>(query);
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder Label()
        {
            base.InnerQuery.AddField("label");
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder LineDiscounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestDiscountQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestDiscount>("lineDiscounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestDiscount>(query);
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder OriginalItemPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalItemPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder OriginalLinePrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalLinePrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public ShopPayPaymentRequestLineItemQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }
    }
}