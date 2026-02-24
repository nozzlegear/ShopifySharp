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
    public sealed class PurchasingEntitySubscriptionContractsQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractConnection, PurchasingEntitySubscriptionContractsQueryBuilder>, IHasArguments<PurchasingEntitySubscriptionContractsArgumentsBuilder>
    {
        public PurchasingEntitySubscriptionContractsArgumentsBuilder Arguments { get; }
        protected override PurchasingEntitySubscriptionContractsQueryBuilder Self => this;

        public PurchasingEntitySubscriptionContractsQueryBuilder(string name) : base(new Query<SubscriptionContractConnection>(name))
        {
            Arguments = new PurchasingEntitySubscriptionContractsArgumentsBuilder(base.InnerQuery);
        }

        public PurchasingEntitySubscriptionContractsQueryBuilder(IQuery<SubscriptionContractConnection> query) : base(query)
        {
            Arguments = new PurchasingEntitySubscriptionContractsArgumentsBuilder(base.InnerQuery);
        }

        public PurchasingEntitySubscriptionContractsQueryBuilder SetArguments(Action<PurchasingEntitySubscriptionContractsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PurchasingEntitySubscriptionContractsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractEdge>(query);
            return this;
        }

        public PurchasingEntitySubscriptionContractsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public PurchasingEntitySubscriptionContractsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}