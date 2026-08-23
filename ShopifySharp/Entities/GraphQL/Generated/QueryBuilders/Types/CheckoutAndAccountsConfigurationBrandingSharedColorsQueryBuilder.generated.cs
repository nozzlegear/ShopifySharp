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
    public sealed class CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSharedColors, CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSharedColors")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSharedColors>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSharedColors> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Button()
        {
            base.InnerQuery.AddField("button");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Control()
        {
            base.InnerQuery.AddField("control");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Critical()
        {
            base.InnerQuery.AddField("critical");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Info()
        {
            base.InnerQuery.AddField("info");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSharedColorsQueryBuilder Warning()
        {
            base.InnerQuery.AddField("warning");
            return this;
        }
    }
}