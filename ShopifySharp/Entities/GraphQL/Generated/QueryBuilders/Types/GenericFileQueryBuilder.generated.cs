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
    public sealed class GenericFileQueryBuilder : FieldsQueryBuilderBase<GenericFile, GenericFileQueryBuilder>
    {
        protected override GenericFileQueryBuilder Self => this;

        public GenericFileQueryBuilder() : this("genericFile")
        {
        }

        public GenericFileQueryBuilder(string name) : base(new Query<GenericFile>(name))
        {
        }

        public GenericFileQueryBuilder(IQuery<GenericFile> query) : base(query)
        {
        }

        public GenericFileQueryBuilder Alt()
        {
            base.InnerQuery.AddField("alt");
            return this;
        }

        public GenericFileQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public GenericFileQueryBuilder FileErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FileErrorQueryBuilder> build)
        {
            var query = new Query<FileError>("fileErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FileErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileError>(query);
            return this;
        }

        public GenericFileQueryBuilder FileStatus()
        {
            base.InnerQuery.AddField("fileStatus");
            return this;
        }

        public GenericFileQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public GenericFileQueryBuilder MimeType()
        {
            base.InnerQuery.AddField("mimeType");
            return this;
        }

        public GenericFileQueryBuilder OriginalFileSize()
        {
            base.InnerQuery.AddField("originalFileSize");
            return this;
        }

        public GenericFileQueryBuilder Preview(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public GenericFileQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public GenericFileQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}