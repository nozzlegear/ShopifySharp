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
    public sealed class DraftOrderQueryBuilder : FieldsQueryBuilderBase<DraftOrder, DraftOrderQueryBuilder>
    {
        protected override DraftOrderQueryBuilder Self => this;

        public DraftOrderQueryBuilder() : this("draftOrder")
        {
        }

        public DraftOrderQueryBuilder(string name) : base(new Query<DraftOrder>(name))
        {
        }

        public DraftOrderQueryBuilder(IQuery<DraftOrder> query) : base(query)
        {
        }

        public DraftOrderQueryBuilder AcceptAutomaticDiscounts()
        {
            base.InnerQuery.AddField("acceptAutomaticDiscounts");
            return this;
        }

        public DraftOrderQueryBuilder AllowDiscountCodesInCheckout()
        {
            base.InnerQuery.AddField("allowDiscountCodesInCheckout");
            return this;
        }

        public DraftOrderQueryBuilder AllVariantPricesOverridden()
        {
            base.InnerQuery.AddField("allVariantPricesOverridden");
            return this;
        }

        public DraftOrderQueryBuilder AnyVariantPricesOverridden()
        {
            base.InnerQuery.AddField("anyVariantPricesOverridden");
            return this;
        }

        public DraftOrderQueryBuilder AppliedDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder> build)
        {
            var query = new Query<DraftOrderAppliedDiscount>("appliedDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderAppliedDiscount>(query);
            return this;
        }

        public DraftOrderQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public DraftOrderQueryBuilder BillingAddressMatchesShippingAddress()
        {
            base.InnerQuery.AddField("billingAddressMatchesShippingAddress");
            return this;
        }

        public DraftOrderQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public DraftOrderQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public DraftOrderQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public DraftOrderQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public DraftOrderQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public DraftOrderQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public DraftOrderQueryBuilder DiscountCodes()
        {
            base.InnerQuery.AddField("discountCodes");
            return this;
        }

        public DraftOrderQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public DraftOrderQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public DraftOrderQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public DraftOrderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DraftOrderQueryBuilder InvoiceEmailTemplateSubject()
        {
            base.InnerQuery.AddField("invoiceEmailTemplateSubject");
            return this;
        }

        public DraftOrderQueryBuilder InvoiceSentAt()
        {
            base.InnerQuery.AddField("invoiceSentAt");
            return this;
        }

        public DraftOrderQueryBuilder InvoiceUrl()
        {
            base.InnerQuery.AddField("invoiceUrl");
            return this;
        }

        public DraftOrderQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public DraftOrderQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItemConnection>(query);
            return this;
        }

        public DraftOrderQueryBuilder LineItemsSubtotalPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("lineItemsSubtotalPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderQueryBuilder LocalizationExtensions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionConnection>("localizationExtensions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionConnection>(query);
            return this;
        }

        public DraftOrderQueryBuilder LocalizedFields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldConnection>("localizedFields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldConnection>(query);
            return this;
        }

        [Obsolete("This field is now incompatible with Markets.")]
        public DraftOrderQueryBuilder MarketName()
        {
            base.InnerQuery.AddField("marketName");
            return this;
        }

        [Obsolete("This field is now incompatible with Markets.")]
        public DraftOrderQueryBuilder MarketRegionCountryCode()
        {
            base.InnerQuery.AddField("marketRegionCountryCode");
            return this;
        }

        public DraftOrderQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public DraftOrderQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public DraftOrderQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DraftOrderQueryBuilder Note2()
        {
            base.InnerQuery.AddField("note2");
            return this;
        }

        public DraftOrderQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public DraftOrderQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public DraftOrderQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public DraftOrderQueryBuilder PlatformDiscounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderPlatformDiscountQueryBuilder> build)
        {
            var query = new Query<DraftOrderPlatformDiscount>("platformDiscounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderPlatformDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderPlatformDiscount>(query);
            return this;
        }

        public DraftOrderQueryBuilder PoNumber()
        {
            base.InnerQuery.AddField("poNumber");
            return this;
        }

        public DraftOrderQueryBuilder PresentmentCurrencyCode()
        {
            base.InnerQuery.AddField("presentmentCurrencyCode");
            return this;
        }

        public DraftOrderQueryBuilder Ready()
        {
            base.InnerQuery.AddField("ready");
            return this;
        }

        public DraftOrderQueryBuilder ReserveInventoryUntil()
        {
            base.InnerQuery.AddField("reserveInventoryUntil");
            return this;
        }

        public DraftOrderQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public DraftOrderQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public DraftOrderQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        [Obsolete("Use `subtotalPriceSet` instead.")]
        public DraftOrderQueryBuilder SubtotalPrice()
        {
            base.InnerQuery.AddField("subtotalPrice");
            return this;
        }

        public DraftOrderQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public DraftOrderQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public DraftOrderQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public DraftOrderQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public DraftOrderQueryBuilder TotalDiscountsSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderQueryBuilder TotalLineItemsPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalLineItemsPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalPriceSet` instead.")]
        public DraftOrderQueryBuilder TotalPrice()
        {
            base.InnerQuery.AddField("totalPrice");
            return this;
        }

        public DraftOrderQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderQueryBuilder TotalQuantityOfLineItems()
        {
            base.InnerQuery.AddField("totalQuantityOfLineItems");
            return this;
        }

        [Obsolete("Use `totalShippingPriceSet` instead.")]
        public DraftOrderQueryBuilder TotalShippingPrice()
        {
            base.InnerQuery.AddField("totalShippingPrice");
            return this;
        }

        public DraftOrderQueryBuilder TotalShippingPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public DraftOrderQueryBuilder TotalTax()
        {
            base.InnerQuery.AddField("totalTax");
            return this;
        }

        public DraftOrderQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderQueryBuilder TotalWeight()
        {
            base.InnerQuery.AddField("totalWeight");
            return this;
        }

        public DraftOrderQueryBuilder TransformerFingerprint()
        {
            base.InnerQuery.AddField("transformerFingerprint");
            return this;
        }

        public DraftOrderQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public DraftOrderQueryBuilder VisibleToCustomer()
        {
            base.InnerQuery.AddField("visibleToCustomer");
            return this;
        }

        public DraftOrderQueryBuilder Warnings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderWarningQueryBuilder> build)
        {
            var query = new Query<IDraftOrderWarning>("warnings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDraftOrderWarning>(query);
            return this;
        }

        public DraftOrderQueryBuilder PurchasingEntity(Action<PurchasingEntityUnionCasesBuilder> build)
        {
            var query = new Query<PurchasingEntity>("purchasingEntity");
            var unionBuilder = new PurchasingEntityUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}