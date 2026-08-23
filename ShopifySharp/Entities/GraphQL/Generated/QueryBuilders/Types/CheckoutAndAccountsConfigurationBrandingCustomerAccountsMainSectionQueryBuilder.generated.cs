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
    public sealed class CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSection, CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCustomerAccountsMainSection")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSection>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSection> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionQueryBuilder Shadow()
        {
            base.InnerQuery.AddField("shadow");
            return this;
        }
    }
}