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
    public sealed class SubscriptionContractLinesQueryBuilder : FieldsQueryBuilderBase<SubscriptionLineConnection, SubscriptionContractLinesQueryBuilder>, IHasArguments<SubscriptionContractLinesArgumentsBuilder>
    {
        public SubscriptionContractLinesArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractLinesQueryBuilder Self => this;

        public SubscriptionContractLinesQueryBuilder(string name) : base(new Query<SubscriptionLineConnection>(name))
        {
            Arguments = new SubscriptionContractLinesArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractLinesQueryBuilder(IQuery<SubscriptionLineConnection> query) : base(query)
        {
            Arguments = new SubscriptionContractLinesArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractLinesQueryBuilder SetArguments(Action<SubscriptionContractLinesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionContractLinesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineEdge>(query);
            return this;
        }

        public SubscriptionContractLinesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionContractLinesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}