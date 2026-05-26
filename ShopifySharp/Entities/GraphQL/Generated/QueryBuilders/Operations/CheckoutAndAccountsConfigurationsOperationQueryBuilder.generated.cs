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
    public sealed class CheckoutAndAccountsConfigurationsOperationQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationConnection, CheckoutAndAccountsConfigurationsOperationQueryBuilder>, IGraphOperationQueryBuilder<CheckoutAndAccountsConfigurationConnection>, IHasArguments<CheckoutAndAccountsConfigurationsArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CheckoutAndAccountsConfigurationsArgumentsBuilder Arguments { get; }
        protected override CheckoutAndAccountsConfigurationsOperationQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationsOperationQueryBuilder() : this("checkoutAndAccountsConfigurations")
        {
        }

        public CheckoutAndAccountsConfigurationsOperationQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationConnection>(name))
        {
            Arguments = new CheckoutAndAccountsConfigurationsArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationsOperationQueryBuilder(IQuery<CheckoutAndAccountsConfigurationConnection> query) : base(query)
        {
            Arguments = new CheckoutAndAccountsConfigurationsArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationsOperationQueryBuilder SetArguments(Action<CheckoutAndAccountsConfigurationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CheckoutAndAccountsConfigurationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationEdgeQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationEdge>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfiguration>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfiguration>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}