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

        public FileQueryBuilder FileErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FileErrorQueryBuilder> build)
        {
            var query = new Query<FileError>("fileErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FileErrorQueryBuilder(query);
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

        public FileQueryBuilder Preview(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public FileQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public FileQueryBuilder OnExternalVideo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExternalVideoQueryBuilder> build)
        {
            var query = new Query<ExternalVideo>("... on ExternalVideo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExternalVideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public FileQueryBuilder OnGenericFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GenericFileQueryBuilder> build)
        {
            var query = new Query<GenericFile>("... on GenericFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GenericFileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public FileQueryBuilder OnMediaImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder> build)
        {
            var query = new Query<MediaImage>("... on MediaImage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public FileQueryBuilder OnModel3d(Action<ShopifySharp.GraphQL.QueryBuilders.Types.Model3dQueryBuilder> build)
        {
            var query = new Query<Model3d>("... on Model3d");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.Model3dQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public FileQueryBuilder OnVideo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.VideoQueryBuilder> build)
        {
            var query = new Query<Video>("... on Video");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.VideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public FileQueryBuilder File(Action<FileInterfaceCasesBuilder> build)
        {
            var query = new Query<IFile>("file");
            var unionBuilder = new FileInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}