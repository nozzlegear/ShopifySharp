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
    public sealed class OrderByIdentifierOperationQueryBuilder : FieldsQueryBuilderBase<Order, OrderByIdentifierOperationQueryBuilder>, IGraphOperationQueryBuilder<Order>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public OrderByIdentifierArgumentsBuilder Arguments { get; }
        protected override OrderByIdentifierOperationQueryBuilder Self => this;

        public OrderByIdentifierOperationQueryBuilder() : this("orderByIdentifier")
        {
        }

        public OrderByIdentifierOperationQueryBuilder(string name) : base(new Query<Order>(name))
        {
            Arguments = new OrderByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public OrderByIdentifierOperationQueryBuilder(IQuery<Order> query) : base(query)
        {
            Arguments = new OrderByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public OrderByIdentifierOperationQueryBuilder AdditionalFees(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AdditionalFeeQueryBuilder> build)
        {
            var query = new Query<AdditionalFee>("additionalFees");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AdditionalFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AdditionalFee>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Agreements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SalesAgreementConnectionQueryBuilder> build)
        {
            var query = new Query<SalesAgreementConnection>("agreements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SalesAgreementConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SalesAgreementConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Alerts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceAlertQueryBuilder> build)
        {
            var query = new Query<ResourceAlert>("alerts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceAlertQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceAlert>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder> build)
        {
            var query = new Query<OrderApp>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderApp>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder BillingAddressMatchesShippingAddress()
        {
            base.InnerQuery.AddField("billingAddressMatchesShippingAddress");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Cancellation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancellationQueryBuilder> build)
        {
            var query = new Query<OrderCancellation>("cancellation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancellationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCancellation>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CancelledAt()
        {
            base.InnerQuery.AddField("cancelledAt");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CancelReason()
        {
            base.InnerQuery.AddField("cancelReason");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CanMarkAsPaid()
        {
            base.InnerQuery.AddField("canMarkAsPaid");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CanNotifyCustomer()
        {
            base.InnerQuery.AddField("canNotifyCustomer");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Capturable()
        {
            base.InnerQuery.AddField("capturable");
            return this;
        }

        [Obsolete("Use `cartDiscountAmountSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder CartDiscountAmount()
        {
            base.InnerQuery.AddField("cartDiscountAmount");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CartDiscountAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("cartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Channel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ChannelInformation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelInformationQueryBuilder> build)
        {
            var query = new Query<ChannelInformation>("channelInformation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelInformationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelInformation>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ClientIp()
        {
            base.InnerQuery.AddField("clientIp");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Closed()
        {
            base.InnerQuery.AddField("closed");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ClosedAt()
        {
            base.InnerQuery.AddField("closedAt");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ConfirmationNumber()
        {
            base.InnerQuery.AddField("confirmationNumber");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Confirmed()
        {
            base.InnerQuery.AddField("confirmed");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentCartDiscountAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentCartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentShippingPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentSubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("currentSubtotalLineItemsQuantity");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentSubtotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentSubtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentTaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("currentTaxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentTotalAdditionalFeesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalAdditionalFeesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentTotalDiscountsSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentTotalDutiesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentTotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentTotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CurrentTotalWeight()
        {
            base.InnerQuery.AddField("currentTotalWeight");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CustomerAcceptsMarketing()
        {
            base.InnerQuery.AddField("customerAcceptsMarketing");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CustomerJourney(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneyQueryBuilder> build)
        {
            var query = new Query<CustomerJourney>("customerJourney");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerJourney>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CustomerJourneySummary(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneySummaryQueryBuilder> build)
        {
            var query = new Query<CustomerJourneySummary>("customerJourneySummary");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerJourneySummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerJourneySummary>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder CustomerLocale()
        {
            base.InnerQuery.AddField("customerLocale");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder DiscountApplications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationConnection>("discountApplications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder DiscountCode()
        {
            base.InnerQuery.AddField("discountCode");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder DiscountCodes()
        {
            base.InnerQuery.AddField("discountCodes");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder DisplayAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("displayAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder DisplayFinancialStatus()
        {
            base.InnerQuery.AddField("displayFinancialStatus");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder DisplayFulfillmentStatus()
        {
            base.InnerQuery.AddField("displayFulfillmentStatus");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Disputes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder> build)
        {
            var query = new Query<OrderDisputeSummary>("disputes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderDisputeSummary>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder DutiesIncluded()
        {
            base.InnerQuery.AddField("dutiesIncluded");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Edited()
        {
            base.InnerQuery.AddField("edited");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder EstimatedTaxes()
        {
            base.InnerQuery.AddField("estimatedTaxes");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ExchangeV2s(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ExchangeV2Connection>("exchangeV2s");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2Connection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Fulfillable()
        {
            base.InnerQuery.AddField("fulfillable");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Fulfillments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder FulfillmentsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("fulfillmentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder FullyPaid()
        {
            base.InnerQuery.AddField("fullyPaid");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.landingPageHtml` instead")]
        public OrderByIdentifierOperationQueryBuilder LandingPageDisplayText()
        {
            base.InnerQuery.AddField("landingPageDisplayText");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.landingPage` instead")]
        public OrderByIdentifierOperationQueryBuilder LandingPageUrl()
        {
            base.InnerQuery.AddField("landingPageUrl");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder LineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder> build)
        {
            var query = new Query<LineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder LocalizationExtensions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionConnection>("localizationExtensions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder LocalizedFields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldConnection>("localizedFields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder MerchantBusinessEntity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder> build)
        {
            var query = new Query<BusinessEntity>("merchantBusinessEntity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntity>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder MerchantEditable()
        {
            base.InnerQuery.AddField("merchantEditable");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder MerchantEditableErrors()
        {
            base.InnerQuery.AddField("merchantEditableErrors");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder MerchantOfRecordApp(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder> build)
        {
            var query = new Query<OrderApp>("merchantOfRecordApp");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderApp>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        [Obsolete("Use `netPaymentSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder NetPayment()
        {
            base.InnerQuery.AddField("netPayment");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder NetPaymentSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("netPaymentSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder NonFulfillableLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder> build)
        {
            var query = new Query<LineItemConnection>("nonFulfillableLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Number()
        {
            base.InnerQuery.AddField("number");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder OriginalTotalAdditionalFeesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalAdditionalFeesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder OriginalTotalDutiesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder OriginalTotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder PaymentCollectionDetails(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderPaymentCollectionDetailsQueryBuilder> build)
        {
            var query = new Query<OrderPaymentCollectionDetails>("paymentCollectionDetails");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderPaymentCollectionDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderPaymentCollectionDetails>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder PaymentGatewayNames()
        {
            base.InnerQuery.AddField("paymentGatewayNames");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder PhysicalLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("physicalLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder PoNumber()
        {
            base.InnerQuery.AddField("poNumber");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder PresentmentCurrencyCode()
        {
            base.InnerQuery.AddField("presentmentCurrencyCode");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ProductNetwork()
        {
            base.InnerQuery.AddField("productNetwork");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referralCode` instead")]
        public OrderByIdentifierOperationQueryBuilder ReferralCode()
        {
            base.InnerQuery.AddField("referralCode");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referralInfoHtml` instead")]
        public OrderByIdentifierOperationQueryBuilder ReferrerDisplayText()
        {
            base.InnerQuery.AddField("referrerDisplayText");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referrerUrl` instead")]
        public OrderByIdentifierOperationQueryBuilder ReferrerUrl()
        {
            base.InnerQuery.AddField("referrerUrl");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Refundable()
        {
            base.InnerQuery.AddField("refundable");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder RefundDiscrepancySet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("refundDiscrepancySet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Refunds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refunds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder RegisteredSourceUrl()
        {
            base.InnerQuery.AddField("registeredSourceUrl");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Restockable()
        {
            base.InnerQuery.AddField("restockable");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder RetailLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("retailLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Returns(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnConnection>("returns");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ReturnStatus()
        {
            base.InnerQuery.AddField("returnStatus");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Risk(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskSummaryQueryBuilder> build)
        {
            var query = new Query<OrderRiskSummary>("risk");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskSummary>(query);
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public OrderByIdentifierOperationQueryBuilder RiskLevel()
        {
            base.InnerQuery.AddField("riskLevel");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Risks(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskQueryBuilder> build)
        {
            var query = new Query<OrderRisk>("risks");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRisk>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ShippingLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineConnectionQueryBuilder> build)
        {
            var query = new Query<ShippingLineConnection>("shippingLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLineConnection>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder ShopifyProtect(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyProtectOrderSummaryQueryBuilder> build)
        {
            var query = new Query<ShopifyProtectOrderSummary>("shopifyProtect");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyProtectOrderSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyProtectOrderSummary>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder SourceIdentifier()
        {
            base.InnerQuery.AddField("sourceIdentifier");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder SourceName()
        {
            base.InnerQuery.AddField("sourceName");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder StatusPageUrl()
        {
            base.InnerQuery.AddField("statusPageUrl");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder SubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("subtotalLineItemsQuantity");
            return this;
        }

        [Obsolete("Use `subtotalPriceSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder SubtotalPrice()
        {
            base.InnerQuery.AddField("subtotalPrice");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder SuggestedRefund(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundQueryBuilder> build)
        {
            var query = new Query<SuggestedRefund>("suggestedRefund");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedRefund>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        [Obsolete("Use `totalCapturableSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder TotalCapturable()
        {
            base.InnerQuery.AddField("totalCapturable");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalCapturableSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCapturableSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalCashRoundingAdjustment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashRoundingAdjustmentQueryBuilder> build)
        {
            var query = new Query<CashRoundingAdjustment>("totalCashRoundingAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashRoundingAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashRoundingAdjustment>(query);
            return this;
        }

        [Obsolete("Use `totalDiscountsSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder TotalDiscounts()
        {
            base.InnerQuery.AddField("totalDiscounts");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalDiscountsSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalOutstandingSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalOutstandingSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalPriceSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder TotalPrice()
        {
            base.InnerQuery.AddField("totalPrice");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalReceivedSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder TotalReceived()
        {
            base.InnerQuery.AddField("totalReceived");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalReceivedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalReceivedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalRefundedSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder TotalRefunded()
        {
            base.InnerQuery.AddField("totalRefunded");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalRefundedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalRefundedShippingSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedShippingSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalShippingPriceSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder TotalShippingPrice()
        {
            base.InnerQuery.AddField("totalShippingPrice");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalShippingPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public OrderByIdentifierOperationQueryBuilder TotalTax()
        {
            base.InnerQuery.AddField("totalTax");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalTipReceived(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalTipReceived");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalTipReceivedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTipReceivedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TotalWeight()
        {
            base.InnerQuery.AddField("totalWeight");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder TransactionsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("transactionsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder Unpaid()
        {
            base.InnerQuery.AddField("unpaid");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public OrderByIdentifierOperationQueryBuilder PurchasingEntity(Action<PurchasingEntityUnionCasesBuilder> build)
        {
            var query = new Query<PurchasingEntity>("purchasingEntity");
            var unionBuilder = new PurchasingEntityUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}