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
    public sealed class CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingShared, CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingShared")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingShared>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingShared> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSharedColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSharedColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSharedTypographyStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSharedTypographyStyle>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSharedTypographyStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSharedTypographyStyle>(query);
            return this;
        }
    }
}