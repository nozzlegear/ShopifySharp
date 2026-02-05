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
    public sealed class CommentEventSubjectQueryBuilder : FieldsQueryBuilderBase<ICommentEventSubject, CommentEventSubjectQueryBuilder>
    {
        protected override CommentEventSubjectQueryBuilder Self => this;

        public CommentEventSubjectQueryBuilder() : this("commentEventSubject")
        {
        }

        public CommentEventSubjectQueryBuilder(string name) : base(new Query<ICommentEventSubject>(name))
        {
        }

        public CommentEventSubjectQueryBuilder(IQuery<ICommentEventSubject> query) : base(query)
        {
        }

        public CommentEventSubjectQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public CommentEventSubjectQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}