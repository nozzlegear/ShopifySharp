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
    public sealed class CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder : UnionCasesBuilderBase<CheckoutAndAccountsConfigurationBrandingFontGroup, CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder(string fieldName = "secondary") : this(new Query<CheckoutAndAccountsConfigurationBrandingFontGroup>(fieldName))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingFontGroup> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder OnCheckoutAndAccountsConfigurationBrandingCustomFontGroup(Action<CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomFontGroup>("... on CheckoutAndAccountsConfigurationBrandingCustomFontGroup");
            var queryBuilder = new CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingFontGroupUnionCasesBuilder OnCheckoutAndAccountsConfigurationBrandingShopifyFontGroup(Action<CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingShopifyFontGroup>("... on CheckoutAndAccountsConfigurationBrandingShopifyFontGroup");
            var queryBuilder = new CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}