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
    public sealed class CheckoutAndAccountsConfigurationOverrideQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationOverride, CheckoutAndAccountsConfigurationOverrideQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationOverrideQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder() : this("checkoutAndAccountsConfigurationOverride")
        {
        }

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationOverride>(name))
        {
        }

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder(IQuery<CheckoutAndAccountsConfigurationOverride> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder Branding(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBranding>("branding");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBranding>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder EditedAt()
        {
            base.InnerQuery.AddField("editedAt");
            return this;
        }

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CheckoutAndAccountsConfigurationOverrideQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}