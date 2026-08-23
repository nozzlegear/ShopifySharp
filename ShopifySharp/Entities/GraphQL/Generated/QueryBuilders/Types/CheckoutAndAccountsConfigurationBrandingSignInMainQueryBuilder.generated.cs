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
    public sealed class CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSignInMain, CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSignInMain")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSignInMain>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSignInMain> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder Section(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingMainSection>("section");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingMainSection>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder BackgroundImage(Action<CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImageValue>("backgroundImage");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}