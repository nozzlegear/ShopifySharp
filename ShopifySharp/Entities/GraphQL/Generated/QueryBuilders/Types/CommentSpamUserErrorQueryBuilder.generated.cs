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
    public sealed class CommentSpamUserErrorQueryBuilder : FieldsQueryBuilderBase<CommentSpamUserError, CommentSpamUserErrorQueryBuilder>
    {
        protected override CommentSpamUserErrorQueryBuilder Self => this;

        public CommentSpamUserErrorQueryBuilder() : this("commentSpamUserError")
        {
        }

        public CommentSpamUserErrorQueryBuilder(string name) : base(new Query<CommentSpamUserError>(name))
        {
        }

        public CommentSpamUserErrorQueryBuilder(IQuery<CommentSpamUserError> query) : base(query)
        {
        }

        public CommentSpamUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CommentSpamUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CommentSpamUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}