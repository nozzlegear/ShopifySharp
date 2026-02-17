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
    public sealed class AbandonmentQueryBuilder : FieldsQueryBuilderBase<Abandonment, AbandonmentQueryBuilder>
    {
        protected override AbandonmentQueryBuilder Self => this;

        public AbandonmentQueryBuilder() : this("abandonment")
        {
        }

        public AbandonmentQueryBuilder(string name) : base(new Query<Abandonment>(name))
        {
        }

        public AbandonmentQueryBuilder(IQuery<Abandonment> query) : base(query)
        {
        }

        public AbandonmentQueryBuilder AbandonedCheckoutPayload(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("abandonedCheckoutPayload");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckout>(query);
            return this;
        }

        public AbandonmentQueryBuilder AbandonmentType()
        {
            base.InnerQuery.AddField("abandonmentType");
            return this;
        }

        public AbandonmentQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AbandonmentQueryBuilder CartUrl()
        {
            base.InnerQuery.AddField("cartUrl");
            return this;
        }

        public AbandonmentQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AbandonmentQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public AbandonmentQueryBuilder CustomerHasNoDraftOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoDraftOrderSinceAbandonment");
            return this;
        }

        public AbandonmentQueryBuilder CustomerHasNoOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoOrderSinceAbandonment");
            return this;
        }

        public AbandonmentQueryBuilder DaysSinceLastAbandonmentEmail()
        {
            base.InnerQuery.AddField("daysSinceLastAbandonmentEmail");
            return this;
        }

        public AbandonmentQueryBuilder EmailSentAt()
        {
            base.InnerQuery.AddField("emailSentAt");
            return this;
        }

        public AbandonmentQueryBuilder EmailState()
        {
            base.InnerQuery.AddField("emailState");
            return this;
        }

        public AbandonmentQueryBuilder HoursSinceLastAbandonedCheckout()
        {
            base.InnerQuery.AddField("hoursSinceLastAbandonedCheckout");
            return this;
        }

        public AbandonmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AbandonmentQueryBuilder InventoryAvailable()
        {
            base.InnerQuery.AddField("inventoryAvailable");
            return this;
        }

        public AbandonmentQueryBuilder IsFromCustomStorefront()
        {
            base.InnerQuery.AddField("isFromCustomStorefront");
            return this;
        }

        public AbandonmentQueryBuilder IsFromOnlineStore()
        {
            base.InnerQuery.AddField("isFromOnlineStore");
            return this;
        }

        public AbandonmentQueryBuilder IsFromShopApp()
        {
            base.InnerQuery.AddField("isFromShopApp");
            return this;
        }

        public AbandonmentQueryBuilder IsFromShopPay()
        {
            base.InnerQuery.AddField("isFromShopPay");
            return this;
        }

        public AbandonmentQueryBuilder IsMostSignificantAbandonment()
        {
            base.InnerQuery.AddField("isMostSignificantAbandonment");
            return this;
        }

        public AbandonmentQueryBuilder LastBrowseAbandonmentDate()
        {
            base.InnerQuery.AddField("lastBrowseAbandonmentDate");
            return this;
        }

        public AbandonmentQueryBuilder LastCartAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCartAbandonmentDate");
            return this;
        }

        public AbandonmentQueryBuilder LastCheckoutAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCheckoutAbandonmentDate");
            return this;
        }

        public AbandonmentQueryBuilder MostRecentStep()
        {
            base.InnerQuery.AddField("mostRecentStep");
            return this;
        }

        public AbandonmentQueryBuilder ProductsAddedToCart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsAddedToCart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public AbandonmentQueryBuilder ProductsViewed(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsViewed");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public AbandonmentQueryBuilder VisitStartedAt()
        {
            base.InnerQuery.AddField("visitStartedAt");
            return this;
        }
    }
}