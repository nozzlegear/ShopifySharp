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
    public sealed class QueryRootNodeQueryBuilder : FieldsQueryBuilderBase<INode, QueryRootNodeQueryBuilder>, IHasArguments<QueryRootNodeArgumentsBuilder>
    {
        public QueryRootNodeArgumentsBuilder Arguments { get; }
        protected override QueryRootNodeQueryBuilder Self => this;

        public QueryRootNodeQueryBuilder(string name) : base(new Query<INode>(name))
        {
            Arguments = new QueryRootNodeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootNodeQueryBuilder(IQuery<INode> query) : base(query)
        {
            Arguments = new QueryRootNodeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootNodeQueryBuilder SetArguments(Action<QueryRootNodeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootNodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootNodeQueryBuilder OnAbandonedCheckout(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("... on AbandonedCheckout");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAbandonedCheckoutLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItem>("... on AbandonedCheckoutLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAbandonment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonmentQueryBuilder> build)
        {
            var query = new Query<Abandonment>("... on Abandonment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAddAllProductsOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AddAllProductsOperationQueryBuilder> build)
        {
            var query = new Query<AddAllProductsOperation>("... on AddAllProductsOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AddAllProductsOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAdditionalFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AdditionalFeeQueryBuilder> build)
        {
            var query = new Query<AdditionalFee>("... on AdditionalFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AdditionalFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("... on App");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAppCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppCatalogQueryBuilder> build)
        {
            var query = new Query<AppCatalog>("... on AppCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAppCredit(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppCreditQueryBuilder> build)
        {
            var query = new Query<AppCredit>("... on AppCredit");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppCreditQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAppInstallation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("... on AppInstallation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAppPurchaseOneTime(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTime>("... on AppPurchaseOneTime");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAppRevenueAttributionRecord(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecord>("... on AppRevenueAttributionRecord");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAppSubscription(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("... on AppSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnAppUsageRecord(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordQueryBuilder> build)
        {
            var query = new Query<AppUsageRecord>("... on AppUsageRecord");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnArticle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("... on Article");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnBasicEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BasicEventQueryBuilder> build)
        {
            var query = new Query<BasicEvent>("... on BasicEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BasicEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnBlog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("... on Blog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnBulkOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("... on BulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnBusinessEntity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityQueryBuilder> build)
        {
            var query = new Query<BusinessEntity>("... on BusinessEntity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCalculatedOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("... on CalculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCartTransform(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformQueryBuilder> build)
        {
            var query = new Query<CartTransform>("... on CartTransform");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("... on CashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCashManagementCustomReasonCode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementCustomReasonCodeQueryBuilder> build)
        {
            var query = new Query<CashManagementCustomReasonCode>("... on CashManagementCustomReasonCode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementCustomReasonCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCashManagementDefaultReasonCode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementDefaultReasonCodeQueryBuilder> build)
        {
            var query = new Query<CashManagementDefaultReasonCode>("... on CashManagementDefaultReasonCode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementDefaultReasonCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCashManagementSystemReasonCode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementSystemReasonCodeQueryBuilder> build)
        {
            var query = new Query<CashManagementSystemReasonCode>("... on CashManagementSystemReasonCode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashManagementSystemReasonCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCashTrackingAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentQueryBuilder> build)
        {
            var query = new Query<CashTrackingAdjustment>("... on CashTrackingAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCashTrackingSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder> build)
        {
            var query = new Query<CashTrackingSession>("... on CashTrackingSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCatalogCsvOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogCsvOperationQueryBuilder> build)
        {
            var query = new Query<CatalogCsvOperation>("... on CatalogCsvOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogCsvOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnChannel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("... on Channel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnChannelDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelDefinitionQueryBuilder> build)
        {
            var query = new Query<ChannelDefinition>("... on ChannelDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnChannelInformation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelInformationQueryBuilder> build)
        {
            var query = new Query<ChannelInformation>("... on ChannelInformation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelInformationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCheckoutAndAccountsConfiguration(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfiguration>("... on CheckoutAndAccountsConfiguration");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCheckoutAndAccountsConfigurationOverride(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationOverrideQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationOverride>("... on CheckoutAndAccountsConfigurationOverride");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationOverrideQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCheckoutProfile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileQueryBuilder> build)
        {
            var query = new Query<CheckoutProfile>("... on CheckoutProfile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCollection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("... on Collection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCollectionConditionsSource(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSource>("... on CollectionConditionsSource");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCollectionSubCollectionsSource(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionSubCollectionsSource>("... on CollectionSubCollectionsSource");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnComment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("... on Comment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCommentEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentEventQueryBuilder> build)
        {
            var query = new Query<CommentEvent>("... on CommentEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCompany(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("... on Company");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCompanyAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder> build)
        {
            var query = new Query<CompanyAddress>("... on CompanyAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCompanyContact(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("... on CompanyContact");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCompanyContactRole(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleQueryBuilder> build)
        {
            var query = new Query<CompanyContactRole>("... on CompanyContactRole");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCompanyContactRoleAssignment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("... on CompanyContactRoleAssignment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("... on CompanyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCompanyLocationCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationCatalogQueryBuilder> build)
        {
            var query = new Query<CompanyLocationCatalog>("... on CompanyLocationCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCompanyLocationStaffMemberAssignment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignment>("... on CompanyLocationStaffMemberAssignment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnConsentPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ConsentPolicyQueryBuilder> build)
        {
            var query = new Query<ConsentPolicy>("... on ConsentPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ConsentPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCurrencyExchangeAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CurrencyExchangeAdjustmentQueryBuilder> build)
        {
            var query = new Query<CurrencyExchangeAdjustment>("... on CurrencyExchangeAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CurrencyExchangeAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCustomer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("... on Customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCustomerAccountAppExtensionPage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountAppExtensionPageQueryBuilder> build)
        {
            var query = new Query<CustomerAccountAppExtensionPage>("... on CustomerAccountAppExtensionPage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountAppExtensionPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCustomerAccountNativePage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountNativePageQueryBuilder> build)
        {
            var query = new Query<CustomerAccountNativePage>("... on CustomerAccountNativePage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountNativePageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCustomerPaymentMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("... on CustomerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCustomerSegmentMembersQuery(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMembersQueryQueryBuilder> build)
        {
            var query = new Query<CustomerSegmentMembersQuery>("... on CustomerSegmentMembersQuery");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMembersQueryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnCustomerVisit(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitQueryBuilder> build)
        {
            var query = new Query<CustomerVisit>("... on CustomerVisit");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryCarrierService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("... on DeliveryCarrierService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryConditionQueryBuilder> build)
        {
            var query = new Query<DeliveryCondition>("... on DeliveryCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryCountry(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryQueryBuilder> build)
        {
            var query = new Query<DeliveryCountry>("... on DeliveryCountry");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryCustomization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("... on DeliveryCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryLocationGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationGroup>("... on DeliveryLocationGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodQueryBuilder> build)
        {
            var query = new Query<DeliveryMethod>("... on DeliveryMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryMethodDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinition>("... on DeliveryMethodDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryParticipant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryParticipant>("... on DeliveryParticipant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryProfile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("... on DeliveryProfile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryProfileItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItem>("... on DeliveryProfileItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryPromiseParticipant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipant>("... on DeliveryPromiseParticipant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseParticipantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryPromiseProvider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseProviderQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseProvider>("... on DeliveryPromiseProvider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseProviderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryProvince(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProvinceQueryBuilder> build)
        {
            var query = new Query<DeliveryProvince>("... on DeliveryProvince");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProvinceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryRateDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryRateDefinition>("... on DeliveryRateDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDeliveryZone(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryZoneQueryBuilder> build)
        {
            var query = new Query<DeliveryZone>("... on DeliveryZone");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryZoneQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDiscountAutomaticBxgy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBxgy>("... on DiscountAutomaticBxgy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDiscountAutomaticNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("... on DiscountAutomaticNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDiscountCodeNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("... on DiscountCodeNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder> build)
        {
            var query = new Query<DiscountNode>("... on DiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDiscountRedeemCodeBulkCreation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreation>("... on DiscountRedeemCodeBulkCreation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDomain(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DomainQueryBuilder> build)
        {
            var query = new Query<Domain>("... on Domain");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DomainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDraftOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("... on DraftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDraftOrderLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItem>("... on DraftOrderLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDraftOrderTag(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderTagQueryBuilder> build)
        {
            var query = new Query<DraftOrderTag>("... on DraftOrderTag");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnDuty(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DutyQueryBuilder> build)
        {
            var query = new Query<Duty>("... on Duty");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnExchangeLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeLineItemQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItem>("... on ExchangeLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnExchangeV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2QueryBuilder> build)
        {
            var query = new Query<ExchangeV2>("... on ExchangeV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnExternalVideo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExternalVideoQueryBuilder> build)
        {
            var query = new Query<ExternalVideo>("... on ExternalVideo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExternalVideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("... on Fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillmentConstraintRule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRule>("... on FulfillmentConstraintRule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillmentEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventQueryBuilder> build)
        {
            var query = new Query<FulfillmentEvent>("... on FulfillmentEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillmentHold(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentHoldQueryBuilder> build)
        {
            var query = new Query<FulfillmentHold>("... on FulfillmentHold");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentHoldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillmentLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItem>("... on FulfillmentLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("... on FulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillmentOrderDestination(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderDestinationQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderDestination>("... on FulfillmentOrderDestination");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderDestinationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillmentOrderLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItem>("... on FulfillmentOrderLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnFulfillmentOrderMerchantRequest(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMerchantRequest>("... on FulfillmentOrderMerchantRequest");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnGenericFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GenericFileQueryBuilder> build)
        {
            var query = new Query<GenericFile>("... on GenericFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GenericFileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnGiftCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("... on GiftCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnGiftCardCashOutTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardCashOutTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardCashOutTransaction>("... on GiftCardCashOutTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardCashOutTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnGiftCardCreditTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardCreditTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardCreditTransaction>("... on GiftCardCreditTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnGiftCardDebitTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardDebitTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardDebitTransaction>("... on GiftCardDebitTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnIdentityProviderSubject(Action<ShopifySharp.GraphQL.QueryBuilders.Types.IdentityProviderSubjectQueryBuilder> build)
        {
            var query = new Query<IdentityProviderSubject>("... on IdentityProviderSubject");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.IdentityProviderSubjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("... on InventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("... on InventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryItemMeasurement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemMeasurementQueryBuilder> build)
        {
            var query = new Query<InventoryItemMeasurement>("... on InventoryItemMeasurement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemMeasurementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryLevel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("... on InventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryQuantity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityQueryBuilder> build)
        {
            var query = new Query<InventoryQuantity>("... on InventoryQuantity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryShipment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("... on InventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryShipmentLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItem>("... on InventoryShipmentLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryTransfer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("... on InventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnInventoryTransferLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItem>("... on InventoryTransferLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("... on LineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnLineItemGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemGroupQueryBuilder> build)
        {
            var query = new Query<LineItemGroup>("... on LineItemGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("... on Location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMailingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("... on MailingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMarket(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("... on Market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMarketCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder> build)
        {
            var query = new Query<MarketCatalog>("... on MarketCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMarketingActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("... on MarketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMarketingEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("... on MarketingEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMarketRegionCountry(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder> build)
        {
            var query = new Query<MarketRegionCountry>("... on MarketRegionCountry");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMarketRegionSubdivision(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder> build)
        {
            var query = new Query<MarketRegionSubdivision>("... on MarketRegionSubdivision");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMarketWebPresence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("... on MarketWebPresence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMediaImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder> build)
        {
            var query = new Query<MediaImage>("... on MediaImage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMenu(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("... on Menu");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMetafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("... on Metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMetafieldDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("... on MetafieldDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMetaobject(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("... on Metaobject");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnMetaobjectDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("... on MetaobjectDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnModel3d(Action<ShopifySharp.GraphQL.QueryBuilders.Types.Model3dQueryBuilder> build)
        {
            var query = new Query<Model3d>("... on Model3d");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.Model3dQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnOnlineStoreTheme(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("... on OnlineStoreTheme");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("... on Order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnOrderAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentQueryBuilder> build)
        {
            var query = new Query<OrderAdjustment>("... on OrderAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnOrderAttributionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinition>("... on OrderAttributionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnOrderCreateMandatePaymentJobResult(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateMandatePaymentJobResultQueryBuilder> build)
        {
            var query = new Query<OrderCreateMandatePaymentJobResult>("... on OrderCreateMandatePaymentJobResult");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateMandatePaymentJobResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnOrderDisputeSummary(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder> build)
        {
            var query = new Query<OrderDisputeSummary>("... on OrderDisputeSummary");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderDisputeSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnOrderEditSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("... on OrderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnOrderTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("... on OrderTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("... on Page");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPaymentCustomization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("... on PaymentCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPaymentMandate(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateQueryBuilder> build)
        {
            var query = new Query<PaymentMandate>("... on PaymentMandate");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPaymentSchedule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleQueryBuilder> build)
        {
            var query = new Query<PaymentSchedule>("... on PaymentSchedule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPaymentTerms(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("... on PaymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPaymentTermsTemplate(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsTemplateQueryBuilder> build)
        {
            var query = new Query<PaymentTermsTemplate>("... on PaymentTermsTemplate");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentTermsTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPointOfSaleDevice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("... on PointOfSaleDevice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPointOfSaleDevicePaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("... on PointOfSaleDevicePaymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("... on PriceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPriceRule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleQueryBuilder> build)
        {
            var query = new Query<PriceRule>("... on PriceRule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPriceRuleDiscountCode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleDiscountCodeQueryBuilder> build)
        {
            var query = new Query<PriceRuleDiscountCode>("... on PriceRuleDiscountCode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleDiscountCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProduct(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("... on Product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductBundleOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder> build)
        {
            var query = new Query<ProductBundleOperation>("... on ProductBundleOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductDeleteOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductDeleteOperationQueryBuilder> build)
        {
            var query = new Query<ProductDeleteOperation>("... on ProductDeleteOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductDeleteOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductDuplicateOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder> build)
        {
            var query = new Query<ProductDuplicateOperation>("... on ProductDuplicateOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductFeed(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedQueryBuilder> build)
        {
            var query = new Query<ProductFeed>("... on ProductFeed");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductOption(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionQueryBuilder> build)
        {
            var query = new Query<ProductOption>("... on ProductOption");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductOptionValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder> build)
        {
            var query = new Query<ProductOptionValue>("... on ProductOptionValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductSetOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductSetOperationQueryBuilder> build)
        {
            var query = new Query<ProductSetOperation>("... on ProductSetOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductSetOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductTaxonomyNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductTaxonomyNodeQueryBuilder> build)
        {
            var query = new Query<ProductTaxonomyNode>("... on ProductTaxonomyNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductTaxonomyNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductVariant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("... on ProductVariant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnProductVariantComponent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponent>("... on ProductVariantComponent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPublication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("... on Publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnPublicationResourceOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationResourceOperationQueryBuilder> build)
        {
            var query = new Query<PublicationResourceOperation>("... on PublicationResourceOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnQuantityPriceBreak(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreak>("... on QuantityPriceBreak");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnRefund(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("... on Refund");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnRefundShippingLine(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineQueryBuilder> build)
        {
            var query = new Query<RefundShippingLine>("... on RefundShippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReturn(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("... on Return");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReturnableFulfillment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillment>("... on ReturnableFulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReturnLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemQueryBuilder> build)
        {
            var query = new Query<ReturnLineItem>("... on ReturnLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReturnReasonDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("... on ReturnReasonDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReverseDelivery(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryQueryBuilder> build)
        {
            var query = new Query<ReverseDelivery>("... on ReverseDelivery");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReverseDeliveryLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLineItem>("... on ReverseDeliveryLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReverseFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrder>("... on ReverseFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReverseFulfillmentOrderDisposition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderDispositionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderDisposition>("... on ReverseFulfillmentOrderDisposition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderDispositionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnReverseFulfillmentOrderLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItem>("... on ReverseFulfillmentOrderLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnSaleAdditionalFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleAdditionalFeeQueryBuilder> build)
        {
            var query = new Query<SaleAdditionalFee>("... on SaleAdditionalFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleAdditionalFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnSavedSearch(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("... on SavedSearch");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnScriptTag(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("... on ScriptTag");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnSegment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("... on Segment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnSellingPlan(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanQueryBuilder> build)
        {
            var query = new Query<SellingPlan>("... on SellingPlan");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnSellingPlanGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("... on SellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnServerPixel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ServerPixelQueryBuilder> build)
        {
            var query = new Query<ServerPixel>("... on ServerPixel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ServerPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShippingLabel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelQueryBuilder> build)
        {
            var query = new Query<ShippingLabel>("... on ShippingLabel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShippingLabelPurchaseResult(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelPurchaseResultQueryBuilder> build)
        {
            var query = new Query<ShippingLabelPurchaseResult>("... on ShippingLabelPurchaseResult");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelPurchaseResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("... on Shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopAddressQueryBuilder> build)
        {
            var query = new Query<ShopAddress>("... on ShopAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopifyPaymentsAccount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAccount>("... on ShopifyPaymentsAccount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopifyPaymentsBalanceTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBalanceTransaction>("... on ShopifyPaymentsBalanceTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopifyPaymentsBankAccount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBankAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBankAccount>("... on ShopifyPaymentsBankAccount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBankAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopifyPaymentsDispute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("... on ShopifyPaymentsDispute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopifyPaymentsDisputeEvidence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEvidence>("... on ShopifyPaymentsDisputeEvidence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopifyPaymentsDisputeFileUpload(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("... on ShopifyPaymentsDisputeFileUpload");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopifyPaymentsDisputeFulfillment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFulfillmentQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFulfillment>("... on ShopifyPaymentsDisputeFulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopifyPaymentsPayout(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayout>("... on ShopifyPaymentsPayout");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnShopPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPolicyQueryBuilder> build)
        {
            var query = new Query<ShopPolicy>("... on ShopPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("... on StaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnStandardMetafieldDefinitionTemplate(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplate>("... on StandardMetafieldDefinitionTemplate");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnStoreCreditAccount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("... on StoreCreditAccount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnStoreCreditAccountCreditTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountCreditTransaction>("... on StoreCreditAccountCreditTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnStoreCreditAccountDebitRevertTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitRevertTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitRevertTransaction>("... on StoreCreditAccountDebitRevertTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitRevertTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnStoreCreditAccountDebitTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitTransaction>("... on StoreCreditAccountDebitTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnStorefrontAccessToken(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessToken>("... on StorefrontAccessToken");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnSubscriptionBillingAttempt(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("... on SubscriptionBillingAttempt");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnSubscriptionContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("... on SubscriptionContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnSubscriptionDraft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("... on SubscriptionDraft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnTaxonomyAttribute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyAttribute>("... on TaxonomyAttribute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnTaxonomyCategory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("... on TaxonomyCategory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnTaxonomyChoiceListAttribute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyChoiceListAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyChoiceListAttribute>("... on TaxonomyChoiceListAttribute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyChoiceListAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnTaxonomyMeasurementAttribute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyMeasurementAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyMeasurementAttribute>("... on TaxonomyMeasurementAttribute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyMeasurementAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnTaxonomyValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueQueryBuilder> build)
        {
            var query = new Query<TaxonomyValue>("... on TaxonomyValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnTenderTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionQueryBuilder> build)
        {
            var query = new Query<TenderTransaction>("... on TenderTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnTransactionFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TransactionFeeQueryBuilder> build)
        {
            var query = new Query<TransactionFee>("... on TransactionFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TransactionFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnUnverifiedReturnLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UnverifiedReturnLineItemQueryBuilder> build)
        {
            var query = new Query<UnverifiedReturnLineItem>("... on UnverifiedReturnLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UnverifiedReturnLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnUrlRedirect(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("... on UrlRedirect");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnUrlRedirectImport(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImport>("... on UrlRedirectImport");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnValidation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("... on Validation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnVideo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.VideoQueryBuilder> build)
        {
            var query = new Query<Video>("... on Video");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.VideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnWebhookSubscription(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("... on WebhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder OnWebPixel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebPixelQueryBuilder> build)
        {
            var query = new Query<WebPixel>("... on WebPixel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootNodeQueryBuilder Node(Action<NodeInterfaceCasesBuilder> build)
        {
            var query = new Query<INode>("node");
            var unionBuilder = new NodeInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}