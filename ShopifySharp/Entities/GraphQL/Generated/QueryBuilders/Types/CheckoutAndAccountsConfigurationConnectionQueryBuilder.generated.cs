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
    public sealed class CheckoutAndAccountsConfigurationConnectionQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationConnection, CheckoutAndAccountsConfigurationConnectionQueryBuilder>, IHasArguments<CheckoutAndAccountsConfigurationConnectionArgumentsBuilder>
    {
        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder Arguments { get; }
        protected override CheckoutAndAccountsConfigurationConnectionQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationConnectionQueryBuilder() : this("checkoutAndAccountsConfigurationConnection")
        {
        }

        public CheckoutAndAccountsConfigurationConnectionQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationConnection>(name))
        {
            Arguments = new CheckoutAndAccountsConfigurationConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationConnectionQueryBuilder(IQuery<CheckoutAndAccountsConfigurationConnection> query) : base(query)
        {
            Arguments = new CheckoutAndAccountsConfigurationConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationConnectionQueryBuilder SetArguments(Action<CheckoutAndAccountsConfigurationConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationEdgeQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationEdge>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfiguration>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfiguration>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}