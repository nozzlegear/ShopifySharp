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
    public sealed class CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCustomFont, CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCustomFont")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCustomFont>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCustomFont> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder GenericFileId()
        {
            base.InnerQuery.AddField("genericFileId");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder Sources()
        {
            base.InnerQuery.AddField("sources");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder Weight()
        {
            base.InnerQuery.AddField("weight");
            return this;
        }
    }
}