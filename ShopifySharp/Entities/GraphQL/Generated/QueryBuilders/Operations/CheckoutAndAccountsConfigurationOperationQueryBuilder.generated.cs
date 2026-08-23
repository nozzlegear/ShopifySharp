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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CheckoutAndAccountsConfigurationOperationQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfiguration, CheckoutAndAccountsConfigurationOperationQueryBuilder>, IGraphOperationQueryBuilder<CheckoutAndAccountsConfiguration>, IHasArguments<CheckoutAndAccountsConfigurationArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CheckoutAndAccountsConfigurationArgumentsBuilder Arguments { get; }
        protected override CheckoutAndAccountsConfigurationOperationQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationOperationQueryBuilder() : this("checkoutAndAccountsConfiguration")
        {
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfiguration>(name))
        {
            Arguments = new CheckoutAndAccountsConfigurationArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder(IQuery<CheckoutAndAccountsConfiguration> query) : base(query)
        {
            Arguments = new CheckoutAndAccountsConfigurationArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder SetArguments(Action<CheckoutAndAccountsConfigurationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder Branding(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBranding>("branding");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBranding>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder EditedAt()
        {
            base.InnerQuery.AddField("editedAt");
            return this;
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder Overrides(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationOverrideQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationOverride>("overrides");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationOverrideQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationOverride>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}