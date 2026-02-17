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
    public sealed class CalculatedDraftOrderQueryBuilder : FieldsQueryBuilderBase<CalculatedDraftOrder, CalculatedDraftOrderQueryBuilder>
    {
        protected override CalculatedDraftOrderQueryBuilder Self => this;

        public CalculatedDraftOrderQueryBuilder() : this("calculatedDraftOrder")
        {
        }

        public CalculatedDraftOrderQueryBuilder(string name) : base(new Query<CalculatedDraftOrder>(name))
        {
        }

        public CalculatedDraftOrderQueryBuilder(IQuery<CalculatedDraftOrder> query) : base(query)
        {
        }

        public CalculatedDraftOrderQueryBuilder AcceptAutomaticDiscounts()
        {
            base.InnerQuery.AddField("acceptAutomaticDiscounts");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder Alerts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourceAlertQueryBuilder> build)
        {
            var query = new Query<ResourceAlert>("alerts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourceAlertQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceAlert>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder AllVariantPricesOverridden()
        {
            base.InnerQuery.AddField("allVariantPricesOverridden");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder AnyVariantPricesOverridden()
        {
            base.InnerQuery.AddField("anyVariantPricesOverridden");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder AppliedDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder> build)
        {
            var query = new Query<DraftOrderAppliedDiscount>("appliedDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderAppliedDiscount>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder AvailableShippingRates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRateQueryBuilder> build)
        {
            var query = new Query<ShippingRate>("availableShippingRates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingRate>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder BillingAddressMatchesShippingAddress()
        {
            base.InnerQuery.AddField("billingAddressMatchesShippingAddress");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder DiscountCodes()
        {
            base.InnerQuery.AddField("discountCodes");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedDraftOrderLineItem>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDraftOrderLineItem>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder LineItemsSubtotalPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("lineItemsSubtotalPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("This field is now incompatible with Markets.")]
        public CalculatedDraftOrderQueryBuilder MarketName()
        {
            base.InnerQuery.AddField("marketName");
            return this;
        }

        [Obsolete("This field is now incompatible with Markets.")]
        public CalculatedDraftOrderQueryBuilder MarketRegionCountryCode()
        {
            base.InnerQuery.AddField("marketRegionCountryCode");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder PlatformDiscounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderPlatformDiscountQueryBuilder> build)
        {
            var query = new Query<DraftOrderPlatformDiscount>("platformDiscounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderPlatformDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderPlatformDiscount>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder PresentmentCurrencyCode()
        {
            base.InnerQuery.AddField("presentmentCurrencyCode");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        [Obsolete("Use `subtotalPriceSet` instead.")]
        public CalculatedDraftOrderQueryBuilder SubtotalPrice()
        {
            base.InnerQuery.AddField("subtotalPrice");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TotalDiscountsSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TotalLineItemsPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalLineItemsPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalPriceSet` instead.")]
        public CalculatedDraftOrderQueryBuilder TotalPrice()
        {
            base.InnerQuery.AddField("totalPrice");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TotalQuantityOfLineItems()
        {
            base.InnerQuery.AddField("totalQuantityOfLineItems");
            return this;
        }

        [Obsolete("Use `totalShippingPriceSet` instead.")]
        public CalculatedDraftOrderQueryBuilder TotalShippingPrice()
        {
            base.InnerQuery.AddField("totalShippingPrice");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TotalShippingPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public CalculatedDraftOrderQueryBuilder TotalTax()
        {
            base.InnerQuery.AddField("totalTax");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder TransformerFingerprint()
        {
            base.InnerQuery.AddField("transformerFingerprint");
            return this;
        }

        public CalculatedDraftOrderQueryBuilder Warnings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderWarningQueryBuilder> build)
        {
            var query = new Query<IDraftOrderWarning>("warnings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDraftOrderWarning>(query);
            return this;
        }

        public CalculatedDraftOrderQueryBuilder PurchasingEntity(Action<PurchasingEntityUnionCasesBuilder> build)
        {
            var query = new Query<PurchasingEntity>("purchasingEntity");
            var unionBuilder = new PurchasingEntityUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}