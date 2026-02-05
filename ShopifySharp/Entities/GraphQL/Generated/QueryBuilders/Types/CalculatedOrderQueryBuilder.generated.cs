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
    public sealed class CalculatedOrderQueryBuilder : FieldsQueryBuilderBase<CalculatedOrder, CalculatedOrderQueryBuilder>
    {
        protected override CalculatedOrderQueryBuilder Self => this;

        public CalculatedOrderQueryBuilder() : this("calculatedOrder")
        {
        }

        public CalculatedOrderQueryBuilder(string name) : base(new Query<CalculatedOrder>(name))
        {
        }

        public CalculatedOrderQueryBuilder(IQuery<CalculatedOrder> query) : base(query)
        {
        }

        public CalculatedOrderQueryBuilder AddedDiscountApplications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationConnectionQueryBuilder> build)
        {
            var query = new Query<CalculatedDiscountApplicationConnection>("addedDiscountApplications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDiscountApplicationConnection>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder AddedLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItemConnection>("addedLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItemConnection>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder CartDiscountAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("cartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("CalculatedOrder for committed order edits is being deprecated, and this field will also be removed in a future version.  See [changelog](https://shopify.dev/changelog/deprecation-notice-calculatedorder-for-committed-order-edits) for more details.")]
        public CalculatedOrderQueryBuilder Committed()
        {
            base.InnerQuery.AddField("committed");
            return this;
        }

        public CalculatedOrderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedOrderQueryBuilder LineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItemConnection>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder NotificationPreviewHtml()
        {
            base.InnerQuery.AddField("notificationPreviewHtml");
            return this;
        }

        public CalculatedOrderQueryBuilder NotificationPreviewTitle()
        {
            base.InnerQuery.AddField("notificationPreviewTitle");
            return this;
        }

        public CalculatedOrderQueryBuilder OriginalOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("originalOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder ShippingLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedShippingLineQueryBuilder> build)
        {
            var query = new Query<CalculatedShippingLine>("shippingLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedShippingLine>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder StagedChanges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderStagedChangeConnectionQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeConnection>("stagedChanges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderStagedChangeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderStagedChangeConnection>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder SubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("subtotalLineItemsQuantity");
            return this;
        }

        public CalculatedOrderQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder TotalOutstandingSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalOutstandingSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedOrderQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}