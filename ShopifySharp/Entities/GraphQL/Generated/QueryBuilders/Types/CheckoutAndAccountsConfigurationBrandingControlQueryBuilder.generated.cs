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
    public sealed class CheckoutAndAccountsConfigurationBrandingControlQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingControl, CheckoutAndAccountsConfigurationBrandingControlQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingControlQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingControlQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingControl")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingControlQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingControl>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingControlQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingControl> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingControlQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingControlQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingControlQueryBuilder LabelPosition()
        {
            base.InnerQuery.AddField("labelPosition");
            return this;
        }
    }
}