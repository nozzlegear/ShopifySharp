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
    public sealed class CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingChoiceListGroup, CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingChoiceListGroup")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingChoiceListGroup>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingChoiceListGroup> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder Spacing()
        {
            base.InnerQuery.AddField("spacing");
            return this;
        }
    }
}