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
    public sealed class Model3dQueryBuilder : FieldsQueryBuilderBase<Model3d, Model3dQueryBuilder>
    {
        protected override Model3dQueryBuilder Self => this;

        public Model3dQueryBuilder() : this("model3d")
        {
        }

        public Model3dQueryBuilder(string name) : base(new Query<Model3d>(name))
        {
        }

        public Model3dQueryBuilder(IQuery<Model3d> query) : base(query)
        {
        }

        public Model3dQueryBuilder Alt()
        {
            base.InnerQuery.AddField("alt");
            return this;
        }

        public Model3dQueryBuilder BoundingBox(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.Model3dBoundingBoxQueryBuilder> build)
        {
            var query = new Query<Model3dBoundingBox>("boundingBox");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.Model3dBoundingBoxQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Model3dBoundingBox>(query);
            return this;
        }

        public Model3dQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public Model3dQueryBuilder FileErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder> build)
        {
            var query = new Query<FileError>("fileErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileError>(query);
            return this;
        }

        public Model3dQueryBuilder Filename()
        {
            base.InnerQuery.AddField("filename");
            return this;
        }

        public Model3dQueryBuilder FileStatus()
        {
            base.InnerQuery.AddField("fileStatus");
            return this;
        }

        public Model3dQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public Model3dQueryBuilder MediaContentType()
        {
            base.InnerQuery.AddField("mediaContentType");
            return this;
        }

        public Model3dQueryBuilder MediaErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder> build)
        {
            var query = new Query<MediaError>("mediaErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaError>(query);
            return this;
        }

        public Model3dQueryBuilder MediaWarnings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder> build)
        {
            var query = new Query<MediaWarning>("mediaWarnings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaWarning>(query);
            return this;
        }

        public Model3dQueryBuilder OriginalSource(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.Model3dSourceQueryBuilder> build)
        {
            var query = new Query<Model3dSource>("originalSource");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.Model3dSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Model3dSource>(query);
            return this;
        }

        public Model3dQueryBuilder Preview(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public Model3dQueryBuilder Sources(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.Model3dSourceQueryBuilder> build)
        {
            var query = new Query<Model3dSource>("sources");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.Model3dSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Model3dSource>(query);
            return this;
        }

        public Model3dQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public Model3dQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}