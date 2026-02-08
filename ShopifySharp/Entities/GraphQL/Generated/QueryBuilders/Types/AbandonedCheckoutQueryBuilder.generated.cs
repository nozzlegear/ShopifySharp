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
    public sealed class AbandonedCheckoutQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckout, AbandonedCheckoutQueryBuilder>
    {
        protected override AbandonedCheckoutQueryBuilder Self => this;

        public AbandonedCheckoutQueryBuilder() : this("abandonedCheckout")
        {
        }

        public AbandonedCheckoutQueryBuilder(string name) : base(new Query<AbandonedCheckout>(name))
        {
        }

        public AbandonedCheckoutQueryBuilder(IQuery<AbandonedCheckout> query) : base(query)
        {
        }

        public AbandonedCheckoutQueryBuilder AbandonedCheckoutUrl()
        {
            base.InnerQuery.AddField("abandonedCheckoutUrl");
            return this;
        }

        public AbandonedCheckoutQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public AbandonedCheckoutQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AbandonedCheckoutQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public AbandonedCheckoutQueryBuilder DiscountCodes()
        {
            base.InnerQuery.AddField("discountCodes");
            return this;
        }

        public AbandonedCheckoutQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AbandonedCheckoutQueryBuilder LineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItemConnection>(query);
            return this;
        }

        [Obsolete("Use [AbandonedCheckoutLineItem.quantity](https://shopify.dev/api/admin-graphql/unstable/objects/AbandonedCheckoutLineItem#field-quantity) instead.")]
        public AbandonedCheckoutQueryBuilder LineItemsQuantity()
        {
            base.InnerQuery.AddField("lineItemsQuantity");
            return this;
        }

        public AbandonedCheckoutQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public AbandonedCheckoutQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public AbandonedCheckoutQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public AbandonedCheckoutQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder TotalDiscountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder TotalDutiesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder TotalLineItemsPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalLineItemsPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}