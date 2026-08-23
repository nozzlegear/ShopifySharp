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
    public sealed class CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingShopifyFont, CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingShopifyFont")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingShopifyFont>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingShopifyFont> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder Sources()
        {
            base.InnerQuery.AddField("sources");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder Weight()
        {
            base.InnerQuery.AddField("weight");
            return this;
        }
    }
}