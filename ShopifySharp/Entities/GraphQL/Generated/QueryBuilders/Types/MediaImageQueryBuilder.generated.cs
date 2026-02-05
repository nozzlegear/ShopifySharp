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
    public sealed class MediaImageQueryBuilder : FieldsQueryBuilderBase<MediaImage, MediaImageQueryBuilder>
    {
        protected override MediaImageQueryBuilder Self => this;

        public MediaImageQueryBuilder() : this("mediaImage")
        {
        }

        public MediaImageQueryBuilder(string name) : base(new Query<MediaImage>(name))
        {
        }

        public MediaImageQueryBuilder(IQuery<MediaImage> query) : base(query)
        {
        }

        public MediaImageQueryBuilder Alt()
        {
            base.InnerQuery.AddField("alt");
            return this;
        }

        public MediaImageQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public MediaImageQueryBuilder FileErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder> build)
        {
            var query = new Query<FileError>("fileErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FileError>(query);
            return this;
        }

        public MediaImageQueryBuilder FileStatus()
        {
            base.InnerQuery.AddField("fileStatus");
            return this;
        }

        public MediaImageQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MediaImageQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public MediaImageQueryBuilder MediaContentType()
        {
            base.InnerQuery.AddField("mediaContentType");
            return this;
        }

        public MediaImageQueryBuilder MediaErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder> build)
        {
            var query = new Query<MediaError>("mediaErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaError>(query);
            return this;
        }

        public MediaImageQueryBuilder MediaWarnings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder> build)
        {
            var query = new Query<MediaWarning>("mediaWarnings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaWarning>(query);
            return this;
        }

        public MediaImageQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public MediaImageQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public MediaImageQueryBuilder MimeType()
        {
            base.InnerQuery.AddField("mimeType");
            return this;
        }

        public MediaImageQueryBuilder OriginalSource(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaImageOriginalSourceQueryBuilder> build)
        {
            var query = new Query<MediaImageOriginalSource>("originalSource");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaImageOriginalSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaImageOriginalSource>(query);
            return this;
        }

        public MediaImageQueryBuilder Preview(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public MediaImageQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public MediaImageQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public MediaImageQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}