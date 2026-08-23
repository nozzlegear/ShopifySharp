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
    public sealed class CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSignInLogo, CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSignInLogo")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSignInLogo>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSignInLogo> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder MaxWidth()
        {
            base.InnerQuery.AddField("maxWidth");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder Image(Action<CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImageValue>("image");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}