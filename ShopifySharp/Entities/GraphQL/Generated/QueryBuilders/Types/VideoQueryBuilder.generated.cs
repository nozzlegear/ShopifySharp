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
    public sealed class VideoQueryBuilder : FieldsQueryBuilderBase<Video, VideoQueryBuilder>
    {
        protected override VideoQueryBuilder Self => this;

        public VideoQueryBuilder() : this("video")
        {
        }

        public VideoQueryBuilder(string name) : base(new Query<Video>(name))
        {
        }

        public VideoQueryBuilder(IQuery<Video> query) : base(query)
        {
        }

        public VideoQueryBuilder Alt()
        {
            base.InnerQuery.AddField("alt");
            return this;
        }

        public VideoQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public VideoQueryBuilder Duration()
        {
            base.InnerQuery.AddField("duration");
            return this;
        }

        public VideoQueryBuilder FileErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder> build)
        {
            var query = new Query<FileError>("fileErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileError>(query);
            return this;
        }

        public VideoQueryBuilder Filename()
        {
            base.InnerQuery.AddField("filename");
            return this;
        }

        public VideoQueryBuilder FileStatus()
        {
            base.InnerQuery.AddField("fileStatus");
            return this;
        }

        public VideoQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public VideoQueryBuilder MediaContentType()
        {
            base.InnerQuery.AddField("mediaContentType");
            return this;
        }

        public VideoQueryBuilder MediaErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder> build)
        {
            var query = new Query<MediaError>("mediaErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaError>(query);
            return this;
        }

        public VideoQueryBuilder MediaWarnings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder> build)
        {
            var query = new Query<MediaWarning>("mediaWarnings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaWarning>(query);
            return this;
        }

        public VideoQueryBuilder OriginalSource(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.VideoSourceQueryBuilder> build)
        {
            var query = new Query<VideoSource>("originalSource");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.VideoSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<VideoSource>(query);
            return this;
        }

        public VideoQueryBuilder Preview(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public VideoQueryBuilder Sources(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.VideoSourceQueryBuilder> build)
        {
            var query = new Query<VideoSource>("sources");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.VideoSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<VideoSource>(query);
            return this;
        }

        public VideoQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public VideoQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}