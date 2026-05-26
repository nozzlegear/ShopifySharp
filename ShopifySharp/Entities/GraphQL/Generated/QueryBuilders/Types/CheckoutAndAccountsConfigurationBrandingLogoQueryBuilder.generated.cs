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
    public sealed class CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingLogo, CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingLogo")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingLogo>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingLogo> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder MaxWidth()
        {
            base.InnerQuery.AddField("maxWidth");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder Image(Action<CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImageValue>("image");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}