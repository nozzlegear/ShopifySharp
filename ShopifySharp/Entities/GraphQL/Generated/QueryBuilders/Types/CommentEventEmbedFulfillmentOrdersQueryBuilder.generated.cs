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
    public sealed class CommentEventEmbedFulfillmentOrdersQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderConnection, CommentEventEmbedFulfillmentOrdersQueryBuilder>, IHasArguments<CommentEventEmbedFulfillmentOrdersArgumentsBuilder>
    {
        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedFulfillmentOrdersQueryBuilder Self => this;

        public CommentEventEmbedFulfillmentOrdersQueryBuilder(string name) : base(new Query<FulfillmentOrderConnection>(name))
        {
            Arguments = new CommentEventEmbedFulfillmentOrdersArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedFulfillmentOrdersQueryBuilder(IQuery<FulfillmentOrderConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedFulfillmentOrdersArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedFulfillmentOrdersQueryBuilder SetArguments(Action<CommentEventEmbedFulfillmentOrdersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderEdge>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}