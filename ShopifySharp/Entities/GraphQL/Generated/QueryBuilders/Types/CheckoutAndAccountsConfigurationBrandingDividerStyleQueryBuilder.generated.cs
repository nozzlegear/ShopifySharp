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
    public sealed class CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingDividerStyle, CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingDividerStyle")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingDividerStyle>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingDividerStyle> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingDividerStyleQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }
    }
}