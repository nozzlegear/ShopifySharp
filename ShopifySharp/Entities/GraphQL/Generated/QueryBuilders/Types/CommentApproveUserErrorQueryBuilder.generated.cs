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
    public sealed class CommentApproveUserErrorQueryBuilder : FieldsQueryBuilderBase<CommentApproveUserError, CommentApproveUserErrorQueryBuilder>
    {
        protected override CommentApproveUserErrorQueryBuilder Self => this;

        public CommentApproveUserErrorQueryBuilder() : this("commentApproveUserError")
        {
        }

        public CommentApproveUserErrorQueryBuilder(string name) : base(new Query<CommentApproveUserError>(name))
        {
        }

        public CommentApproveUserErrorQueryBuilder(IQuery<CommentApproveUserError> query) : base(query)
        {
        }

        public CommentApproveUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CommentApproveUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CommentApproveUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}