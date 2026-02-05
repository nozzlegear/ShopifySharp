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
    public sealed class FileQueryBuilder : FieldsQueryBuilderBase<IFile, FileQueryBuilder>
    {
        protected override FileQueryBuilder Self => this;

        public FileQueryBuilder() : this("file")
        {
        }

        public FileQueryBuilder(string name) : base(new Query<IFile>(name))
        {
        }

        public FileQueryBuilder(IQuery<IFile> query) : base(query)
        {
        }

        public FileQueryBuilder Alt()
        {
            base.InnerQuery.AddField("alt");
            return this;
        }

        public FileQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public FileQueryBuilder FileErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder> build)
        {
            var query = new Query<FileError>("fileErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileError>(query);
            return this;
        }

        public FileQueryBuilder FileStatus()
        {
            base.InnerQuery.AddField("fileStatus");
            return this;
        }

        public FileQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FileQueryBuilder Preview(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public FileQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}