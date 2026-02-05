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
    public sealed class CommentSpamPayloadQueryBuilder : FieldsQueryBuilderBase<CommentSpamPayload, CommentSpamPayloadQueryBuilder>
    {
        protected override CommentSpamPayloadQueryBuilder Self => this;

        public CommentSpamPayloadQueryBuilder() : this("commentSpamPayload")
        {
        }

        public CommentSpamPayloadQueryBuilder(string name) : base(new Query<CommentSpamPayload>(name))
        {
        }

        public CommentSpamPayloadQueryBuilder(IQuery<CommentSpamPayload> query) : base(query)
        {
        }

        public CommentSpamPayloadQueryBuilder Comment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("comment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public CommentSpamPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentSpamUserErrorQueryBuilder> build)
        {
            var query = new Query<CommentSpamUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentSpamUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentSpamUserError>(query);
            return this;
        }
    }
}