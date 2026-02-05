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
    public sealed class QueryRootQueryBuilder : FieldsQueryBuilderBase<QueryRoot, QueryRootQueryBuilder>
    {
        protected override QueryRootQueryBuilder Self => this;

        public QueryRootQueryBuilder() : this("queryRoot")
        {
        }

        public QueryRootQueryBuilder(string name) : base(new Query<QueryRoot>(name))
        {
        }

        public QueryRootQueryBuilder(IQuery<QueryRoot> query) : base(query)
        {
        }

        public QueryRootQueryBuilder AbandonedCheckouts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutConnectionQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutConnection>("abandonedCheckouts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder AbandonedCheckoutsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("abandonedCheckoutsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder Abandonment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder> build)
        {
            var query = new Query<Abandonment>("abandonment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Abandonment>(query);
            return this;
        }

        public QueryRootQueryBuilder AbandonmentByAbandonedCheckoutId(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder> build)
        {
            var query = new Query<Abandonment>("abandonmentByAbandonedCheckoutId");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Abandonment>(query);
            return this;
        }

        public QueryRootQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootQueryBuilder AppByHandle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("appByHandle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootQueryBuilder AppByKey(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("appByKey");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootQueryBuilder AppDiscountType(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder> build)
        {
            var query = new Query<AppDiscountType>("appDiscountType");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountType>(query);
            return this;
        }

        public QueryRootQueryBuilder AppDiscountTypes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder> build)
        {
            var query = new Query<AppDiscountType>("appDiscountTypes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountType>(query);
            return this;
        }

        public QueryRootQueryBuilder AppDiscountTypesNodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeConnectionQueryBuilder> build)
        {
            var query = new Query<AppDiscountTypeConnection>("appDiscountTypesNodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountTypeConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder AppInstallation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("appInstallation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public QueryRootQueryBuilder AppInstallations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationConnectionQueryBuilder> build)
        {
            var query = new Query<AppInstallationConnection>("appInstallations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Article(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("article");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public QueryRootQueryBuilder ArticleAuthors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorConnectionQueryBuilder> build)
        {
            var query = new Query<ArticleAuthorConnection>("articleAuthors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleAuthorConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Articles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleConnectionQueryBuilder> build)
        {
            var query = new Query<ArticleConnection>("articles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ArticleTags()
        {
            base.InnerQuery.AddField("articleTags");
            return this;
        }

        public QueryRootQueryBuilder AssignedFulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("assignedFulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public QueryRootQueryBuilder AutomaticDiscountNodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNodeConnection>("automaticDiscountNodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNodeConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder AutomaticDiscounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticConnection>("automaticDiscounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder AutomaticDiscountSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("automaticDiscountSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder AvailableBackupRegions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketRegionQueryBuilder> build)
        {
            var query = new Query<IMarketRegion>("availableBackupRegions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMarketRegion>(query);
            return this;
        }

        public QueryRootQueryBuilder AvailableCarrierServices(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceAndLocationsQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierServiceAndLocations>("availableCarrierServices");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceAndLocationsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierServiceAndLocations>(query);
            return this;
        }

        public QueryRootQueryBuilder AvailableLocales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocaleQueryBuilder> build)
        {
            var query = new Query<Locale>("availableLocales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Locale>(query);
            return this;
        }

        public QueryRootQueryBuilder BackupRegion(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketRegionQueryBuilder> build)
        {
            var query = new Query<IMarketRegion>("backupRegion");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMarketRegion>(query);
            return this;
        }

        public QueryRootQueryBuilder Blog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("blog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }

        public QueryRootQueryBuilder Blogs(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogConnectionQueryBuilder> build)
        {
            var query = new Query<BlogConnection>("blogs");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder BlogsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("blogsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public QueryRootQueryBuilder BulkOperations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationConnectionQueryBuilder> build)
        {
            var query = new Query<BulkOperationConnection>("bulkOperations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder BusinessEntities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder> build)
        {
            var query = new Query<BusinessEntity>("businessEntities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntity>(query);
            return this;
        }

        public QueryRootQueryBuilder BusinessEntity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder> build)
        {
            var query = new Query<BusinessEntity>("businessEntity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntity>(query);
            return this;
        }

        public QueryRootQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public QueryRootQueryBuilder CarrierServices(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierServiceConnection>("carrierServices");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierServiceConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CartTransforms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformConnectionQueryBuilder> build)
        {
            var query = new Query<CartTransformConnection>("cartTransforms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CashTrackingSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashTrackingSessionQueryBuilder> build)
        {
            var query = new Query<CashTrackingSession>("cashTrackingSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashTrackingSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSession>(query);
            return this;
        }

        public QueryRootQueryBuilder CashTrackingSessions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashTrackingSessionConnectionQueryBuilder> build)
        {
            var query = new Query<CashTrackingSessionConnection>("cashTrackingSessions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashTrackingSessionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSessionConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Catalog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public QueryRootQueryBuilder CatalogOperations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceOperationQueryBuilder> build)
        {
            var query = new Query<IResourceOperation>("catalogOperations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IResourceOperation>(query);
            return this;
        }

        public QueryRootQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogConnectionQueryBuilder> build)
        {
            var query = new Query<CatalogConnection>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CatalogsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("catalogsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder Channel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public QueryRootQueryBuilder Channels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("channels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CheckoutBranding(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingQueryBuilder> build)
        {
            var query = new Query<CheckoutBranding>("checkoutBranding");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBranding>(query);
            return this;
        }

        public QueryRootQueryBuilder CheckoutProfile(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileQueryBuilder> build)
        {
            var query = new Query<CheckoutProfile>("checkoutProfile");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfile>(query);
            return this;
        }

        public QueryRootQueryBuilder CheckoutProfiles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileConnectionQueryBuilder> build)
        {
            var query = new Query<CheckoutProfileConnection>("checkoutProfiles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfileConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public QueryRootQueryBuilder CodeDiscountNodeByCode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNodeByCode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public QueryRootQueryBuilder CodeDiscountNodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNodeConnection>("codeDiscountNodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNodeConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CodeDiscountSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("codeDiscountSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Collection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public QueryRootQueryBuilder CollectionByHandle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collectionByHandle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public QueryRootQueryBuilder CollectionByIdentifier(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collectionByIdentifier");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public QueryRootQueryBuilder CollectionRulesConditions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionRuleConditionsQueryBuilder> build)
        {
            var query = new Query<CollectionRuleConditions>("collectionRulesConditions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionRuleConditionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionRuleConditions>(query);
            return this;
        }

        public QueryRootQueryBuilder Collections(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CollectionSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("collectionSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CollectionsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("collectionsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder Comment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("comment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public QueryRootQueryBuilder Comments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentConnectionQueryBuilder> build)
        {
            var query = new Query<CommentConnection>("comments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Companies(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyConnection>("companies");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CompaniesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("companiesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public QueryRootQueryBuilder CompanyContact(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("companyContact");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public QueryRootQueryBuilder CompanyContactRole(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder> build)
        {
            var query = new Query<CompanyContactRole>("companyContactRole");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRole>(query);
            return this;
        }

        public QueryRootQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public QueryRootQueryBuilder CompanyLocations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyLocationConnection>("companyLocations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ConsentPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ConsentPolicyQueryBuilder> build)
        {
            var query = new Query<ConsentPolicy>("consentPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ConsentPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ConsentPolicy>(query);
            return this;
        }

        public QueryRootQueryBuilder ConsentPolicyRegions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ConsentPolicyRegionQueryBuilder> build)
        {
            var query = new Query<ConsentPolicyRegion>("consentPolicyRegions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ConsentPolicyRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ConsentPolicyRegion>(query);
            return this;
        }

        public QueryRootQueryBuilder CurrentAppInstallation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("currentAppInstallation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public QueryRootQueryBuilder CurrentBulkOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("currentBulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public QueryRootQueryBuilder CurrentStaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("currentStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public QueryRootQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerAccountPage(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerAccountPageQueryBuilder> build)
        {
            var query = new Query<ICustomerAccountPage>("customerAccountPage");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerAccountPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerAccountPage>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerAccountPages(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerAccountPageConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerAccountPageConnection>("customerAccountPages");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerAccountPageConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerAccountPageConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerByIdentifier(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customerByIdentifier");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerMergeJobStatus(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeRequestQueryBuilder> build)
        {
            var query = new Query<CustomerMergeRequest>("customerMergeJobStatus");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeRequest>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerMergePreview(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergePreviewQueryBuilder> build)
        {
            var query = new Query<CustomerMergePreview>("customerMergePreview");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergePreviewQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergePreview>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public QueryRootQueryBuilder Customers(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerConnection>("customers");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("customerSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomersCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("customersCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerSegmentMembers(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSegmentMemberConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerSegmentMemberConnection>("customerSegmentMembers");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSegmentMemberConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSegmentMemberConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerSegmentMembership(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMembershipResponseQueryBuilder> build)
        {
            var query = new Query<SegmentMembershipResponse>("customerSegmentMembership");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMembershipResponseQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMembershipResponse>(query);
            return this;
        }

        public QueryRootQueryBuilder CustomerSegmentMembersQuery(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSegmentMembersQueryQueryBuilder> build)
        {
            var query = new Query<CustomerSegmentMembersQuery>("customerSegmentMembersQuery");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSegmentMembersQueryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSegmentMembersQuery>(query);
            return this;
        }

        public QueryRootQueryBuilder DeletionEvents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeletionEventConnectionQueryBuilder> build)
        {
            var query = new Query<DeletionEventConnection>("deletionEvents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeletionEventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeletionEventConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder DeliveryCustomization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("deliveryCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }

        public QueryRootQueryBuilder DeliveryCustomizations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationConnection>("deliveryCustomizations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder DeliveryProfile(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("deliveryProfile");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public QueryRootQueryBuilder DeliveryProfiles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileConnection>("deliveryProfiles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder DeliveryPromiseParticipants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseParticipantConnection>("deliveryPromiseParticipants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseParticipantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseParticipantConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder DeliveryPromiseProvider(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseProviderQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseProvider>("deliveryPromiseProvider");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseProviderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseProvider>(query);
            return this;
        }

        public QueryRootQueryBuilder DeliveryPromiseSettings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseSettingQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseSetting>("deliveryPromiseSettings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseSettingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseSetting>(query);
            return this;
        }

        public QueryRootQueryBuilder DeliverySettings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliverySettingQueryBuilder> build)
        {
            var query = new Query<DeliverySetting>("deliverySettings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliverySettingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliverySetting>(query);
            return this;
        }

        public QueryRootQueryBuilder DiscountCodesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("discountCodesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder DiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountNodeQueryBuilder> build)
        {
            var query = new Query<DiscountNode>("discountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountNode>(query);
            return this;
        }

        public QueryRootQueryBuilder DiscountNodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountNodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountNodeConnection>("discountNodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountNodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountNodeConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder DiscountNodesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("discountNodesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder DiscountRedeemCodeBulkCreation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreation>("discountRedeemCodeBulkCreation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreation>(query);
            return this;
        }

        public QueryRootQueryBuilder DiscountRedeemCodeSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("discountRedeemCodeSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Dispute(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("dispute");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDispute>(query);
            return this;
        }

        public QueryRootQueryBuilder DisputeEvidence(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEvidence>("disputeEvidence");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEvidence>(query);
            return this;
        }

        public QueryRootQueryBuilder Disputes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeConnectionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeConnection>("disputes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Domain(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainQueryBuilder> build)
        {
            var query = new Query<Domain>("domain");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Domain>(query);
            return this;
        }

        public QueryRootQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public QueryRootQueryBuilder DraftOrderAvailableDeliveryOptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderAvailableDeliveryOptionsQueryBuilder> build)
        {
            var query = new Query<DraftOrderAvailableDeliveryOptions>("draftOrderAvailableDeliveryOptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderAvailableDeliveryOptionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderAvailableDeliveryOptions>(query);
            return this;
        }

        public QueryRootQueryBuilder DraftOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderConnection>("draftOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder DraftOrderSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("draftOrderSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder DraftOrdersCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("draftOrdersCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder DraftOrderTag(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderTagQueryBuilder> build)
        {
            var query = new Query<DraftOrderTag>("draftOrderTag");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderTag>(query);
            return this;
        }

        public QueryRootQueryBuilder Event(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventQueryBuilder> build)
        {
            var query = new Query<IEvent>("event");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IEvent>(query);
            return this;
        }

        public QueryRootQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder EventsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("eventsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder Files(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileConnectionQueryBuilder> build)
        {
            var query = new Query<FileConnection>("files");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder FileSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("fileSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder FinanceAppAccessPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinanceAppAccessPolicyQueryBuilder> build)
        {
            var query = new Query<FinanceAppAccessPolicy>("financeAppAccessPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinanceAppAccessPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FinanceAppAccessPolicy>(query);
            return this;
        }

        public QueryRootQueryBuilder FinanceKycInformation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinanceKycInformationQueryBuilder> build)
        {
            var query = new Query<FinanceKycInformation>("financeKycInformation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinanceKycInformationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FinanceKycInformation>(query);
            return this;
        }

        public QueryRootQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public QueryRootQueryBuilder FulfillmentConstraintRules(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRule>("fulfillmentConstraintRules");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRule>(query);
            return this;
        }

        public QueryRootQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public QueryRootQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder FulfillmentService(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public QueryRootQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public QueryRootQueryBuilder GiftCardConfiguration(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardConfigurationQueryBuilder> build)
        {
            var query = new Query<GiftCardConfiguration>("giftCardConfiguration");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardConfiguration>(query);
            return this;
        }

        public QueryRootQueryBuilder GiftCards(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardConnectionQueryBuilder> build)
        {
            var query = new Query<GiftCardConnection>("giftCards");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder GiftCardsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("giftCardsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public QueryRootQueryBuilder InventoryItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryItemConnection>("inventoryItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItemConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public QueryRootQueryBuilder InventoryProperties(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryPropertiesQueryBuilder> build)
        {
            var query = new Query<InventoryProperties>("inventoryProperties");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryPropertiesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryProperties>(query);
            return this;
        }

        public QueryRootQueryBuilder InventoryShipment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder> build)
        {
            var query = new Query<InventoryShipment>("inventoryShipment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipment>(query);
            return this;
        }

        public QueryRootQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public QueryRootQueryBuilder InventoryTransfers(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryTransferConnection>("inventoryTransfers");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public QueryRootQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootQueryBuilder LocationByIdentifier(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("locationByIdentifier");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootQueryBuilder Locations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("locations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder LocationsAvailableForDeliveryProfiles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("locationsAvailableForDeliveryProfiles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootQueryBuilder LocationsAvailableForDeliveryProfilesConnection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("locationsAvailableForDeliveryProfilesConnection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder LocationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("locationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder ManualHoldsFulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("manualHoldsFulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketByGeography(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("marketByGeography");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketingActivities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityConnectionQueryBuilder> build)
        {
            var query = new Query<MarketingActivityConnection>("marketingActivities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketingEvent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("marketingEvent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketingEvents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEventConnectionQueryBuilder> build)
        {
            var query = new Query<MarketingEventConnection>("marketingEvents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEventConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketLocalizableResource(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResource>("marketLocalizableResource");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResource>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketLocalizableResources(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableResourceConnectionQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResourceConnection>("marketLocalizableResources");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResourceConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketLocalizableResourcesByIds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableResourceConnectionQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResourceConnection>("marketLocalizableResourcesByIds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResourceConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Markets(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketConnectionQueryBuilder> build)
        {
            var query = new Query<MarketConnection>("markets");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder MarketsResolvedValues(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketsResolvedValuesQueryBuilder> build)
        {
            var query = new Query<MarketsResolvedValues>("marketsResolvedValues");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketsResolvedValuesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsResolvedValues>(query);
            return this;
        }

        public QueryRootQueryBuilder Menu(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("menu");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public QueryRootQueryBuilder Menus(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuConnectionQueryBuilder> build)
        {
            var query = new Query<MenuConnection>("menus");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder MetafieldDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("metafieldDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public QueryRootQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder MetafieldDefinitionTypes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("metafieldDefinitionTypes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public QueryRootQueryBuilder Metaobject(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("metaobject");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public QueryRootQueryBuilder MetaobjectByHandle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("metaobjectByHandle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public QueryRootQueryBuilder MetaobjectDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("metaobjectDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public QueryRootQueryBuilder MetaobjectDefinitionByType(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("metaobjectDefinitionByType");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public QueryRootQueryBuilder MetaobjectDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinitionConnection>("metaobjectDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinitionConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Metaobjects(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectConnectionQueryBuilder> build)
        {
            var query = new Query<MetaobjectConnection>("metaobjects");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder MobilePlatformApplications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationConnectionQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationConnection>("mobilePlatformApplications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NodeQueryBuilder> build)
        {
            var query = new Query<INode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<INode>(query);
            return this;
        }

        public QueryRootQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NodeQueryBuilder> build)
        {
            var query = new Query<INode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<INode>(query);
            return this;
        }

        public QueryRootQueryBuilder OnlineStore(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreQueryBuilder> build)
        {
            var query = new Query<OnlineStore>("onlineStore");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStore>(query);
            return this;
        }

        public QueryRootQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootQueryBuilder OrderByIdentifier(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("orderByIdentifier");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public QueryRootQueryBuilder OrderPaymentStatus(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderPaymentStatusQueryBuilder> build)
        {
            var query = new Query<OrderPaymentStatus>("orderPaymentStatus");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderPaymentStatusQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderPaymentStatus>(query);
            return this;
        }

        public QueryRootQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder OrderSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("orderSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder OrdersCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("ordersCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder Page(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("page");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Page>(query);
            return this;
        }

        public QueryRootQueryBuilder Pages(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageConnectionQueryBuilder> build)
        {
            var query = new Query<PageConnection>("pages");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder PagesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("pagesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder PaymentCustomization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("paymentCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public QueryRootQueryBuilder PaymentCustomizations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationConnectionQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationConnection>("paymentCustomizations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder PaymentTermsTemplates(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsTemplateQueryBuilder> build)
        {
            var query = new Query<PaymentTermsTemplate>("paymentTermsTemplates");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsTemplate>(query);
            return this;
        }

        public QueryRootQueryBuilder PendingOrdersCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("pendingOrdersCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder PointOfSaleDevice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("pointOfSaleDevice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public QueryRootQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public QueryRootQueryBuilder PriceLists(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListConnectionQueryBuilder> build)
        {
            var query = new Query<PriceListConnection>("priceLists");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder PrimaryMarket(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("primaryMarket");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public QueryRootQueryBuilder PrivacySettings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacySettingsQueryBuilder> build)
        {
            var query = new Query<PrivacySettings>("privacySettings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacySettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PrivacySettings>(query);
            return this;
        }

        public QueryRootQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductByHandle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("productByHandle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductByIdentifier(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("productByIdentifier");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductDuplicateJob(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductDuplicateJobQueryBuilder> build)
        {
            var query = new Query<ProductDuplicateJob>("productDuplicateJob");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductDuplicateJobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductDuplicateJob>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductFeed(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedQueryBuilder> build)
        {
            var query = new Query<ProductFeed>("productFeed");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeed>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductFeeds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedConnectionQueryBuilder> build)
        {
            var query = new Query<ProductFeedConnection>("productFeeds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeedConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOperationQueryBuilder> build)
        {
            var query = new Query<IProductOperation>("productOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IProductOperation>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductResourceFeedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductResourceFeedbackQueryBuilder> build)
        {
            var query = new Query<ProductResourceFeedback>("productResourceFeedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductResourceFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductResourceFeedback>(query);
            return this;
        }

        public QueryRootQueryBuilder Products(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("productSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductTags(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productTags");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductTypes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productTypes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductVariant(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariant");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductVariantByIdentifier(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariantByIdentifier");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductVariantsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productVariantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder ProductVendors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder> build)
        {
            var query = new Query<StringConnection>("productVendors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder PublicApiVersions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ApiVersionQueryBuilder> build)
        {
            var query = new Query<ApiVersion>("publicApiVersions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ApiVersionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ApiVersion>(query);
            return this;
        }

        public QueryRootQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public QueryRootQueryBuilder Publications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationConnectionQueryBuilder> build)
        {
            var query = new Query<PublicationConnection>("publications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder PublicationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("publicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder PublishedProductsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("publishedProductsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder Refund(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refund");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public QueryRootQueryBuilder Return(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public QueryRootQueryBuilder ReturnableFulfillment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillment>("returnableFulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillment>(query);
            return this;
        }

        public QueryRootQueryBuilder ReturnableFulfillments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentConnection>("returnableFulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ReturnCalculate(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedReturnQueryBuilder> build)
        {
            var query = new Query<CalculatedReturn>("returnCalculate");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedReturn>(query);
            return this;
        }

        public QueryRootQueryBuilder ReturnReasonDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinitionConnection>("returnReasonDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinitionConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ReverseDelivery(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryQueryBuilder> build)
        {
            var query = new Query<ReverseDelivery>("reverseDelivery");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDelivery>(query);
            return this;
        }

        public QueryRootQueryBuilder ReverseFulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrder>("reverseFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrder>(query);
            return this;
        }

        public QueryRootQueryBuilder ScriptTag(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("scriptTag");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTag>(query);
            return this;
        }

        public QueryRootQueryBuilder ScriptTags(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagConnectionQueryBuilder> build)
        {
            var query = new Query<ScriptTagConnection>("scriptTags");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTagConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Segment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("segment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }

        public QueryRootQueryBuilder SegmentFilters(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterConnectionQueryBuilder> build)
        {
            var query = new Query<SegmentFilterConnection>("segmentFilters");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentFilterConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder SegmentFilterSuggestions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterConnectionQueryBuilder> build)
        {
            var query = new Query<SegmentFilterConnection>("segmentFilterSuggestions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentFilterConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder SegmentMigrations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMigrationConnectionQueryBuilder> build)
        {
            var query = new Query<SegmentMigrationConnection>("segmentMigrations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMigrationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMigrationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Segments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentConnectionQueryBuilder> build)
        {
            var query = new Query<SegmentConnection>("segments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder SegmentsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("segmentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder SegmentValueSuggestions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentValueConnectionQueryBuilder> build)
        {
            var query = new Query<SegmentValueConnection>("segmentValueSuggestions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentValueConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentValueConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder SellingPlanGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("sellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public QueryRootQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ServerPixel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder> build)
        {
            var query = new Query<ServerPixel>("serverPixel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ServerPixel>(query);
            return this;
        }

        public QueryRootQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public QueryRootQueryBuilder ShopBillingPreferences(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopBillingPreferencesQueryBuilder> build)
        {
            var query = new Query<ShopBillingPreferences>("shopBillingPreferences");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopBillingPreferencesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopBillingPreferences>(query);
            return this;
        }

        public QueryRootQueryBuilder ShopifyFunction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("shopifyFunction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }

        public QueryRootQueryBuilder ShopifyFunctions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionConnectionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunctionConnection>("shopifyFunctions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunctionConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder ShopifyPaymentsAccount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAccount>("shopifyPaymentsAccount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAccount>(query);
            return this;
        }

        public QueryRootQueryBuilder ShopifyqlQuery(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyqlQueryResponseQueryBuilder> build)
        {
            var query = new Query<ShopifyqlQueryResponse>("shopifyqlQuery");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyqlQueryResponseQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyqlQueryResponse>(query);
            return this;
        }

        public QueryRootQueryBuilder ShopLocales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder> build)
        {
            var query = new Query<ShopLocale>("shopLocales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopLocale>(query);
            return this;
        }

        public QueryRootQueryBuilder ShopPayPaymentRequestReceipt(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceipt>("shopPayPaymentRequestReceipt");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceipt>(query);
            return this;
        }

        public QueryRootQueryBuilder ShopPayPaymentRequestReceipts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptConnectionQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceiptConnection>("shopPayPaymentRequestReceipts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceiptConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public QueryRootQueryBuilder StaffMembers(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberConnectionQueryBuilder> build)
        {
            var query = new Query<StaffMemberConnection>("staffMembers");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder StandardMetafieldDefinitionTemplates(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateConnectionQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplateConnection>("standardMetafieldDefinitionTemplates");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplateConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder StoreCreditAccount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("storeCreditAccount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccount>(query);
            return this;
        }

        public QueryRootQueryBuilder SubscriptionBillingAttempt(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("subscriptionBillingAttempt");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public QueryRootQueryBuilder SubscriptionBillingAttempts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptConnection>("subscriptionBillingAttempts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder SubscriptionBillingCycle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("subscriptionBillingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public QueryRootQueryBuilder SubscriptionBillingCycleBulkResults(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleConnection>("subscriptionBillingCycleBulkResults");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder SubscriptionBillingCycles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleConnection>("subscriptionBillingCycles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder SubscriptionContract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("subscriptionContract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public QueryRootQueryBuilder SubscriptionContracts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractConnection>("subscriptionContracts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder SubscriptionDraft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("subscriptionDraft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public QueryRootQueryBuilder Taxonomy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyQueryBuilder> build)
        {
            var query = new Query<Taxonomy>("taxonomy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Taxonomy>(query);
            return this;
        }

        public QueryRootQueryBuilder TenderTransactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TenderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<TenderTransactionConnection>("tenderTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TenderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TenderTransactionConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder Theme(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("theme");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public QueryRootQueryBuilder Themes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeConnectionQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeConnection>("themes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder TranslatableResource(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceQueryBuilder> build)
        {
            var query = new Query<TranslatableResource>("translatableResource");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResource>(query);
            return this;
        }

        public QueryRootQueryBuilder TranslatableResources(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceConnection>("translatableResources");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder TranslatableResourcesByIds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceConnection>("translatableResourcesByIds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder UrlRedirect(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("urlRedirect");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }

        public QueryRootQueryBuilder UrlRedirectImport(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImport>("urlRedirectImport");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImport>(query);
            return this;
        }

        public QueryRootQueryBuilder UrlRedirects(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectConnectionQueryBuilder> build)
        {
            var query = new Query<UrlRedirectConnection>("urlRedirects");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder UrlRedirectSavedSearches(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder> build)
        {
            var query = new Query<SavedSearchConnection>("urlRedirectSavedSearches");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder UrlRedirectsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("urlRedirectsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder Validation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("validation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Validation>(query);
            return this;
        }

        public QueryRootQueryBuilder Validations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationConnectionQueryBuilder> build)
        {
            var query = new Query<ValidationConnection>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }

        public QueryRootQueryBuilder WebhookSubscriptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionConnectionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscriptionConnection>("webhookSubscriptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscriptionConnection>(query);
            return this;
        }

        public QueryRootQueryBuilder WebhookSubscriptionsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("webhookSubscriptionsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootQueryBuilder WebPixel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebPixelQueryBuilder> build)
        {
            var query = new Query<WebPixel>("webPixel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebPixel>(query);
            return this;
        }

        public QueryRootQueryBuilder WebPresences(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceConnection>("webPresences");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceConnection>(query);
            return this;
        }

        [Obsolete("Use `automaticDiscountNode` instead.")]
        public QueryRootQueryBuilder AutomaticDiscount(Action<DiscountAutomaticUnionCasesBuilder> build)
        {
            var query = new Query<DiscountAutomatic>("automaticDiscount");
            var unionBuilder = new DiscountAutomaticUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public QueryRootQueryBuilder MobilePlatformApplication(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("mobilePlatformApplication");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}