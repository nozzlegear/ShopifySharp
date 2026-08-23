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
    public sealed class QueryRootCheckoutAndAccountsConfigurationQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfiguration, QueryRootCheckoutAndAccountsConfigurationQueryBuilder>, IHasArguments<QueryRootCheckoutAndAccountsConfigurationArgumentsBuilder>
    {
        public QueryRootCheckoutAndAccountsConfigurationArgumentsBuilder Arguments { get; }
        protected override QueryRootCheckoutAndAccountsConfigurationQueryBuilder Self => this;

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfiguration>(name))
        {
            Arguments = new QueryRootCheckoutAndAccountsConfigurationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder(IQuery<CheckoutAndAccountsConfiguration> query) : base(query)
        {
            Arguments = new QueryRootCheckoutAndAccountsConfigurationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder SetArguments(Action<QueryRootCheckoutAndAccountsConfigurationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder Branding(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBranding>("branding");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBranding>(query);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder EditedAt()
        {
            base.InnerQuery.AddField("editedAt");
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder Overrides(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationOverrideQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationOverride>("overrides");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationOverrideQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationOverride>(query);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}