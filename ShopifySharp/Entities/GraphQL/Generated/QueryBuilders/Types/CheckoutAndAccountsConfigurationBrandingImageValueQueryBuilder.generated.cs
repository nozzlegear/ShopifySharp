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
    public sealed class CheckoutAndAccountsConfigurationBrandingImageValueQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingImageValue, CheckoutAndAccountsConfigurationBrandingImageValueQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingImageValueQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingImageValueQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingImageValue")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingImageValueQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingImageValue>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingImageValueQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingImageValue> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingImageValueQueryBuilder CheckoutAndAccountsConfigurationBrandingImageValue(Action<CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImageValue>("checkoutAndAccountsConfigurationBrandingImageValue");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}