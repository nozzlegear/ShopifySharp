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
    public sealed class CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingTypography, CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingTypography")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingTypography>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingTypography> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder Size(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingFontSize>("size");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingFontSize>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder Primary(Action<CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingFontGroup>("primary");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder Secondary(Action<CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingFontGroup>("secondary");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}