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
    public sealed class CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingFooterContent, CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingFooterContent")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingFooterContent>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingFooterContent> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}