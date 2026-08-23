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
    public sealed class CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCornerRadiusVariables, CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCornerRadiusVariables")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCornerRadiusVariables>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCornerRadiusVariables> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder Base()
        {
            base.InnerQuery.AddField("base");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder Large()
        {
            base.InnerQuery.AddField("large");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder Small()
        {
            base.InnerQuery.AddField("small");
            return this;
        }
    }
}