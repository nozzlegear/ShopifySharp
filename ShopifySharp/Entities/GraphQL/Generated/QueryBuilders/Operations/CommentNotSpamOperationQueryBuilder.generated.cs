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
    public sealed class CommentNotSpamOperationQueryBuilder : FieldsQueryBuilderBase<CommentNotSpamPayload, CommentNotSpamOperationQueryBuilder>, IGraphOperationQueryBuilder<CommentNotSpamPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CommentNotSpamArgumentsBuilder Arguments { get; }
        protected override CommentNotSpamOperationQueryBuilder Self => this;

        public CommentNotSpamOperationQueryBuilder() : this("commentNotSpam")
        {
        }

        public CommentNotSpamOperationQueryBuilder(string name) : base(new Query<CommentNotSpamPayload>(name))
        {
            Arguments = new CommentNotSpamArgumentsBuilder(base.InnerQuery);
        }

        public CommentNotSpamOperationQueryBuilder(IQuery<CommentNotSpamPayload> query) : base(query)
        {
            Arguments = new CommentNotSpamArgumentsBuilder(base.InnerQuery);
        }

        public CommentNotSpamOperationQueryBuilder Comment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("comment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public CommentNotSpamOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentNotSpamUserErrorQueryBuilder> build)
        {
            var query = new Query<CommentNotSpamUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentNotSpamUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentNotSpamUserError>(query);
            return this;
        }
    }
}