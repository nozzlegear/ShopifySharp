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
    public sealed class CustomerQueryBuilder : FieldsQueryBuilderBase<Customer, CustomerQueryBuilder>
    {
        protected override CustomerQueryBuilder Self => this;

        public CustomerQueryBuilder() : this("customer")
        {
        }

        public CustomerQueryBuilder(string name) : base(new Query<Customer>(name))
        {
        }

        public CustomerQueryBuilder(IQuery<Customer> query) : base(query)
        {
        }

        public CustomerQueryBuilder Addresses(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("addresses");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerQueryBuilder AddressesV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressConnectionQueryBuilder> build)
        {
            var query = new Query<MailingAddressConnection>("addressesV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddressConnection>(query);
            return this;
        }

        public CustomerQueryBuilder AmountSpent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amountSpent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CustomerQueryBuilder CanDelete()
        {
            base.InnerQuery.AddField("canDelete");
            return this;
        }

        public CustomerQueryBuilder CompanyContactProfiles(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("companyContactProfiles");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CustomerQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CustomerQueryBuilder DataSaleOptOut()
        {
            base.InnerQuery.AddField("dataSaleOptOut");
            return this;
        }

        public CustomerQueryBuilder DefaultAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("defaultAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerQueryBuilder DefaultEmailAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerEmailAddressQueryBuilder> build)
        {
            var query = new Query<CustomerEmailAddress>("defaultEmailAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerEmailAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailAddress>(query);
            return this;
        }

        public CustomerQueryBuilder DefaultPhoneNumber(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder> build)
        {
            var query = new Query<CustomerPhoneNumber>("defaultPhoneNumber");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPhoneNumber>(query);
            return this;
        }

        public CustomerQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        [Obsolete("Use `defaultEmailAddress.emailAddress` instead.")]
        public CustomerQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public CustomerQueryBuilder EmailMarketingConsent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerEmailMarketingConsentStateQueryBuilder> build)
        {
            var query = new Query<CustomerEmailMarketingConsentState>("emailMarketingConsent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerEmailMarketingConsentStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailMarketingConsentState>(query);
            return this;
        }

        public CustomerQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CustomerQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        [Obsolete("To query for comments on the timeline, use the `events` connection and a query argument containing `verb:comment`, or look for a CommentEvent in the `__typename` of `events`.")]
        public CustomerQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public CustomerQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public CustomerQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CustomerQueryBuilder LastOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("lastOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public CustomerQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public CustomerQueryBuilder LifetimeDuration()
        {
            base.InnerQuery.AddField("lifetimeDuration");
            return this;
        }

        public CustomerQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CustomerQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public CustomerQueryBuilder Mergeable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergeableQueryBuilder> build)
        {
            var query = new Query<CustomerMergeable>("mergeable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergeableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeable>(query);
            return this;
        }

        public CustomerQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public CustomerQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public CustomerQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public CustomerQueryBuilder MultipassIdentifier()
        {
            base.InnerQuery.AddField("multipassIdentifier");
            return this;
        }

        public CustomerQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public CustomerQueryBuilder NumberOfOrders()
        {
            base.InnerQuery.AddField("numberOfOrders");
            return this;
        }

        public CustomerQueryBuilder Orders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public CustomerQueryBuilder PaymentMethods(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodConnection>("paymentMethods");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodConnection>(query);
            return this;
        }

        [Obsolete("Use `defaultPhoneNumber.phoneNumber` instead.")]
        public CustomerQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public CustomerQueryBuilder ProductSubscriberStatus()
        {
            base.InnerQuery.AddField("productSubscriberStatus");
            return this;
        }

        public CustomerQueryBuilder SmsMarketingConsent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSmsMarketingConsentStateQueryBuilder> build)
        {
            var query = new Query<CustomerSmsMarketingConsentState>("smsMarketingConsent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSmsMarketingConsentStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSmsMarketingConsentState>(query);
            return this;
        }

        public CustomerQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }

        public CustomerQueryBuilder Statistics(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerStatisticsQueryBuilder> build)
        {
            var query = new Query<CustomerStatistics>("statistics");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerStatisticsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerStatistics>(query);
            return this;
        }

        public CustomerQueryBuilder StoreCreditAccounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountConnection>("storeCreditAccounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountConnection>(query);
            return this;
        }

        public CustomerQueryBuilder SubscriptionContracts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractConnection>("subscriptionContracts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractConnection>(query);
            return this;
        }

        public CustomerQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public CustomerQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public CustomerQueryBuilder TaxExemptions()
        {
            base.InnerQuery.AddField("taxExemptions");
            return this;
        }

        [Obsolete("Use `defaultEmailAddress.marketingUnsubscribeUrl` instead.")]
        public CustomerQueryBuilder UnsubscribeUrl()
        {
            base.InnerQuery.AddField("unsubscribeUrl");
            return this;
        }

        public CustomerQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        [Obsolete("Use `defaultEmailAddress.validFormat` instead.")]
        public CustomerQueryBuilder ValidEmailAddress()
        {
            base.InnerQuery.AddField("validEmailAddress");
            return this;
        }

        public CustomerQueryBuilder VerifiedEmail()
        {
            base.InnerQuery.AddField("verifiedEmail");
            return this;
        }
    }
}