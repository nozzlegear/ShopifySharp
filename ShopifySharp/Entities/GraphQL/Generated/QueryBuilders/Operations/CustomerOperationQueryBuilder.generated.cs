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
    public sealed class CustomerOperationQueryBuilder : FieldsQueryBuilderBase<Customer, CustomerOperationQueryBuilder>, IGraphOperationQueryBuilder<Customer>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomerArgumentsBuilder Arguments { get; }
        protected override CustomerOperationQueryBuilder Self => this;

        public CustomerOperationQueryBuilder() : this("customer")
        {
        }

        public CustomerOperationQueryBuilder(string name) : base(new Query<Customer>(name))
        {
            Arguments = new CustomerArgumentsBuilder(base.InnerQuery);
        }

        public CustomerOperationQueryBuilder(IQuery<Customer> query) : base(query)
        {
            Arguments = new CustomerArgumentsBuilder(base.InnerQuery);
        }

        public CustomerOperationQueryBuilder Addresses(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("addresses");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerOperationQueryBuilder AddressesV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressConnectionQueryBuilder> build)
        {
            var query = new Query<MailingAddressConnection>("addressesV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddressConnection>(query);
            return this;
        }

        public CustomerOperationQueryBuilder AmountSpent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amountSpent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CustomerOperationQueryBuilder CanDelete()
        {
            base.InnerQuery.AddField("canDelete");
            return this;
        }

        public CustomerOperationQueryBuilder CompanyContactProfiles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("companyContactProfiles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CustomerOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CustomerOperationQueryBuilder DataSaleOptOut()
        {
            base.InnerQuery.AddField("dataSaleOptOut");
            return this;
        }

        public CustomerOperationQueryBuilder DefaultAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("defaultAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerOperationQueryBuilder DefaultEmailAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailAddressQueryBuilder> build)
        {
            var query = new Query<CustomerEmailAddress>("defaultEmailAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailAddress>(query);
            return this;
        }

        public CustomerOperationQueryBuilder DefaultPhoneNumber(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder> build)
        {
            var query = new Query<CustomerPhoneNumber>("defaultPhoneNumber");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPhoneNumber>(query);
            return this;
        }

        public CustomerOperationQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        [Obsolete("Use `defaultEmailAddress.emailAddress` instead.")]
        public CustomerOperationQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public CustomerOperationQueryBuilder EmailMarketingConsent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailMarketingConsentStateQueryBuilder> build)
        {
            var query = new Query<CustomerEmailMarketingConsentState>("emailMarketingConsent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailMarketingConsentStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailMarketingConsentState>(query);
            return this;
        }

        public CustomerOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CustomerOperationQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        [Obsolete("To query for comments on the timeline, use the `events` connection and a query argument containing `verb:comment`, or look for a CommentEvent in the `__typename` of `events`.")]
        public CustomerOperationQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public CustomerOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerOperationQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public CustomerOperationQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CustomerOperationQueryBuilder LastOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("lastOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public CustomerOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public CustomerOperationQueryBuilder LifetimeDuration()
        {
            base.InnerQuery.AddField("lifetimeDuration");
            return this;
        }

        public CustomerOperationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CustomerOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public CustomerOperationQueryBuilder Mergeable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeableQueryBuilder> build)
        {
            var query = new Query<CustomerMergeable>("mergeable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeable>(query);
            return this;
        }

        public CustomerOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public CustomerOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public CustomerOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public CustomerOperationQueryBuilder MultipassIdentifier()
        {
            base.InnerQuery.AddField("multipassIdentifier");
            return this;
        }

        public CustomerOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public CustomerOperationQueryBuilder NumberOfOrders()
        {
            base.InnerQuery.AddField("numberOfOrders");
            return this;
        }

        public CustomerOperationQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public CustomerOperationQueryBuilder PaymentMethods(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodConnection>("paymentMethods");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodConnection>(query);
            return this;
        }

        [Obsolete("Use `defaultPhoneNumber.phoneNumber` instead.")]
        public CustomerOperationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public CustomerOperationQueryBuilder ProductSubscriberStatus()
        {
            base.InnerQuery.AddField("productSubscriberStatus");
            return this;
        }

        public CustomerOperationQueryBuilder SmsMarketingConsent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSmsMarketingConsentStateQueryBuilder> build)
        {
            var query = new Query<CustomerSmsMarketingConsentState>("smsMarketingConsent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSmsMarketingConsentStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSmsMarketingConsentState>(query);
            return this;
        }

        public CustomerOperationQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }

        public CustomerOperationQueryBuilder Statistics(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerStatisticsQueryBuilder> build)
        {
            var query = new Query<CustomerStatistics>("statistics");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerStatisticsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerStatistics>(query);
            return this;
        }

        public CustomerOperationQueryBuilder StoreCreditAccounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountConnection>("storeCreditAccounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountConnection>(query);
            return this;
        }

        public CustomerOperationQueryBuilder SubscriptionContracts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractConnection>("subscriptionContracts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractConnection>(query);
            return this;
        }

        public CustomerOperationQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public CustomerOperationQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public CustomerOperationQueryBuilder TaxExemptions()
        {
            base.InnerQuery.AddField("taxExemptions");
            return this;
        }

        [Obsolete("Use `defaultEmailAddress.marketingUnsubscribeUrl` instead.")]
        public CustomerOperationQueryBuilder UnsubscribeUrl()
        {
            base.InnerQuery.AddField("unsubscribeUrl");
            return this;
        }

        public CustomerOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        [Obsolete("Use `defaultEmailAddress.validFormat` instead.")]
        public CustomerOperationQueryBuilder ValidEmailAddress()
        {
            base.InnerQuery.AddField("validEmailAddress");
            return this;
        }

        public CustomerOperationQueryBuilder VerifiedEmail()
        {
            base.InnerQuery.AddField("verifiedEmail");
            return this;
        }
    }
}