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
    public sealed class CheckoutAndAccountsConfigurationQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfiguration, CheckoutAndAccountsConfigurationQueryBuilder>, IHasArguments<CheckoutAndAccountsConfigurationArgumentsBuilder>
    {
        public CheckoutAndAccountsConfigurationArgumentsBuilder Arguments { get; }
        protected override CheckoutAndAccountsConfigurationQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationQueryBuilder() : this("checkoutAndAccountsConfiguration")
        {
        }

        public CheckoutAndAccountsConfigurationQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfiguration>(name))
        {
            Arguments = new CheckoutAndAccountsConfigurationArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationQueryBuilder(IQuery<CheckoutAndAccountsConfiguration> query) : base(query)
        {
            Arguments = new CheckoutAndAccountsConfigurationArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationQueryBuilder SetArguments(Action<CheckoutAndAccountsConfigurationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CheckoutAndAccountsConfigurationQueryBuilder Branding(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBranding>("branding");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBranding>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CheckoutAndAccountsConfigurationQueryBuilder EditedAt()
        {
            base.InnerQuery.AddField("editedAt");
            return this;
        }

        public CheckoutAndAccountsConfigurationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CheckoutAndAccountsConfigurationQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public CheckoutAndAccountsConfigurationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CheckoutAndAccountsConfigurationQueryBuilder Overrides(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationOverrideQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationOverride>("overrides");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationOverrideQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationOverride>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}