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
    public sealed class CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingComponents, CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingComponents")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingComponents>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingComponents> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Checkbox(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCheckbox>("checkbox");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCheckbox>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder ChoiceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingChoiceList>("choiceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingChoiceList>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Control(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingControlQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingControl>("control");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingControlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingControl>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Divider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingDividerStyle>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingDividerStyle>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Footer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingFooter>("footer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingFooter>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Header(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingHeader>("header");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingHeader>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder HeadingLevel1(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingHeadingLevel>("headingLevel1");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingHeadingLevel>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder HeadingLevel2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingHeadingLevel>("headingLevel2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingHeadingLevel>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder HeadingLevel3(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingHeadingLevel>("headingLevel3");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingHeadingLevel>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Main(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMainQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingMain>("main");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingMain>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder MerchandiseThumbnail(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnail>("merchandiseThumbnail");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnail>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder PrimaryButton(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingButton>("primaryButton");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingButton>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder SecondaryButton(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingButton>("secondaryButton");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingButton>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Select(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSelect>("select");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSelect>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Shared(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingShared>("shared");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingShared>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder TextField(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTextFieldQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingTextField>("textField");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTextFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingTextField>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder Favicon(Action<CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImageValue>("favicon");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}