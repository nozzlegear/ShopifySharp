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
    public sealed class CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCartLink, CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCartLink")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCartLink>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCartLink> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCartLinkQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}