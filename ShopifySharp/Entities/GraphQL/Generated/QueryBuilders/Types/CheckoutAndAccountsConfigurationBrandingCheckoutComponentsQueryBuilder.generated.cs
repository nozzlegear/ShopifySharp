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
    public sealed class CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCheckoutComponents, CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCheckoutComponents")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCheckoutComponents>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCheckoutComponents> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder BuyerJourney(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingBuyerJourney>("buyerJourney");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingBuyerJourney>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder CartLink(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCartLink>("cartLink");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCartLink>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder Content(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingContentQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingContent>("content");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingContent>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder ExpressCheckout(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingExpressCheckout>("expressCheckout");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingExpressCheckout>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder Footer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCheckoutFooter>("footer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCheckoutFooter>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder Header(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCheckoutHeader>("header");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCheckoutHeader>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder Main(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMainQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingMain>("main");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingMain>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder OrderSummary(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingOrderSummary>("orderSummary");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingOrderSummary>(query);
            return this;
        }
    }
}