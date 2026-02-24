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
    public sealed class SubscriptionDraftLinesAddedQueryBuilder : FieldsQueryBuilderBase<SubscriptionLineConnection, SubscriptionDraftLinesAddedQueryBuilder>, IHasArguments<SubscriptionDraftLinesAddedArgumentsBuilder>
    {
        public SubscriptionDraftLinesAddedArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftLinesAddedQueryBuilder Self => this;

        public SubscriptionDraftLinesAddedQueryBuilder(string name) : base(new Query<SubscriptionLineConnection>(name))
        {
            Arguments = new SubscriptionDraftLinesAddedArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftLinesAddedQueryBuilder(IQuery<SubscriptionLineConnection> query) : base(query)
        {
            Arguments = new SubscriptionDraftLinesAddedArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftLinesAddedQueryBuilder SetArguments(Action<SubscriptionDraftLinesAddedArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionDraftLinesAddedQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineEdge>(query);
            return this;
        }

        public SubscriptionDraftLinesAddedQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionDraftLinesAddedQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}