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
    public sealed class CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingHeaderCartLink, CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingHeaderCartLink")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingHeaderCartLink>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingHeaderCartLink> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder ContentType()
        {
            base.InnerQuery.AddField("contentType");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder Image(Action<CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImageValue>("image");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}