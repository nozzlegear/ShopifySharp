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

        public MediaQueryBuilder MediaErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaErrorQueryBuilder> build)
        {
            var query = new Query<MediaError>("mediaErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaError>(query);
            return this;
        }

        public MediaQueryBuilder MediaWarnings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaWarningQueryBuilder> build)
        {
            var query = new Query<MediaWarning>("mediaWarnings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaWarning>(query);
            return this;
        }

        public MediaQueryBuilder Preview(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaPreviewImageQueryBuilder> build)
        {
            var query = new Query<MediaPreviewImage>("preview");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaPreviewImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaPreviewImage>(query);
            return this;
        }

        public MediaQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public MediaQueryBuilder OnExternalVideo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExternalVideoQueryBuilder> build)
        {
            var query = new Query<ExternalVideo>("... on ExternalVideo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExternalVideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public MediaQueryBuilder OnMediaImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder> build)
        {
            var query = new Query<MediaImage>("... on MediaImage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public MediaQueryBuilder OnModel3d(Action<ShopifySharp.GraphQL.QueryBuilders.Types.Model3dQueryBuilder> build)
        {
            var query = new Query<Model3d>("... on Model3d");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.Model3dQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public MediaQueryBuilder OnVideo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.VideoQueryBuilder> build)
        {
            var query = new Query<Video>("... on Video");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.VideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public MediaQueryBuilder Media(Action<MediaInterfaceCasesBuilder> build)
        {
            var query = new Query<IMedia>("media");
            var unionBuilder = new MediaInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}