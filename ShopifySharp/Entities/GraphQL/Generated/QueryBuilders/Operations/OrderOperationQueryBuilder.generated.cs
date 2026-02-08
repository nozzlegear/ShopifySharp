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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class OrderOperationQueryBuilder : FieldsQueryBuilderBase<Order, OrderOperationQueryBuilder>, IGraphOperationQueryBuilder<Order>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public OrderArgumentsBuilder Arguments { get; }
        protected override OrderOperationQueryBuilder Self => this;

        public OrderOperationQueryBuilder() : this("order")
        {
        }

        public OrderOperationQueryBuilder(string name) : base(new Query<Order>(name))
        {
            Arguments = new OrderArgumentsBuilder(base.InnerQuery);
        }

        public OrderOperationQueryBuilder(IQuery<Order> query) : base(query)
        {
            Arguments = new OrderArgumentsBuilder(base.InnerQuery);
        }

        public OrderOperationQueryBuilder AdditionalFees(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AdditionalFeeQueryBuilder> build)
        {
            var query = new Query<AdditionalFee>("additionalFees");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AdditionalFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AdditionalFee>(query);
            return this;
        }

        public OrderOperationQueryBuilder Agreements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SalesAgreementConnectionQueryBuilder> build)
        {
            var query = new Query<SalesAgreementConnection>("agreements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SalesAgreementConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SalesAgreementConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder Alerts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceAlertQueryBuilder> build)
        {
            var query = new Query<ResourceAlert>("alerts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceAlertQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceAlert>(query);
            return this;
        }

        public OrderOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder> build)
        {
            var query = new Query<OrderApp>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderApp>(query);
            return this;
        }

        public OrderOperationQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderOperationQueryBuilder BillingAddressMatchesShippingAddress()
        {
            base.InnerQuery.AddField("billingAddressMatchesShippingAddress");
            return this;
        }

        public OrderOperationQueryBuilder Cancellation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancellationQueryBuilder> build)
        {
            var query = new Query<OrderCancellation>("cancellation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancellationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCancellation>(query);
            return this;
        }

        public OrderOperationQueryBuilder CancelledAt()
        {
            base.InnerQuery.AddField("cancelledAt");
            return this;
        }

        public OrderOperationQueryBuilder CancelReason()
        {
            base.InnerQuery.AddField("cancelReason");
            return this;
        }

        public OrderOperationQueryBuilder CanMarkAsPaid()
        {
            base.InnerQuery.AddField("canMarkAsPaid");
            return this;
        }

        public OrderOperationQueryBuilder CanNotifyCustomer()
        {
            base.InnerQuery.AddField("canNotifyCustomer");
            return this;
        }

        public OrderOperationQueryBuilder Capturable()
        {
            base.InnerQuery.AddField("capturable");
            return this;
        }

        [Obsolete("Use `cartDiscountAmountSet` instead.")]
        public OrderOperationQueryBuilder CartDiscountAmount()
        {
            base.InnerQuery.AddField("cartDiscountAmount");
            return this;
        }

        public OrderOperationQueryBuilder CartDiscountAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("cartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder Channel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public OrderOperationQueryBuilder ChannelInformation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelInformationQueryBuilder> build)
        {
            var query = new Query<ChannelInformation>("channelInformation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelInformationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelInformation>(query);
            return this;
        }

        public OrderOperationQueryBuilder ClientIp()
        {
            base.InnerQuery.AddField("clientIp");
            return this;
        }

        public OrderOperationQueryBuilder Closed()
        {
            base.InnerQuery.AddField("closed");
            return this;
        }

        public OrderOperationQueryBuilder ClosedAt()
        {
            base.InnerQuery.AddField("closedAt");
            return this;
        }

        public OrderOperationQueryBuilder ConfirmationNumber()
        {
            base.InnerQuery.AddField("confirmationNumber");
            return this;
        }

        public OrderOperationQueryBuilder Confirmed()
        {
            base.InnerQuery.AddField("confirmed");
            return this;
        }

        public OrderOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public OrderOperationQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public OrderOperationQueryBuilder CurrentCartDiscountAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentCartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentShippingPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentSubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("currentSubtotalLineItemsQuantity");
            return this;
        }

        public OrderOperationQueryBuilder CurrentSubtotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentSubtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentTaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("currentTaxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentTotalAdditionalFeesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalAdditionalFeesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentTotalDiscountsSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentTotalDutiesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentTotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentTotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder CurrentTotalWeight()
        {
            base.InnerQuery.AddField("currentTotalWeight");
            return this;
        }

        public OrderOperationQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public OrderOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public OrderOperationQueryBuilder CustomerAcceptsMarketing()
        {
            base.InnerQuery.AddField("customerAcceptsMarketing");
            return this;
        }

        public OrderOperationQueryBuilder CustomerJourney(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneyQueryBuilder> build)
        {
            var query = new Query<CustomerJourney>("customerJourney");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerJourney>(query);
            return this;
        }

        public OrderOperationQueryBuilder CustomerJourneySummary(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneySummaryQueryBuilder> build)
        {
            var query = new Query<CustomerJourneySummary>("customerJourneySummary");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneySummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerJourneySummary>(query);
            return this;
        }

        public OrderOperationQueryBuilder CustomerLocale()
        {
            base.InnerQuery.AddField("customerLocale");
            return this;
        }

        public OrderOperationQueryBuilder DiscountApplications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationConnection>("discountApplications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder DiscountCode()
        {
            base.InnerQuery.AddField("discountCode");
            return this;
        }

        public OrderOperationQueryBuilder DiscountCodes()
        {
            base.InnerQuery.AddField("discountCodes");
            return this;
        }

        public OrderOperationQueryBuilder DisplayAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("displayAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderOperationQueryBuilder DisplayFinancialStatus()
        {
            base.InnerQuery.AddField("displayFinancialStatus");
            return this;
        }

        public OrderOperationQueryBuilder DisplayFulfillmentStatus()
        {
            base.InnerQuery.AddField("displayFulfillmentStatus");
            return this;
        }

        public OrderOperationQueryBuilder Disputes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder> build)
        {
            var query = new Query<OrderDisputeSummary>("disputes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderDisputeSummary>(query);
            return this;
        }

        public OrderOperationQueryBuilder DutiesIncluded()
        {
            base.InnerQuery.AddField("dutiesIncluded");
            return this;
        }

        public OrderOperationQueryBuilder Edited()
        {
            base.InnerQuery.AddField("edited");
            return this;
        }

        public OrderOperationQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public OrderOperationQueryBuilder EstimatedTaxes()
        {
            base.InnerQuery.AddField("estimatedTaxes");
            return this;
        }

        public OrderOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder ExchangeV2s(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ExchangeV2Connection>("exchangeV2s");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2Connection>(query);
            return this;
        }

        public OrderOperationQueryBuilder Fulfillable()
        {
            base.InnerQuery.AddField("fulfillable");
            return this;
        }

        public OrderOperationQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder Fulfillments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public OrderOperationQueryBuilder FulfillmentsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("fulfillmentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public OrderOperationQueryBuilder FullyPaid()
        {
            base.InnerQuery.AddField("fullyPaid");
            return this;
        }

        public OrderOperationQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public OrderOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.landingPageHtml` instead")]
        public OrderOperationQueryBuilder LandingPageDisplayText()
        {
            base.InnerQuery.AddField("landingPageDisplayText");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.landingPage` instead")]
        public OrderOperationQueryBuilder LandingPageUrl()
        {
            base.InnerQuery.AddField("landingPageUrl");
            return this;
        }

        public OrderOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public OrderOperationQueryBuilder LineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder> build)
        {
            var query = new Query<LineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder LocalizationExtensions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionConnection>("localizationExtensions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder LocalizedFields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldConnection>("localizedFields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder MerchantBusinessEntity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder> build)
        {
            var query = new Query<BusinessEntity>("merchantBusinessEntity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntity>(query);
            return this;
        }

        public OrderOperationQueryBuilder MerchantEditable()
        {
            base.InnerQuery.AddField("merchantEditable");
            return this;
        }

        public OrderOperationQueryBuilder MerchantEditableErrors()
        {
            base.InnerQuery.AddField("merchantEditableErrors");
            return this;
        }

        public OrderOperationQueryBuilder MerchantOfRecordApp(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder> build)
        {
            var query = new Query<OrderApp>("merchantOfRecordApp");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderApp>(query);
            return this;
        }

        public OrderOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public OrderOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        [Obsolete("Use `netPaymentSet` instead.")]
        public OrderOperationQueryBuilder NetPayment()
        {
            base.InnerQuery.AddField("netPayment");
            return this;
        }

        public OrderOperationQueryBuilder NetPaymentSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("netPaymentSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder NonFulfillableLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder> build)
        {
            var query = new Query<LineItemConnection>("nonFulfillableLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public OrderOperationQueryBuilder Number()
        {
            base.InnerQuery.AddField("number");
            return this;
        }

        public OrderOperationQueryBuilder OriginalTotalAdditionalFeesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalAdditionalFeesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder OriginalTotalDutiesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder OriginalTotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder PaymentCollectionDetails(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderPaymentCollectionDetailsQueryBuilder> build)
        {
            var query = new Query<OrderPaymentCollectionDetails>("paymentCollectionDetails");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderPaymentCollectionDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderPaymentCollectionDetails>(query);
            return this;
        }

        public OrderOperationQueryBuilder PaymentGatewayNames()
        {
            base.InnerQuery.AddField("paymentGatewayNames");
            return this;
        }

        public OrderOperationQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public OrderOperationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public OrderOperationQueryBuilder PhysicalLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("physicalLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public OrderOperationQueryBuilder PoNumber()
        {
            base.InnerQuery.AddField("poNumber");
            return this;
        }

        public OrderOperationQueryBuilder PresentmentCurrencyCode()
        {
            base.InnerQuery.AddField("presentmentCurrencyCode");
            return this;
        }

        public OrderOperationQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public OrderOperationQueryBuilder ProductNetwork()
        {
            base.InnerQuery.AddField("productNetwork");
            return this;
        }

        public OrderOperationQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referralCode` instead")]
        public OrderOperationQueryBuilder ReferralCode()
        {
            base.InnerQuery.AddField("referralCode");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referralInfoHtml` instead")]
        public OrderOperationQueryBuilder ReferrerDisplayText()
        {
            base.InnerQuery.AddField("referrerDisplayText");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referrerUrl` instead")]
        public OrderOperationQueryBuilder ReferrerUrl()
        {
            base.InnerQuery.AddField("referrerUrl");
            return this;
        }

        public OrderOperationQueryBuilder Refundable()
        {
            base.InnerQuery.AddField("refundable");
            return this;
        }

        public OrderOperationQueryBuilder RefundDiscrepancySet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("refundDiscrepancySet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder Refunds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refunds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public OrderOperationQueryBuilder RegisteredSourceUrl()
        {
            base.InnerQuery.AddField("registeredSourceUrl");
            return this;
        }

        public OrderOperationQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public OrderOperationQueryBuilder Restockable()
        {
            base.InnerQuery.AddField("restockable");
            return this;
        }

        public OrderOperationQueryBuilder RetailLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("retailLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public OrderOperationQueryBuilder Returns(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnConnection>("returns");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder ReturnStatus()
        {
            base.InnerQuery.AddField("returnStatus");
            return this;
        }

        public OrderOperationQueryBuilder Risk(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskSummaryQueryBuilder> build)
        {
            var query = new Query<OrderRiskSummary>("risk");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskSummary>(query);
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public OrderOperationQueryBuilder RiskLevel()
        {
            base.InnerQuery.AddField("riskLevel");
            return this;
        }

        public OrderOperationQueryBuilder Risks(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskQueryBuilder> build)
        {
            var query = new Query<OrderRisk>("risks");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRisk>(query);
            return this;
        }

        public OrderOperationQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderOperationQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public OrderOperationQueryBuilder ShippingLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineConnectionQueryBuilder> build)
        {
            var query = new Query<ShippingLineConnection>("shippingLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLineConnection>(query);
            return this;
        }

        public OrderOperationQueryBuilder ShopifyProtect(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyProtectOrderSummaryQueryBuilder> build)
        {
            var query = new Query<ShopifyProtectOrderSummary>("shopifyProtect");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyProtectOrderSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyProtectOrderSummary>(query);
            return this;
        }

        public OrderOperationQueryBuilder SourceIdentifier()
        {
            base.InnerQuery.AddField("sourceIdentifier");
            return this;
        }

        public OrderOperationQueryBuilder SourceName()
        {
            base.InnerQuery.AddField("sourceName");
            return this;
        }

        public OrderOperationQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public OrderOperationQueryBuilder StatusPageUrl()
        {
            base.InnerQuery.AddField("statusPageUrl");
            return this;
        }

        public OrderOperationQueryBuilder SubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("subtotalLineItemsQuantity");
            return this;
        }

        [Obsolete("Use `subtotalPriceSet` instead.")]
        public OrderOperationQueryBuilder SubtotalPrice()
        {
            base.InnerQuery.AddField("subtotalPrice");
            return this;
        }

        public OrderOperationQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder SuggestedRefund(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundQueryBuilder> build)
        {
            var query = new Query<SuggestedRefund>("suggestedRefund");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedRefund>(query);
            return this;
        }

        public OrderOperationQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public OrderOperationQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public OrderOperationQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public OrderOperationQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public OrderOperationQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        [Obsolete("Use `totalCapturableSet` instead.")]
        public OrderOperationQueryBuilder TotalCapturable()
        {
            base.InnerQuery.AddField("totalCapturable");
            return this;
        }

        public OrderOperationQueryBuilder TotalCapturableSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCapturableSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder TotalCashRoundingAdjustment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashRoundingAdjustmentQueryBuilder> build)
        {
            var query = new Query<CashRoundingAdjustment>("totalCashRoundingAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashRoundingAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashRoundingAdjustment>(query);
            return this;
        }

        [Obsolete("Use `totalDiscountsSet` instead.")]
        public OrderOperationQueryBuilder TotalDiscounts()
        {
            base.InnerQuery.AddField("totalDiscounts");
            return this;
        }

        public OrderOperationQueryBuilder TotalDiscountsSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder TotalOutstandingSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalOutstandingSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalPriceSet` instead.")]
        public OrderOperationQueryBuilder TotalPrice()
        {
            base.InnerQuery.AddField("totalPrice");
            return this;
        }

        public OrderOperationQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalReceivedSet` instead.")]
        public OrderOperationQueryBuilder TotalReceived()
        {
            base.InnerQuery.AddField("totalReceived");
            return this;
        }

        public OrderOperationQueryBuilder TotalReceivedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalReceivedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalRefundedSet` instead.")]
        public OrderOperationQueryBuilder TotalRefunded()
        {
            base.InnerQuery.AddField("totalRefunded");
            return this;
        }

        public OrderOperationQueryBuilder TotalRefundedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder TotalRefundedShippingSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedShippingSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalShippingPriceSet` instead.")]
        public OrderOperationQueryBuilder TotalShippingPrice()
        {
            base.InnerQuery.AddField("totalShippingPrice");
            return this;
        }

        public OrderOperationQueryBuilder TotalShippingPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public OrderOperationQueryBuilder TotalTax()
        {
            base.InnerQuery.AddField("totalTax");
            return this;
        }

        public OrderOperationQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder TotalTipReceived(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalTipReceived");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public OrderOperationQueryBuilder TotalTipReceivedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTipReceivedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderOperationQueryBuilder TotalWeight()
        {
            base.InnerQuery.AddField("totalWeight");
            return this;
        }

        public OrderOperationQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public OrderOperationQueryBuilder TransactionsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("transactionsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public OrderOperationQueryBuilder Unpaid()
        {
            base.InnerQuery.AddField("unpaid");
            return this;
        }

        public OrderOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public OrderOperationQueryBuilder PurchasingEntity(Action<PurchasingEntityUnionCasesBuilder> build)
        {
            var query = new Query<PurchasingEntity>("purchasingEntity");
            var unionBuilder = new PurchasingEntityUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}