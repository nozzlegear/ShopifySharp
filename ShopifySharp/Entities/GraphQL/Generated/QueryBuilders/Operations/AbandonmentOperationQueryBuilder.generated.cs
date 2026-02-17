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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class AbandonmentOperationQueryBuilder : FieldsQueryBuilderBase<Abandonment, AbandonmentOperationQueryBuilder>, IGraphOperationQueryBuilder<Abandonment>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AbandonmentArgumentsBuilder Arguments { get; }
        protected override AbandonmentOperationQueryBuilder Self => this;

        public AbandonmentOperationQueryBuilder() : this("abandonment")
        {
        }

        public AbandonmentOperationQueryBuilder(string name) : base(new Query<Abandonment>(name))
        {
            Arguments = new AbandonmentArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentOperationQueryBuilder(IQuery<Abandonment> query) : base(query)
        {
            Arguments = new AbandonmentArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentOperationQueryBuilder AbandonedCheckoutPayload(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("abandonedCheckoutPayload");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckout>(query);
            return this;
        }

        public AbandonmentOperationQueryBuilder AbandonmentType()
        {
            base.InnerQuery.AddField("abandonmentType");
            return this;
        }

        public AbandonmentOperationQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AbandonmentOperationQueryBuilder CartUrl()
        {
            base.InnerQuery.AddField("cartUrl");
            return this;
        }

        public AbandonmentOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AbandonmentOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public AbandonmentOperationQueryBuilder CustomerHasNoDraftOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoDraftOrderSinceAbandonment");
            return this;
        }

        public AbandonmentOperationQueryBuilder CustomerHasNoOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoOrderSinceAbandonment");
            return this;
        }

        public AbandonmentOperationQueryBuilder DaysSinceLastAbandonmentEmail()
        {
            base.InnerQuery.AddField("daysSinceLastAbandonmentEmail");
            return this;
        }

        public AbandonmentOperationQueryBuilder EmailSentAt()
        {
            base.InnerQuery.AddField("emailSentAt");
            return this;
        }

        public AbandonmentOperationQueryBuilder EmailState()
        {
            base.InnerQuery.AddField("emailState");
            return this;
        }

        public AbandonmentOperationQueryBuilder HoursSinceLastAbandonedCheckout()
        {
            base.InnerQuery.AddField("hoursSinceLastAbandonedCheckout");
            return this;
        }

        public AbandonmentOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AbandonmentOperationQueryBuilder InventoryAvailable()
        {
            base.InnerQuery.AddField("inventoryAvailable");
            return this;
        }

        public AbandonmentOperationQueryBuilder IsFromCustomStorefront()
        {
            base.InnerQuery.AddField("isFromCustomStorefront");
            return this;
        }

        public AbandonmentOperationQueryBuilder IsFromOnlineStore()
        {
            base.InnerQuery.AddField("isFromOnlineStore");
            return this;
        }

        public AbandonmentOperationQueryBuilder IsFromShopApp()
        {
            base.InnerQuery.AddField("isFromShopApp");
            return this;
        }

        public AbandonmentOperationQueryBuilder IsFromShopPay()
        {
            base.InnerQuery.AddField("isFromShopPay");
            return this;
        }

        public AbandonmentOperationQueryBuilder IsMostSignificantAbandonment()
        {
            base.InnerQuery.AddField("isMostSignificantAbandonment");
            return this;
        }

        public AbandonmentOperationQueryBuilder LastBrowseAbandonmentDate()
        {
            base.InnerQuery.AddField("lastBrowseAbandonmentDate");
            return this;
        }

        public AbandonmentOperationQueryBuilder LastCartAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCartAbandonmentDate");
            return this;
        }

        public AbandonmentOperationQueryBuilder LastCheckoutAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCheckoutAbandonmentDate");
            return this;
        }

        public AbandonmentOperationQueryBuilder MostRecentStep()
        {
            base.InnerQuery.AddField("mostRecentStep");
            return this;
        }

        public AbandonmentOperationQueryBuilder ProductsAddedToCart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsAddedToCart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public AbandonmentOperationQueryBuilder ProductsViewed(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsViewed");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public AbandonmentOperationQueryBuilder VisitStartedAt()
        {
            base.InnerQuery.AddField("visitStartedAt");
            return this;
        }
    }
}