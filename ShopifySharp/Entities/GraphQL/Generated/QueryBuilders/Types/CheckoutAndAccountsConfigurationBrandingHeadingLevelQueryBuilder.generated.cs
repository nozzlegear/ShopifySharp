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
    public sealed class CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingHeadingLevel, CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingHeadingLevel")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingHeadingLevel>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingHeadingLevel> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeadingLevelQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingTypographyStyle>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingTypographyStyle>(query);
            return this;
        }
    }
}