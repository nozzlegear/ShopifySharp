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
    public sealed class QueryRootAbandonmentQueryBuilder : FieldsQueryBuilderBase<Abandonment, QueryRootAbandonmentQueryBuilder>, IHasArguments<QueryRootAbandonmentArgumentsBuilder>
    {
        public QueryRootAbandonmentArgumentsBuilder Arguments { get; }
        protected override QueryRootAbandonmentQueryBuilder Self => this;

        public QueryRootAbandonmentQueryBuilder(string name) : base(new Query<Abandonment>(name))
        {
            Arguments = new QueryRootAbandonmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAbandonmentQueryBuilder(IQuery<Abandonment> query) : base(query)
        {
            Arguments = new QueryRootAbandonmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAbandonmentQueryBuilder SetArguments(Action<QueryRootAbandonmentArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootAbandonmentQueryBuilder AbandonedCheckoutPayload(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("abandonedCheckoutPayload");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckout>(query);
            return this;
        }

        public QueryRootAbandonmentQueryBuilder AbandonmentType()
        {
            base.InnerQuery.AddField("abandonmentType");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootAbandonmentQueryBuilder CartUrl()
        {
            base.InnerQuery.AddField("cartUrl");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootAbandonmentQueryBuilder CustomerHasNoDraftOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoDraftOrderSinceAbandonment");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder CustomerHasNoOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoOrderSinceAbandonment");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder DaysSinceLastAbandonmentEmail()
        {
            base.InnerQuery.AddField("daysSinceLastAbandonmentEmail");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder EmailSentAt()
        {
            base.InnerQuery.AddField("emailSentAt");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder EmailState()
        {
            base.InnerQuery.AddField("emailState");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder HoursSinceLastAbandonedCheckout()
        {
            base.InnerQuery.AddField("hoursSinceLastAbandonedCheckout");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder InventoryAvailable()
        {
            base.InnerQuery.AddField("inventoryAvailable");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder IsFromCustomStorefront()
        {
            base.InnerQuery.AddField("isFromCustomStorefront");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder IsFromOnlineStore()
        {
            base.InnerQuery.AddField("isFromOnlineStore");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder IsFromShopApp()
        {
            base.InnerQuery.AddField("isFromShopApp");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder IsFromShopPay()
        {
            base.InnerQuery.AddField("isFromShopPay");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder IsMostSignificantAbandonment()
        {
            base.InnerQuery.AddField("isMostSignificantAbandonment");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder LastBrowseAbandonmentDate()
        {
            base.InnerQuery.AddField("lastBrowseAbandonmentDate");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder LastCartAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCartAbandonmentDate");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder LastCheckoutAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCheckoutAbandonmentDate");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder MostRecentStep()
        {
            base.InnerQuery.AddField("mostRecentStep");
            return this;
        }

        public QueryRootAbandonmentQueryBuilder ProductsAddedToCart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsAddedToCart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public QueryRootAbandonmentQueryBuilder ProductsViewed(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsViewed");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public QueryRootAbandonmentQueryBuilder VisitStartedAt()
        {
            base.InnerQuery.AddField("visitStartedAt");
            return this;
        }
    }
}