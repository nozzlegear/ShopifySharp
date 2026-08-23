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
    public sealed class CheckoutAndAccountsConfigurationBrandingContentQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingContent, CheckoutAndAccountsConfigurationBrandingContentQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingContentQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingContentQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingContent")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingContentQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingContent>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingContentQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingContent> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingContentQueryBuilder Divider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingContainerDivider>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingContainerDivider>(query);
            return this;
        }
    }
}