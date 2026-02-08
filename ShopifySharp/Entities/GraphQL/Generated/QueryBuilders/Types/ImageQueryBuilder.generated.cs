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
    public sealed class ImageQueryBuilder : FieldsQueryBuilderBase<Image, ImageQueryBuilder>
    {
        protected override ImageQueryBuilder Self => this;

        public ImageQueryBuilder() : this("image")
        {
        }

        public ImageQueryBuilder(string name) : base(new Query<Image>(name))
        {
        }

        public ImageQueryBuilder(IQuery<Image> query) : base(query)
        {
        }

        public ImageQueryBuilder AltText()
        {
            base.InnerQuery.AddField("altText");
            return this;
        }

        public ImageQueryBuilder Height()
        {
            base.InnerQuery.AddField("height");
            return this;
        }

        public ImageQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ImageQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public ImageQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        [Obsolete("Use `url` instead.")]
        public ImageQueryBuilder OriginalSrc()
        {
            base.InnerQuery.AddField("originalSrc");
            return this;
        }

        [Obsolete("Use `url` instead.")]
        public ImageQueryBuilder Src()
        {
            base.InnerQuery.AddField("src");
            return this;
        }

        public ImageQueryBuilder Thumbhash()
        {
            base.InnerQuery.AddField("thumbhash");
            return this;
        }

        [Obsolete("Use `url(transform:)` instead")]
        public ImageQueryBuilder TransformedSrc()
        {
            base.InnerQuery.AddField("transformedSrc");
            return this;
        }

        public ImageQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ImageQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }

        public ImageQueryBuilder Width()
        {
            base.InnerQuery.AddField("width");
            return this;
        }
    }
}