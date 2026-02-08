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
    public sealed class OrderQueryBuilder : FieldsQueryBuilderBase<Order, OrderQueryBuilder>
    {
        protected override OrderQueryBuilder Self => this;

        public OrderQueryBuilder() : this("order")
        {
        }

        public OrderQueryBuilder(string name) : base(new Query<Order>(name))
        {
        }

        public OrderQueryBuilder(IQuery<Order> query) : base(query)
        {
        }

        public OrderQueryBuilder AdditionalFees(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AdditionalFeeQueryBuilder> build)
        {
            var query = new Query<AdditionalFee>("additionalFees");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AdditionalFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AdditionalFee>(query);
            return this;
        }

        public OrderQueryBuilder Agreements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SalesAgreementConnectionQueryBuilder> build)
        {
            var query = new Query<SalesAgreementConnection>("agreements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SalesAgreementConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SalesAgreementConnection>(query);
            return this;
        }

        public OrderQueryBuilder Alerts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceAlertQueryBuilder> build)
        {
            var query = new Query<ResourceAlert>("alerts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceAlertQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceAlert>(query);
            return this;
        }

        public OrderQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder> build)
        {
            var query = new Query<OrderApp>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderApp>(query);
            return this;
        }

        public OrderQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderQueryBuilder BillingAddressMatchesShippingAddress()
        {
            base.InnerQuery.AddField("billingAddressMatchesShippingAddress");
            return this;
        }

        public OrderQueryBuilder Cancellation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancellationQueryBuilder> build)
        {
            var query = new Query<OrderCancellation>("cancellation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancellationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCancellation>(query);
            return this;
        }

        public OrderQueryBuilder CancelledAt()
        {
            base.InnerQuery.AddField("cancelledAt");
            return this;
        }

        public OrderQueryBuilder CancelReason()
        {
            base.InnerQuery.AddField("cancelReason");
            return this;
        }

        public OrderQueryBuilder CanMarkAsPaid()
        {
            base.InnerQuery.AddField("canMarkAsPaid");
            return this;
        }

        public OrderQueryBuilder CanNotifyCustomer()
        {
            base.InnerQuery.AddField("canNotifyCustomer");
            return this;
        }

        public OrderQueryBuilder Capturable()
        {
            base.InnerQuery.AddField("capturable");
            return this;
        }

        [Obsolete("Use `cartDiscountAmountSet` instead.")]
        public OrderQueryBuilder CartDiscountAmount()
        {
            base.InnerQuery.AddField("cartDiscountAmount");
            return this;
        }

        public OrderQueryBuilder CartDiscountAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("cartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder Channel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public OrderQueryBuilder ChannelInformation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelInformationQueryBuilder> build)
        {
            var query = new Query<ChannelInformation>("channelInformation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelInformationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelInformation>(query);
            return this;
        }

        public OrderQueryBuilder ClientIp()
        {
            base.InnerQuery.AddField("clientIp");
            return this;
        }

        public OrderQueryBuilder Closed()
        {
            base.InnerQuery.AddField("closed");
            return this;
        }

        public OrderQueryBuilder ClosedAt()
        {
            base.InnerQuery.AddField("closedAt");
            return this;
        }

        public OrderQueryBuilder ConfirmationNumber()
        {
            base.InnerQuery.AddField("confirmationNumber");
            return this;
        }

        public OrderQueryBuilder Confirmed()
        {
            base.InnerQuery.AddField("confirmed");
            return this;
        }

        public OrderQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public OrderQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public OrderQueryBuilder CurrentCartDiscountAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentCartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder CurrentShippingPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder CurrentSubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("currentSubtotalLineItemsQuantity");
            return this;
        }

        public OrderQueryBuilder CurrentSubtotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentSubtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder CurrentTaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("currentTaxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public OrderQueryBuilder CurrentTotalAdditionalFeesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalAdditionalFeesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder CurrentTotalDiscountsSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder CurrentTotalDutiesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder CurrentTotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder CurrentTotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder CurrentTotalWeight()
        {
            base.InnerQuery.AddField("currentTotalWeight");
            return this;
        }

        public OrderQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public OrderQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public OrderQueryBuilder CustomerAcceptsMarketing()
        {
            base.InnerQuery.AddField("customerAcceptsMarketing");
            return this;
        }

        public OrderQueryBuilder CustomerJourney(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneyQueryBuilder> build)
        {
            var query = new Query<CustomerJourney>("customerJourney");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerJourney>(query);
            return this;
        }

        public OrderQueryBuilder CustomerJourneySummary(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneySummaryQueryBuilder> build)
        {
            var query = new Query<CustomerJourneySummary>("customerJourneySummary");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneySummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerJourneySummary>(query);
            return this;
        }

        public OrderQueryBuilder CustomerLocale()
        {
            base.InnerQuery.AddField("customerLocale");
            return this;
        }

        public OrderQueryBuilder DiscountApplications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationConnection>("discountApplications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationConnection>(query);
            return this;
        }

        public OrderQueryBuilder DiscountCode()
        {
            base.InnerQuery.AddField("discountCode");
            return this;
        }

        public OrderQueryBuilder DiscountCodes()
        {
            base.InnerQuery.AddField("discountCodes");
            return this;
        }

        public OrderQueryBuilder DisplayAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("displayAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderQueryBuilder DisplayFinancialStatus()
        {
            base.InnerQuery.AddField("displayFinancialStatus");
            return this;
        }

        public OrderQueryBuilder DisplayFulfillmentStatus()
        {
            base.InnerQuery.AddField("displayFulfillmentStatus");
            return this;
        }

        public OrderQueryBuilder Disputes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder> build)
        {
            var query = new Query<OrderDisputeSummary>("disputes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderDisputeSummary>(query);
            return this;
        }

        public OrderQueryBuilder DutiesIncluded()
        {
            base.InnerQuery.AddField("dutiesIncluded");
            return this;
        }

        public OrderQueryBuilder Edited()
        {
            base.InnerQuery.AddField("edited");
            return this;
        }

        public OrderQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public OrderQueryBuilder EstimatedTaxes()
        {
            base.InnerQuery.AddField("estimatedTaxes");
            return this;
        }

        public OrderQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public OrderQueryBuilder ExchangeV2s(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ExchangeV2Connection>("exchangeV2s");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2Connection>(query);
            return this;
        }

        public OrderQueryBuilder Fulfillable()
        {
            base.InnerQuery.AddField("fulfillable");
            return this;
        }

        public OrderQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public OrderQueryBuilder Fulfillments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public OrderQueryBuilder FulfillmentsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("fulfillmentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public OrderQueryBuilder FullyPaid()
        {
            base.InnerQuery.AddField("fullyPaid");
            return this;
        }

        public OrderQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public OrderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.landingPageHtml` instead")]
        public OrderQueryBuilder LandingPageDisplayText()
        {
            base.InnerQuery.AddField("landingPageDisplayText");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.landingPage` instead")]
        public OrderQueryBuilder LandingPageUrl()
        {
            base.InnerQuery.AddField("landingPageUrl");
            return this;
        }

        public OrderQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public OrderQueryBuilder LineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder> build)
        {
            var query = new Query<LineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemConnection>(query);
            return this;
        }

        public OrderQueryBuilder LocalizationExtensions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionConnection>("localizationExtensions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionConnection>(query);
            return this;
        }

        public OrderQueryBuilder LocalizedFields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldConnection>("localizedFields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldConnection>(query);
            return this;
        }

        public OrderQueryBuilder MerchantBusinessEntity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder> build)
        {
            var query = new Query<BusinessEntity>("merchantBusinessEntity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntity>(query);
            return this;
        }

        public OrderQueryBuilder MerchantEditable()
        {
            base.InnerQuery.AddField("merchantEditable");
            return this;
        }

        public OrderQueryBuilder MerchantEditableErrors()
        {
            base.InnerQuery.AddField("merchantEditableErrors");
            return this;
        }

        public OrderQueryBuilder MerchantOfRecordApp(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder> build)
        {
            var query = new Query<OrderApp>("merchantOfRecordApp");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderApp>(query);
            return this;
        }

        public OrderQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public OrderQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public OrderQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public OrderQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        [Obsolete("Use `netPaymentSet` instead.")]
        public OrderQueryBuilder NetPayment()
        {
            base.InnerQuery.AddField("netPayment");
            return this;
        }

        public OrderQueryBuilder NetPaymentSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("netPaymentSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder NonFulfillableLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder> build)
        {
            var query = new Query<LineItemConnection>("nonFulfillableLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemConnection>(query);
            return this;
        }

        public OrderQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public OrderQueryBuilder Number()
        {
            base.InnerQuery.AddField("number");
            return this;
        }

        public OrderQueryBuilder OriginalTotalAdditionalFeesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalAdditionalFeesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder OriginalTotalDutiesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder OriginalTotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder PaymentCollectionDetails(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderPaymentCollectionDetailsQueryBuilder> build)
        {
            var query = new Query<OrderPaymentCollectionDetails>("paymentCollectionDetails");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderPaymentCollectionDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderPaymentCollectionDetails>(query);
            return this;
        }

        public OrderQueryBuilder PaymentGatewayNames()
        {
            base.InnerQuery.AddField("paymentGatewayNames");
            return this;
        }

        public OrderQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public OrderQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public OrderQueryBuilder PhysicalLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("physicalLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public OrderQueryBuilder PoNumber()
        {
            base.InnerQuery.AddField("poNumber");
            return this;
        }

        public OrderQueryBuilder PresentmentCurrencyCode()
        {
            base.InnerQuery.AddField("presentmentCurrencyCode");
            return this;
        }

        public OrderQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public OrderQueryBuilder ProductNetwork()
        {
            base.InnerQuery.AddField("productNetwork");
            return this;
        }

        public OrderQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referralCode` instead")]
        public OrderQueryBuilder ReferralCode()
        {
            base.InnerQuery.AddField("referralCode");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referralInfoHtml` instead")]
        public OrderQueryBuilder ReferrerDisplayText()
        {
            base.InnerQuery.AddField("referrerDisplayText");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referrerUrl` instead")]
        public OrderQueryBuilder ReferrerUrl()
        {
            base.InnerQuery.AddField("referrerUrl");
            return this;
        }

        public OrderQueryBuilder Refundable()
        {
            base.InnerQuery.AddField("refundable");
            return this;
        }

        public OrderQueryBuilder RefundDiscrepancySet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("refundDiscrepancySet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder Refunds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refunds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public OrderQueryBuilder RegisteredSourceUrl()
        {
            base.InnerQuery.AddField("registeredSourceUrl");
            return this;
        }

        public OrderQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public OrderQueryBuilder Restockable()
        {
            base.InnerQuery.AddField("restockable");
            return this;
        }

        public OrderQueryBuilder RetailLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("retailLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public OrderQueryBuilder Returns(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnConnection>("returns");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnConnection>(query);
            return this;
        }

        public OrderQueryBuilder ReturnStatus()
        {
            base.InnerQuery.AddField("returnStatus");
            return this;
        }

        public OrderQueryBuilder Risk(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskSummaryQueryBuilder> build)
        {
            var query = new Query<OrderRiskSummary>("risk");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskSummary>(query);
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public OrderQueryBuilder RiskLevel()
        {
            base.InnerQuery.AddField("riskLevel");
            return this;
        }

        public OrderQueryBuilder Risks(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskQueryBuilder> build)
        {
            var query = new Query<OrderRisk>("risks");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRisk>(query);
            return this;
        }

        public OrderQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public OrderQueryBuilder ShippingLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineConnectionQueryBuilder> build)
        {
            var query = new Query<ShippingLineConnection>("shippingLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLineConnection>(query);
            return this;
        }

        public OrderQueryBuilder ShopifyProtect(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyProtectOrderSummaryQueryBuilder> build)
        {
            var query = new Query<ShopifyProtectOrderSummary>("shopifyProtect");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyProtectOrderSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyProtectOrderSummary>(query);
            return this;
        }

        public OrderQueryBuilder SourceIdentifier()
        {
            base.InnerQuery.AddField("sourceIdentifier");
            return this;
        }

        public OrderQueryBuilder SourceName()
        {
            base.InnerQuery.AddField("sourceName");
            return this;
        }

        public OrderQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public OrderQueryBuilder StatusPageUrl()
        {
            base.InnerQuery.AddField("statusPageUrl");
            return this;
        }

        public OrderQueryBuilder SubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("subtotalLineItemsQuantity");
            return this;
        }

        [Obsolete("Use `subtotalPriceSet` instead.")]
        public OrderQueryBuilder SubtotalPrice()
        {
            base.InnerQuery.AddField("subtotalPrice");
            return this;
        }

        public OrderQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder SuggestedRefund(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundQueryBuilder> build)
        {
            var query = new Query<SuggestedRefund>("suggestedRefund");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedRefund>(query);
            return this;
        }

        public OrderQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public OrderQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public OrderQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public OrderQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public OrderQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        [Obsolete("Use `totalCapturableSet` instead.")]
        public OrderQueryBuilder TotalCapturable()
        {
            base.InnerQuery.AddField("totalCapturable");
            return this;
        }

        public OrderQueryBuilder TotalCapturableSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCapturableSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder TotalCashRoundingAdjustment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashRoundingAdjustmentQueryBuilder> build)
        {
            var query = new Query<CashRoundingAdjustment>("totalCashRoundingAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashRoundingAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashRoundingAdjustment>(query);
            return this;
        }

        [Obsolete("Use `totalDiscountsSet` instead.")]
        public OrderQueryBuilder TotalDiscounts()
        {
            base.InnerQuery.AddField("totalDiscounts");
            return this;
        }

        public OrderQueryBuilder TotalDiscountsSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder TotalOutstandingSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalOutstandingSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalPriceSet` instead.")]
        public OrderQueryBuilder TotalPrice()
        {
            base.InnerQuery.AddField("totalPrice");
            return this;
        }

        public OrderQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalReceivedSet` instead.")]
        public OrderQueryBuilder TotalReceived()
        {
            base.InnerQuery.AddField("totalReceived");
            return this;
        }

        public OrderQueryBuilder TotalReceivedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalReceivedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalRefundedSet` instead.")]
        public OrderQueryBuilder TotalRefunded()
        {
            base.InnerQuery.AddField("totalRefunded");
            return this;
        }

        public OrderQueryBuilder TotalRefundedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder TotalRefundedShippingSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedShippingSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalShippingPriceSet` instead.")]
        public OrderQueryBuilder TotalShippingPrice()
        {
            base.InnerQuery.AddField("totalShippingPrice");
            return this;
        }

        public OrderQueryBuilder TotalShippingPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public OrderQueryBuilder TotalTax()
        {
            base.InnerQuery.AddField("totalTax");
            return this;
        }

        public OrderQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder TotalTipReceived(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalTipReceived");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public OrderQueryBuilder TotalTipReceivedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTipReceivedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderQueryBuilder TotalWeight()
        {
            base.InnerQuery.AddField("totalWeight");
            return this;
        }

        public OrderQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public OrderQueryBuilder TransactionsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("transactionsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public OrderQueryBuilder Unpaid()
        {
            base.InnerQuery.AddField("unpaid");
            return this;
        }

        public OrderQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public OrderQueryBuilder PurchasingEntity(Action<PurchasingEntityUnionCasesBuilder> build)
        {
            var query = new Query<PurchasingEntity>("purchasingEntity");
            var unionBuilder = new PurchasingEntityUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}