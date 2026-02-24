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
    public sealed class QueryRootOrderByIdentifierQueryBuilder : FieldsQueryBuilderBase<Order, QueryRootOrderByIdentifierQueryBuilder>, IHasArguments<QueryRootOrderByIdentifierArgumentsBuilder>
    {
        public QueryRootOrderByIdentifierArgumentsBuilder Arguments { get; }
        protected override QueryRootOrderByIdentifierQueryBuilder Self => this;

        public QueryRootOrderByIdentifierQueryBuilder(string name) : base(new Query<Order>(name))
        {
            Arguments = new QueryRootOrderByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrderByIdentifierQueryBuilder(IQuery<Order> query) : base(query)
        {
            Arguments = new QueryRootOrderByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrderByIdentifierQueryBuilder SetArguments(Action<QueryRootOrderByIdentifierArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder AdditionalFees(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AdditionalFeeQueryBuilder> build)
        {
            var query = new Query<AdditionalFee>("additionalFees");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AdditionalFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AdditionalFee>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Agreements(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SalesAgreementConnectionQueryBuilder> build)
        {
            var query = new Query<SalesAgreementConnection>("agreements");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SalesAgreementConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SalesAgreementConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Alerts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourceAlertQueryBuilder> build)
        {
            var query = new Query<ResourceAlert>("alerts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourceAlertQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceAlert>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAppQueryBuilder> build)
        {
            var query = new Query<OrderApp>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderApp>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder BillingAddressMatchesShippingAddress()
        {
            base.InnerQuery.AddField("billingAddressMatchesShippingAddress");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Cancellation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderCancellationQueryBuilder> build)
        {
            var query = new Query<OrderCancellation>("cancellation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderCancellationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCancellation>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CancelledAt()
        {
            base.InnerQuery.AddField("cancelledAt");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CancelReason()
        {
            base.InnerQuery.AddField("cancelReason");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CanMarkAsPaid()
        {
            base.InnerQuery.AddField("canMarkAsPaid");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CanNotifyCustomer()
        {
            base.InnerQuery.AddField("canNotifyCustomer");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Capturable()
        {
            base.InnerQuery.AddField("capturable");
            return this;
        }

        [Obsolete("Use `cartDiscountAmountSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder CartDiscountAmount()
        {
            base.InnerQuery.AddField("cartDiscountAmount");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CartDiscountAmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("cartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Channel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ChannelInformation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelInformationQueryBuilder> build)
        {
            var query = new Query<ChannelInformation>("channelInformation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelInformationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelInformation>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ClientIp()
        {
            base.InnerQuery.AddField("clientIp");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Closed()
        {
            base.InnerQuery.AddField("closed");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ClosedAt()
        {
            base.InnerQuery.AddField("closedAt");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ConfirmationNumber()
        {
            base.InnerQuery.AddField("confirmationNumber");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Confirmed()
        {
            base.InnerQuery.AddField("confirmed");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentCartDiscountAmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentCartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentShippingPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentSubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("currentSubtotalLineItemsQuantity");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentSubtotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentSubtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentTaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("currentTaxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentTotalAdditionalFeesSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalAdditionalFeesSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentTotalDiscountsSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentTotalDutiesSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentTotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentTotalTaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentTotalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CurrentTotalWeight()
        {
            base.InnerQuery.AddField("currentTotalWeight");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CustomerAcceptsMarketing()
        {
            base.InnerQuery.AddField("customerAcceptsMarketing");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CustomerJourney(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerJourneyQueryBuilder> build)
        {
            var query = new Query<CustomerJourney>("customerJourney");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerJourneyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerJourney>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CustomerJourneySummary(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerJourneySummaryQueryBuilder> build)
        {
            var query = new Query<CustomerJourneySummary>("customerJourneySummary");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerJourneySummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerJourneySummary>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder CustomerLocale()
        {
            base.InnerQuery.AddField("customerLocale");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder DiscountApplications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationConnection>("discountApplications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder DiscountCode()
        {
            base.InnerQuery.AddField("discountCode");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder DiscountCodes()
        {
            base.InnerQuery.AddField("discountCodes");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder DisplayAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("displayAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder DisplayFinancialStatus()
        {
            base.InnerQuery.AddField("displayFinancialStatus");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder DisplayFulfillmentStatus()
        {
            base.InnerQuery.AddField("displayFulfillmentStatus");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Disputes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder> build)
        {
            var query = new Query<OrderDisputeSummary>("disputes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderDisputeSummary>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder DutiesIncluded()
        {
            base.InnerQuery.AddField("dutiesIncluded");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Edited()
        {
            base.InnerQuery.AddField("edited");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder EstimatedTaxes()
        {
            base.InnerQuery.AddField("estimatedTaxes");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ExchangeV2s(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ExchangeV2Connection>("exchangeV2s");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2Connection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Fulfillable()
        {
            base.InnerQuery.AddField("fulfillable");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Fulfillments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder FulfillmentsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("fulfillmentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder FullyPaid()
        {
            base.InnerQuery.AddField("fullyPaid");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.landingPageHtml` instead")]
        public QueryRootOrderByIdentifierQueryBuilder LandingPageDisplayText()
        {
            base.InnerQuery.AddField("landingPageDisplayText");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.landingPage` instead")]
        public QueryRootOrderByIdentifierQueryBuilder LandingPageUrl()
        {
            base.InnerQuery.AddField("landingPageUrl");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemConnectionQueryBuilder> build)
        {
            var query = new Query<LineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder LocalizationExtensions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionConnection>("localizationExtensions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder LocalizedFields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldConnection>("localizedFields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder MerchantBusinessEntity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityQueryBuilder> build)
        {
            var query = new Query<BusinessEntity>("merchantBusinessEntity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntity>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder MerchantEditable()
        {
            base.InnerQuery.AddField("merchantEditable");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder MerchantEditableErrors()
        {
            base.InnerQuery.AddField("merchantEditableErrors");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder MerchantOfRecordApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAppQueryBuilder> build)
        {
            var query = new Query<OrderApp>("merchantOfRecordApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderApp>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        [Obsolete("Use `netPaymentSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder NetPayment()
        {
            base.InnerQuery.AddField("netPayment");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder NetPaymentSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("netPaymentSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder NonFulfillableLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemConnectionQueryBuilder> build)
        {
            var query = new Query<LineItemConnection>("nonFulfillableLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Number()
        {
            base.InnerQuery.AddField("number");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder OriginalTotalAdditionalFeesSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalAdditionalFeesSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder OriginalTotalDutiesSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder OriginalTotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder PaymentCollectionDetails(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderPaymentCollectionDetailsQueryBuilder> build)
        {
            var query = new Query<OrderPaymentCollectionDetails>("paymentCollectionDetails");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderPaymentCollectionDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderPaymentCollectionDetails>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder PaymentGatewayNames()
        {
            base.InnerQuery.AddField("paymentGatewayNames");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder PhysicalLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("physicalLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder PoNumber()
        {
            base.InnerQuery.AddField("poNumber");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder PresentmentCurrencyCode()
        {
            base.InnerQuery.AddField("presentmentCurrencyCode");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Publication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referralCode` instead")]
        public QueryRootOrderByIdentifierQueryBuilder ReferralCode()
        {
            base.InnerQuery.AddField("referralCode");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referralInfoHtml` instead")]
        public QueryRootOrderByIdentifierQueryBuilder ReferrerDisplayText()
        {
            base.InnerQuery.AddField("referrerDisplayText");
            return this;
        }

        [Obsolete("Use `customerJourneySummary.lastVisit.referrerUrl` instead")]
        public QueryRootOrderByIdentifierQueryBuilder ReferrerUrl()
        {
            base.InnerQuery.AddField("referrerUrl");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Refundable()
        {
            base.InnerQuery.AddField("refundable");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder RefundDiscrepancySet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("refundDiscrepancySet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Refunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder RegisteredSourceUrl()
        {
            base.InnerQuery.AddField("registeredSourceUrl");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Restockable()
        {
            base.InnerQuery.AddField("restockable");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder RetailLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("retailLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Returns(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnConnection>("returns");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ReturnStatus()
        {
            base.InnerQuery.AddField("returnStatus");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Risk(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderRiskSummaryQueryBuilder> build)
        {
            var query = new Query<OrderRiskSummary>("risk");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderRiskSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskSummary>(query);
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public QueryRootOrderByIdentifierQueryBuilder RiskLevel()
        {
            base.InnerQuery.AddField("riskLevel");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Risks(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderRiskQueryBuilder> build)
        {
            var query = new Query<OrderRisk>("risks");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderRiskQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRisk>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ShippingLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineConnectionQueryBuilder> build)
        {
            var query = new Query<ShippingLineConnection>("shippingLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLineConnection>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder ShopifyProtect(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyProtectOrderSummaryQueryBuilder> build)
        {
            var query = new Query<ShopifyProtectOrderSummary>("shopifyProtect");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyProtectOrderSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyProtectOrderSummary>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder SourceIdentifier()
        {
            base.InnerQuery.AddField("sourceIdentifier");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder SourceName()
        {
            base.InnerQuery.AddField("sourceName");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder StatusPageUrl()
        {
            base.InnerQuery.AddField("statusPageUrl");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder SubtotalLineItemsQuantity()
        {
            base.InnerQuery.AddField("subtotalLineItemsQuantity");
            return this;
        }

        [Obsolete("Use `subtotalPriceSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder SubtotalPrice()
        {
            base.InnerQuery.AddField("subtotalPrice");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder SuggestedRefund(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedRefundQueryBuilder> build)
        {
            var query = new Query<SuggestedRefund>("suggestedRefund");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedRefund>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        [Obsolete("Use `totalCapturableSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder TotalCapturable()
        {
            base.InnerQuery.AddField("totalCapturable");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalCapturableSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCapturableSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalCashRoundingAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashRoundingAdjustmentQueryBuilder> build)
        {
            var query = new Query<CashRoundingAdjustment>("totalCashRoundingAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashRoundingAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashRoundingAdjustment>(query);
            return this;
        }

        [Obsolete("Use `totalDiscountsSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder TotalDiscounts()
        {
            base.InnerQuery.AddField("totalDiscounts");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalDiscountsSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalOutstandingSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalOutstandingSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalPriceSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder TotalPrice()
        {
            base.InnerQuery.AddField("totalPrice");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalReceivedSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder TotalReceived()
        {
            base.InnerQuery.AddField("totalReceived");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalReceivedSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalReceivedSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalRefundedSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder TotalRefunded()
        {
            base.InnerQuery.AddField("totalRefunded");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalRefundedSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalRefundedShippingSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedShippingSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalShippingPriceSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder TotalShippingPrice()
        {
            base.InnerQuery.AddField("totalShippingPrice");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalShippingPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalShippingPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public QueryRootOrderByIdentifierQueryBuilder TotalTax()
        {
            base.InnerQuery.AddField("totalTax");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalTipReceived(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalTipReceived");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalTipReceivedSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTipReceivedSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TotalWeight()
        {
            base.InnerQuery.AddField("totalWeight");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder TransactionsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("transactionsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder Unpaid()
        {
            base.InnerQuery.AddField("unpaid");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public QueryRootOrderByIdentifierQueryBuilder PurchasingEntity(Action<PurchasingEntityUnionCasesBuilder> build)
        {
            var query = new Query<PurchasingEntity>("purchasingEntity");
            var unionBuilder = new PurchasingEntityUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}