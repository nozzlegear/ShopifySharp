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
    public sealed class CustomerSubscriptionContractsQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractConnection, CustomerSubscriptionContractsQueryBuilder>, IHasArguments<CustomerSubscriptionContractsArgumentsBuilder>
    {
        public CustomerSubscriptionContractsArgumentsBuilder Arguments { get; }
        protected override CustomerSubscriptionContractsQueryBuilder Self => this;

        public CustomerSubscriptionContractsQueryBuilder(string name) : base(new Query<SubscriptionContractConnection>(name))
        {
            Arguments = new CustomerSubscriptionContractsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSubscriptionContractsQueryBuilder(IQuery<SubscriptionContractConnection> query) : base(query)
        {
            Arguments = new CustomerSubscriptionContractsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSubscriptionContractsQueryBuilder SetArguments(Action<CustomerSubscriptionContractsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerSubscriptionContractsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractEdge>(query);
            return this;
        }

        public CustomerSubscriptionContractsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public CustomerSubscriptionContractsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}