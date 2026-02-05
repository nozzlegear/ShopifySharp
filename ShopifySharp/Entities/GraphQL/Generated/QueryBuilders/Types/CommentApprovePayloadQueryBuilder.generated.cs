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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CommentApprovePayloadQueryBuilder : FieldsQueryBuilderBase<CommentApprovePayload, CommentApprovePayloadQueryBuilder>
    {
        protected override CommentApprovePayloadQueryBuilder Self => this;

        public CommentApprovePayloadQueryBuilder() : this("commentApprovePayload")
        {
        }

        public CommentApprovePayloadQueryBuilder(string name) : base(new Query<CommentApprovePayload>(name))
        {
        }

        public CommentApprovePayloadQueryBuilder(IQuery<CommentApprovePayload> query) : base(query)
        {
        }

        public CommentApprovePayloadQueryBuilder Comment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("comment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public CommentApprovePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentApproveUserErrorQueryBuilder> build)
        {
            var query = new Query<CommentApproveUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentApproveUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentApproveUserError>(query);
            return this;
        }
    }
}