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
    public sealed class CommentNotSpamUserErrorQueryBuilder : FieldsQueryBuilderBase<CommentNotSpamUserError, CommentNotSpamUserErrorQueryBuilder>
    {
        protected override CommentNotSpamUserErrorQueryBuilder Self => this;

        public CommentNotSpamUserErrorQueryBuilder() : this("commentNotSpamUserError")
        {
        }

        public CommentNotSpamUserErrorQueryBuilder(string name) : base(new Query<CommentNotSpamUserError>(name))
        {
        }

        public CommentNotSpamUserErrorQueryBuilder(IQuery<CommentNotSpamUserError> query) : base(query)
        {
        }

        public CommentNotSpamUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CommentNotSpamUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CommentNotSpamUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}