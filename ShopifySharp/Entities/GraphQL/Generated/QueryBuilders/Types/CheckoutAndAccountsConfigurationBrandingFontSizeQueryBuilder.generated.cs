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
    public sealed class CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingFontSize, CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingFontSize")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingFontSize>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingFontSize> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder Base()
        {
            base.InnerQuery.AddField("base");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingFontSizeQueryBuilder Ratio()
        {
            base.InnerQuery.AddField("ratio");
            return this;
        }
    }
}