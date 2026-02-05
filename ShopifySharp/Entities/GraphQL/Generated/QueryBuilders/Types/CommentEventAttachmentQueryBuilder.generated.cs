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
    public sealed class CommentEventAttachmentQueryBuilder : FieldsQueryBuilderBase<CommentEventAttachment, CommentEventAttachmentQueryBuilder>
    {
        protected override CommentEventAttachmentQueryBuilder Self => this;

        public CommentEventAttachmentQueryBuilder() : this("commentEventAttachment")
        {
        }

        public CommentEventAttachmentQueryBuilder(string name) : base(new Query<CommentEventAttachment>(name))
        {
        }

        public CommentEventAttachmentQueryBuilder(IQuery<CommentEventAttachment> query) : base(query)
        {
        }

        public CommentEventAttachmentQueryBuilder FileExtension()
        {
            base.InnerQuery.AddField("fileExtension");
            return this;
        }

        public CommentEventAttachmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentEventAttachmentQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public CommentEventAttachmentQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CommentEventAttachmentQueryBuilder Size()
        {
            base.InnerQuery.AddField("size");
            return this;
        }

        public CommentEventAttachmentQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}