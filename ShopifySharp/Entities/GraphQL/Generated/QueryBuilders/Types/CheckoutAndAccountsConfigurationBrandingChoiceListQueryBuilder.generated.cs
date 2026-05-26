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
    public sealed class CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingChoiceList, CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingChoiceList")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingChoiceList>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingChoiceList> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingChoiceListQueryBuilder Group(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingChoiceListGroup>("group");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingChoiceListGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingChoiceListGroup>(query);
            return this;
        }
    }
}