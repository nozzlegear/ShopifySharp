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
    public sealed class CommentEventEmbedSubscriptionContractsQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractConnection, CommentEventEmbedSubscriptionContractsQueryBuilder>, IHasArguments<CommentEventEmbedSubscriptionContractsArgumentsBuilder>
    {
        public CommentEventEmbedSubscriptionContractsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedSubscriptionContractsQueryBuilder Self => this;

        public CommentEventEmbedSubscriptionContractsQueryBuilder(string name) : base(new Query<SubscriptionContractConnection>(name))
        {
            Arguments = new CommentEventEmbedSubscriptionContractsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedSubscriptionContractsQueryBuilder(IQuery<SubscriptionContractConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedSubscriptionContractsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedSubscriptionContractsQueryBuilder SetArguments(Action<CommentEventEmbedSubscriptionContractsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedSubscriptionContractsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractEdge>(query);
            return this;
        }

        public CommentEventEmbedSubscriptionContractsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public CommentEventEmbedSubscriptionContractsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}