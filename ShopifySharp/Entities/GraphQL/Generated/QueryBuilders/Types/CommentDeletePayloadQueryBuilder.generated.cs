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
    public sealed class CommentDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CommentDeletePayload, CommentDeletePayloadQueryBuilder>
    {
        protected override CommentDeletePayloadQueryBuilder Self => this;

        public CommentDeletePayloadQueryBuilder() : this("commentDeletePayload")
        {
        }

        public CommentDeletePayloadQueryBuilder(string name) : base(new Query<CommentDeletePayload>(name))
        {
        }

        public CommentDeletePayloadQueryBuilder(IQuery<CommentDeletePayload> query) : base(query)
        {
        }

        public CommentDeletePayloadQueryBuilder DeletedCommentId()
        {
            base.InnerQuery.AddField("deletedCommentId");
            return this;
        }

        public CommentDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<CommentDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentDeleteUserError>(query);
            return this;
        }
    }
}