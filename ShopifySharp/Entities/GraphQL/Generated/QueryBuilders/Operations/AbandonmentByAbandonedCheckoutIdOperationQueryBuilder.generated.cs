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
    public sealed class AbandonmentByAbandonedCheckoutIdOperationQueryBuilder : FieldsQueryBuilderBase<Abandonment, AbandonmentByAbandonedCheckoutIdOperationQueryBuilder>, IGraphOperationQueryBuilder<Abandonment>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AbandonmentByAbandonedCheckoutIdArgumentsBuilder Arguments { get; }
        protected override AbandonmentByAbandonedCheckoutIdOperationQueryBuilder Self => this;

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder() : this("abandonmentByAbandonedCheckoutId")
        {
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder(string name) : base(new Query<Abandonment>(name))
        {
            Arguments = new AbandonmentByAbandonedCheckoutIdArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder(IQuery<Abandonment> query) : base(query)
        {
            Arguments = new AbandonmentByAbandonedCheckoutIdArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder AbandonedCheckoutPayload(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("abandonedCheckoutPayload");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckout>(query);
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder AbandonmentType()
        {
            base.InnerQuery.AddField("abandonmentType");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder CartUrl()
        {
            base.InnerQuery.AddField("cartUrl");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder CustomerHasNoDraftOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoDraftOrderSinceAbandonment");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder CustomerHasNoOrderSinceAbandonment()
        {
            base.InnerQuery.AddField("customerHasNoOrderSinceAbandonment");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder DaysSinceLastAbandonmentEmail()
        {
            base.InnerQuery.AddField("daysSinceLastAbandonmentEmail");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder EmailSentAt()
        {
            base.InnerQuery.AddField("emailSentAt");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder EmailState()
        {
            base.InnerQuery.AddField("emailState");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder HoursSinceLastAbandonedCheckout()
        {
            base.InnerQuery.AddField("hoursSinceLastAbandonedCheckout");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder InventoryAvailable()
        {
            base.InnerQuery.AddField("inventoryAvailable");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder IsFromCustomStorefront()
        {
            base.InnerQuery.AddField("isFromCustomStorefront");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder IsFromOnlineStore()
        {
            base.InnerQuery.AddField("isFromOnlineStore");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder IsFromShopApp()
        {
            base.InnerQuery.AddField("isFromShopApp");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder IsFromShopPay()
        {
            base.InnerQuery.AddField("isFromShopPay");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder IsMostSignificantAbandonment()
        {
            base.InnerQuery.AddField("isMostSignificantAbandonment");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder LastBrowseAbandonmentDate()
        {
            base.InnerQuery.AddField("lastBrowseAbandonmentDate");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder LastCartAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCartAbandonmentDate");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder LastCheckoutAbandonmentDate()
        {
            base.InnerQuery.AddField("lastCheckoutAbandonmentDate");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder MostRecentStep()
        {
            base.InnerQuery.AddField("mostRecentStep");
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder ProductsAddedToCart(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsAddedToCart");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder ProductsViewed(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoConnection>("productsViewed");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoConnection>(query);
            return this;
        }

        public AbandonmentByAbandonedCheckoutIdOperationQueryBuilder VisitStartedAt()
        {
            base.InnerQuery.AddField("visitStartedAt");
            return this;
        }
    }
}