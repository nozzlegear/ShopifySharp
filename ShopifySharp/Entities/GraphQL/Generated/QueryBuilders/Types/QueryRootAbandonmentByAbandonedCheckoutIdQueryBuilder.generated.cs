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
    public sealed class QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder : FieldsQueryBuilderBase<Abandonment, QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder>, IHasArguments<QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder>
    {
        public QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder Arguments { get; }
        protected override QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder Self => this;

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder(string name) : base(new Query<Abandonment>(name))
        {
            Arguments = new QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder(IQuery<Abandonment> query) : base(query)
        {
            Arguments = new QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder SetArguments(Action<QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder AbandonedCheckoutPayload(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("abandonedCheckoutPayload");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckout>(query);
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder AbandonmentType()
        {
            base.InnerQuery.AddField("abandonmentType");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder CartUrl()
        {
            base.InnerQuery.AddField("cartUrl");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder CustomerHasNoDraftOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoDraftOrderSinceAbandonment");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder CustomerHasNoOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoOrderSinceAbandonment");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder DaysSinceLastAbandonmentEmail()
        {
            base.InnerQuery.AddField("daysSinceLastAbandonmentEmail");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder EmailSentAt()
        {
            base.InnerQuery.AddField("emailSentAt");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder EmailState()
        {
            base.InnerQuery.AddField("emailState");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder HoursSinceLastAbandonedCheckout()
        {
            base.InnerQuery.AddField("hoursSinceLastAbandonedCheckout");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder InventoryAvailable()
        {
            base.InnerQuery.AddField("inventoryAvailable");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder IsFromCustomStorefront()
        {
            base.InnerQuery.AddField("isFromCustomStorefront");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder IsFromOnlineStore()
        {
            base.InnerQuery.AddField("isFromOnlineStore");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder IsFromShopApp()
        {
            base.InnerQuery.AddField("isFromShopApp");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder IsFromShopPay()
        {
            base.InnerQuery.AddField("isFromShopPay");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder IsMostSignificantAbandonment()
        {
            base.InnerQuery.AddField("isMostSignificantAbandonment");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder LastBrowseAbandonmentDate()
        {
            base.InnerQuery.AddField("lastBrowseAbandonmentDate");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder LastCartAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCartAbandonmentDate");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder LastCheckoutAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCheckoutAbandonmentDate");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder MostRecentStep()
        {
            base.InnerQuery.AddField("mostRecentStep");
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder ProductsAddedToCart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsAddedToCart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder ProductsViewed(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsViewed");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdQueryBuilder VisitStartedAt()
        {
            base.InnerQuery.AddField("visitStartedAt");
            return this;
        }
    }
}