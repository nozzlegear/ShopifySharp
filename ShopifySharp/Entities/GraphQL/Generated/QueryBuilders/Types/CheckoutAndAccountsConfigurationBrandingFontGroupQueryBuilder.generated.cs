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
    public sealed class CheckoutAndAccountsConfigurationBrandingFontGroupQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingFontGroup, CheckoutAndAccountsConfigurationBrandingFontGroupQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingFontGroupQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingFontGroupQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingFontGroup")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFontGroupQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingFontGroup>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFontGroupQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingFontGroup> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFontGroupQueryBuilder CheckoutAndAccountsConfigurationBrandingFontGroup(Action<CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingFontGroup>("checkoutAndAccountsConfigurationBrandingFontGroup");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}