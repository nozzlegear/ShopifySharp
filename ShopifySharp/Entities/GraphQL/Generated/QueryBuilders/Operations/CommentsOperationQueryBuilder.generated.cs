#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CommentsOperationQueryBuilder : FieldsQueryBuilderBase<CommentConnection, CommentsOperationQueryBuilder>, IGraphOperationQueryBuilder<CommentConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CommentsArgumentsBuilder Arguments { get; }
        protected override CommentsOperationQueryBuilder Self => this;

        public CommentsOperationQueryBuilder() : this("comments")
        {
        }

        public CommentsOperationQueryBuilder(string name) : base(new Query<CommentConnection>(name))
        {
            Arguments = new CommentsArgumentsBuilder(base.InnerQuery);
        }

        public CommentsOperationQueryBuilder(IQuery<CommentConnection> query) : base(query)
        {
            Arguments = new CommentsArgumentsBuilder(base.InnerQuery);
        }

        public CommentsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentEdgeQueryBuilder> build)
        {
            var query = new Query<CommentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentEdge>(query);
            return this;
        }

        public CommentsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public CommentsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}