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
    public sealed class CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCheckbox, CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCheckbox")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCheckbox>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCheckbox> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckboxQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }
    }
}