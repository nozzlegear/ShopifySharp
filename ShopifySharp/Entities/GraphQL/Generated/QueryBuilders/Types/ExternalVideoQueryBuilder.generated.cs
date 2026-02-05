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
    public sealed class ExternalVideoQueryBuilder : FieldsQueryBuilderBase<ExternalVideo, ExternalVideoQueryBuilder>
    {
        protected override ExternalVideoQueryBuilder Self => this;

        public ExternalVideoQueryBuilder() : this("externalVideo")
        {
        }

        public ExternalVideoQueryBuilder(string name) : base(new Query<ExternalVideo>(name))
        {
        }

        public ExternalVideoQueryBuilder(IQuery<ExternalVideo> query) : base(query)
        {
        }

        public ExternalVideoQueryBuilder Alt()
        {
            base.InnerQuery.AddField("alt");
            return this;
        }

        public ExternalVideoQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `originUrl` instead.")]
        public ExternalVideoQueryBuilder EmbeddedUrl()
        {
            base.InnerQuery.AddField("embeddedUrl");
            return this;
        }

        public ExternalVideoQueryBuilder EmbedUrl()
        {
            base.InnerQuery.AddField("embedUrl");
            return this;
        }

        public ExternalVideoQueryBuilder FileErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder> build)
        {
            var query = new Query<FileError>("fileErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileError>(query);
            return this;
        }

        public ExternalVideoQueryBuilder FileStatus()
        {
            base.InnerQuery.AddField("fileStatus");
            return this;
        }

        public ExternalVideoQueryBuilder Host()
        {
            base.InnerQuery.AddField("host");
            return this;
        }

        public ExternalVideoQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ExternalVideoQueryBuilder MediaContentType()
        {
            base.InnerQuery.AddField("mediaContentType");
            return this;
        }

        public ExternalVideoQueryBuilder MediaErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder> build)
        {
            var query = new Query<MediaError>("mediaErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaError>(query);
            return this;
        }

        public ExternalVideoQueryBuilder MediaWarnings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder> build)
        {
            var query = new Query<MediaWarning>("mediaWarnings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaWarning>(query);
            return this;
        }

        public ExternalVideoQueryBuilder OriginUrl()
        {
            base.InnerQuery.AddField("originUrl");
            return this;
        }

        public ExternalVideoQueryBuilder Preview(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public ExternalVideoQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ExternalVideoQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}