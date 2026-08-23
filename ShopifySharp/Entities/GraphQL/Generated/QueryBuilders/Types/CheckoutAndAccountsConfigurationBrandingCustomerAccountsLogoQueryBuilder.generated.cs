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
    public sealed class CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogo, CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCustomerAccountsLogo")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogo>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogo> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder MaxWidth()
        {
            base.InnerQuery.AddField("maxWidth");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder Image(Action<CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImageValue>("image");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}