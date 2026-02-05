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
    public sealed class MediaQueryBuilder : FieldsQueryBuilderBase<IMedia, MediaQueryBuilder>
    {
        protected override MediaQueryBuilder Self => this;

        public MediaQueryBuilder() : this("media")
        {
        }

        public MediaQueryBuilder(string name) : base(new Query<IMedia>(name))
        {
        }

        public MediaQueryBuilder(IQuery<IMedia> query) : base(query)
        {
        }

        public MediaQueryBuilder Alt()
        {
            base.InnerQuery.AddField("alt");
            return this;
        }

        public MediaQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MediaQueryBuilder MediaContentType()
        {
            base.InnerQuery.AddField("mediaContentType");
            return this;
        }

        public MediaQueryBuilder MediaErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder> build)
        {
            var query = new Query<MediaError>("mediaErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaError>(query);
            return this;
        }

        public MediaQueryBuilder MediaWarnings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder> build)
        {
            var query = new Query<MediaWarning>("mediaWarnings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaWarning>(query);
            return this;
        }

        public MediaQueryBuilder Preview(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public MediaQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}