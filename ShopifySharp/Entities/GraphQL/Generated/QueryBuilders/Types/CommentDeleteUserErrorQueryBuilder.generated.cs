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
    public sealed class CommentDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<CommentDeleteUserError, CommentDeleteUserErrorQueryBuilder>
    {
        protected override CommentDeleteUserErrorQueryBuilder Self => this;

        public CommentDeleteUserErrorQueryBuilder() : this("commentDeleteUserError")
        {
        }

        public CommentDeleteUserErrorQueryBuilder(string name) : base(new Query<CommentDeleteUserError>(name))
        {
        }

        public CommentDeleteUserErrorQueryBuilder(IQuery<CommentDeleteUserError> query) : base(query)
        {
        }

        public CommentDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CommentDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CommentDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}