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
    public sealed class CommentDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CommentDeletePayload, CommentDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CommentDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CommentDeleteArgumentsBuilder Arguments { get; }
        protected override CommentDeleteOperationQueryBuilder Self => this;

        public CommentDeleteOperationQueryBuilder() : this("commentDelete")
        {
        }

        public CommentDeleteOperationQueryBuilder(string name) : base(new Query<CommentDeletePayload>(name))
        {
            Arguments = new CommentDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CommentDeleteOperationQueryBuilder(IQuery<CommentDeletePayload> query) : base(query)
        {
            Arguments = new CommentDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CommentDeleteOperationQueryBuilder DeletedCommentId()
        {
            base.InnerQuery.AddField("deletedCommentId");
            return this;
        }

        public CommentDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<CommentDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentDeleteUserError>(query);
            return this;
        }
    }
}