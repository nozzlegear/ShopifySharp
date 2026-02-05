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
    public sealed class CommentApproveOperationQueryBuilder : FieldsQueryBuilderBase<CommentApprovePayload, CommentApproveOperationQueryBuilder>, IGraphOperationQueryBuilder<CommentApprovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CommentApproveArgumentsBuilder Arguments { get; }
        protected override CommentApproveOperationQueryBuilder Self => this;

        public CommentApproveOperationQueryBuilder() : this("commentApprove")
        {
        }

        public CommentApproveOperationQueryBuilder(string name) : base(new Query<CommentApprovePayload>(name))
        {
            Arguments = new CommentApproveArgumentsBuilder(base.InnerQuery);
        }

        public CommentApproveOperationQueryBuilder(IQuery<CommentApprovePayload> query) : base(query)
        {
            Arguments = new CommentApproveArgumentsBuilder(base.InnerQuery);
        }

        public CommentApproveOperationQueryBuilder Comment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("comment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public CommentApproveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentApproveUserErrorQueryBuilder> build)
        {
            var query = new Query<CommentApproveUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentApproveUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentApproveUserError>(query);
            return this;
        }
    }
}