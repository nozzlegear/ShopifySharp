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
    public sealed class CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingContainerDivider, CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingContainerDivider")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingContainerDivider>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingContainerDivider> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}