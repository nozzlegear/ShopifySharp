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
    public sealed class CheckoutBrandingCustomizationsQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingCustomizations, CheckoutBrandingCustomizationsQueryBuilder>
    {
        protected override CheckoutBrandingCustomizationsQueryBuilder Self => this;

        public CheckoutBrandingCustomizationsQueryBuilder() : this("checkoutBrandingCustomizations")
        {
        }

        public CheckoutBrandingCustomizationsQueryBuilder(string name) : base(new Query<CheckoutBrandingCustomizations>(name))
        {
        }

        public CheckoutBrandingCustomizationsQueryBuilder(IQuery<CheckoutBrandingCustomizations> query) : base(query)
        {
        }

        public CheckoutBrandingCustomizationsQueryBuilder BuyerJourney(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingBuyerJourneyQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingBuyerJourney>("buyerJourney");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingBuyerJourneyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingBuyerJourney>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder CartLink(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCartLinkQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingCartLink>("cartLink");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCartLinkQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingCartLink>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Checkbox(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCheckboxQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingCheckbox>("checkbox");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCheckboxQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingCheckbox>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder ChoiceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingChoiceListQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingChoiceList>("choiceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingChoiceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingChoiceList>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Content(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingContentQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingContent>("content");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingContent>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Control(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingControlQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingControl>("control");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingControlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingControl>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Divider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingDividerStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingDividerStyle>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingDividerStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingDividerStyle>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder ExpressCheckout(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingExpressCheckoutQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingExpressCheckout>("expressCheckout");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingExpressCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingExpressCheckout>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Favicon(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingImageQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingImage>("favicon");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingImage>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Footer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingFooterQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingFooter>("footer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingFooterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingFooter>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Global(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingGlobalQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingGlobal>("global");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingGlobalQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingGlobal>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Header(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingHeaderQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingHeader>("header");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingHeaderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingHeader>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder HeadingLevel1(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingHeadingLevelQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingHeadingLevel>("headingLevel1");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingHeadingLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingHeadingLevel>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder HeadingLevel2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingHeadingLevelQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingHeadingLevel>("headingLevel2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingHeadingLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingHeadingLevel>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder HeadingLevel3(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingHeadingLevelQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingHeadingLevel>("headingLevel3");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingHeadingLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingHeadingLevel>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Main(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingMainQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingMain>("main");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingMainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingMain>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder MerchandiseThumbnail(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingMerchandiseThumbnailQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingMerchandiseThumbnail>("merchandiseThumbnail");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingMerchandiseThumbnailQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingMerchandiseThumbnail>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder OrderSummary(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingOrderSummaryQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingOrderSummary>("orderSummary");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingOrderSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingOrderSummary>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder PrimaryButton(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingButtonQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingButton>("primaryButton");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingButtonQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingButton>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder SecondaryButton(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingButtonQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingButton>("secondaryButton");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingButtonQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingButton>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder Select(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingSelectQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingSelect>("select");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingSelectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingSelect>(query);
            return this;
        }

        public CheckoutBrandingCustomizationsQueryBuilder TextField(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTextFieldQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingTextField>("textField");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTextFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingTextField>(query);
            return this;
        }
    }
}