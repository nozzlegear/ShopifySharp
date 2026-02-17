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
    public sealed class CommentSpamOperationQueryBuilder : FieldsQueryBuilderBase<CommentSpamPayload, CommentSpamOperationQueryBuilder>, IGraphOperationQueryBuilder<CommentSpamPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CommentSpamArgumentsBuilder Arguments { get; }
        protected override CommentSpamOperationQueryBuilder Self => this;

        public CommentSpamOperationQueryBuilder() : this("commentSpam")
        {
        }

        public CommentSpamOperationQueryBuilder(string name) : base(new Query<CommentSpamPayload>(name))
        {
            Arguments = new CommentSpamArgumentsBuilder(base.InnerQuery);
        }

        public CommentSpamOperationQueryBuilder(IQuery<CommentSpamPayload> query) : base(query)
        {
            Arguments = new CommentSpamArgumentsBuilder(base.InnerQuery);
        }

        public CommentSpamOperationQueryBuilder Comment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("comment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public CommentSpamOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentSpamUserErrorQueryBuilder> build)
        {
            var query = new Query<CommentSpamUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentSpamUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentSpamUserError>(query);
            return this;
        }
    }
}