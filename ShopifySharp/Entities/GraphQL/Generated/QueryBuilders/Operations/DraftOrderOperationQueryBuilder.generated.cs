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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DraftOrderOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrder, DraftOrderOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DraftOrderArgumentsBuilder Arguments { get; }
        protected override DraftOrderOperationQueryBuilder Self => this;

        public DraftOrderOperationQueryBuilder() : this("draftOrder")
        {
        }

        public DraftOrderOperationQueryBuilder(string name) : base(new Query<DraftOrder>(name))
        {
            Arguments = new DraftOrderArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderOperationQueryBuilder(IQuery<DraftOrder> query) : base(query)
        {
            Arguments = new DraftOrderArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderOperationQueryBuilder AcceptAutomaticDiscounts()
        {
            base.InnerQuery.AddField("acceptAutomaticDiscounts");
            return this;
        }

        public DraftOrderOperationQueryBuilder AllowDiscountCodesInCheckout()
        {
            base.InnerQuery.AddField("allowDiscountCodesInCheckout");
            return this;
        }

        public DraftOrderOperationQueryBuilder AllVariantPricesOverridden()
        {
            base.InnerQuery.AddField("allVariantPricesOverridden");
            return this;
        }

        public DraftOrderOperationQueryBuilder AnyVariantPricesOverridden()
        {
            base.InnerQuery.AddField("anyVariantPricesOverridden");
            return this;
        }

        public DraftOrderOperationQueryBuilder AppliedDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder> build)
        {
            var query = new Query<DraftOrderAppliedDiscount>("appliedDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderAppliedDiscount>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder BillingAddressMatchesShippingAddress()
        {
            base.InnerQuery.AddField("billingAddressMatchesShippingAddress");
            return this;
        }

        public DraftOrderOperationQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public DraftOrderOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public DraftOrderOperationQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public DraftOrderOperationQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public DraftOrderOperationQueryBuilder DiscountCodes()
        {
            base.InnerQuery.AddField("discountCodes");
            return this;
        }

        public DraftOrderOperationQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public DraftOrderOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public DraftOrderOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DraftOrderOperationQueryBuilder InvoiceEmailTemplateSubject()
        {
            base.InnerQuery.AddField("invoiceEmailTemplateSubject");
            return this;
        }

        public DraftOrderOperationQueryBuilder InvoiceSentAt()
        {
            base.InnerQuery.AddField("invoiceSentAt");
            return this;
        }

        public DraftOrderOperationQueryBuilder InvoiceUrl()
        {
            base.InnerQuery.AddField("invoiceUrl");
            return this;
        }

        public DraftOrderOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public DraftOrderOperationQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItemConnection>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder LineItemsSubtotalPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("lineItemsSubtotalPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder LocalizationExtensions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionConnection>("localizationExtensions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionConnection>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder LocalizedFields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldConnection>("localizedFields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldConnection>(query);
            return this;
        }

        [Obsolete("This field is now incompatible with Markets.")]
        public DraftOrderOperationQueryBuilder MarketName()
        {
            base.InnerQuery.AddField("marketName");
            return this;
        }

        [Obsolete("This field is now incompatible with Markets.")]
        public DraftOrderOperationQueryBuilder MarketRegionCountryCode()
        {
            base.InnerQuery.AddField("marketRegionCountryCode");
            return this;
        }

        public DraftOrderOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DraftOrderOperationQueryBuilder Note2()
        {
            base.InnerQuery.AddField("note2");
            return this;
        }

        public DraftOrderOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public DraftOrderOperationQueryBuilder PlatformDiscounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderPlatformDiscountQueryBuilder> build)
        {
            var query = new Query<DraftOrderPlatformDiscount>("platformDiscounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderPlatformDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderPlatformDiscount>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder PoNumber()
        {
            base.InnerQuery.AddField("poNumber");
            return this;
        }

        public DraftOrderOperationQueryBuilder PresentmentCurrencyCode()
        {
            base.InnerQuery.AddField("presentmentCurrencyCode");
            return this;
        }

        public DraftOrderOperationQueryBuilder Ready()
        {
            base.InnerQuery.AddField("ready");
            return this;
        }

        public DraftOrderOperationQueryBuilder ReserveInventoryUntil()
        {
            base.InnerQuery.AddField("reserveInventoryUntil");
            return this;
        }

        public DraftOrderOperationQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        [Obsolete("Use `subtotalPriceSet` instead.")]
        public DraftOrderOperationQueryBuilder SubtotalPrice()
        {
            base.InnerQuery.AddField("subtotalPrice");
            return this;
        }

        public DraftOrderOperationQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public DraftOrderOperationQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public DraftOrderOperationQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public DraftOrderOperationQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder TotalDiscountsSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder TotalLineItemsPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalLineItemsPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalPriceSet` instead.")]
        public DraftOrderOperationQueryBuilder TotalPrice()
        {
            base.InnerQuery.AddField("totalPrice");
            return this;
        }

        public DraftOrderOperationQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder TotalQuantityOfLineItems()
        {
            base.InnerQuery.AddField("totalQuantityOfLineItems");
            return this;
        }

        [Obsolete("Use `totalShippingPriceSet` instead.")]
        public DraftOrderOperationQueryBuilder TotalShippingPrice()
        {
            base.InnerQuery.AddField("totalShippingPrice");
            return this;
        }

        public DraftOrderOperationQueryBuilder TotalShippingPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public DraftOrderOperationQueryBuilder TotalTax()
        {
            base.InnerQuery.AddField("totalTax");
            return this;
        }

        public DraftOrderOperationQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder TotalWeight()
        {
            base.InnerQuery.AddField("totalWeight");
            return this;
        }

        public DraftOrderOperationQueryBuilder TransformerFingerprint()
        {
            base.InnerQuery.AddField("transformerFingerprint");
            return this;
        }

        public DraftOrderOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public DraftOrderOperationQueryBuilder VisibleToCustomer()
        {
            base.InnerQuery.AddField("visibleToCustomer");
            return this;
        }

        public DraftOrderOperationQueryBuilder Warnings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderWarningQueryBuilder> build)
        {
            var query = new Query<IDraftOrderWarning>("warnings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDraftOrderWarning>(query);
            return this;
        }

        public DraftOrderOperationQueryBuilder PurchasingEntity(Action<PurchasingEntityUnionCasesBuilder> build)
        {
            var query = new Query<PurchasingEntity>("purchasingEntity");
            var unionBuilder = new PurchasingEntityUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}