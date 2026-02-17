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
    public sealed class VideoSourceQueryBuilder : FieldsQueryBuilderBase<VideoSource, VideoSourceQueryBuilder>
    {
        protected override VideoSourceQueryBuilder Self => this;

        public VideoSourceQueryBuilder() : this("videoSource")
        {
        }

        public VideoSourceQueryBuilder(string name) : base(new Query<VideoSource>(name))
        {
        }

        public VideoSourceQueryBuilder(IQuery<VideoSource> query) : base(query)
        {
        }

        public VideoSourceQueryBuilder FileSize()
        {
            base.InnerQuery.AddField("fileSize");
            return this;
        }

        public VideoSourceQueryBuilder Format()
        {
            base.InnerQuery.AddField("format");
            return this;
        }

        public VideoSourceQueryBuilder Height()
        {
            base.InnerQuery.AddField("height");
            return this;
        }

        public VideoSourceQueryBuilder MimeType()
        {
            base.InnerQuery.AddField("mimeType");
            return this;
        }

        public VideoSourceQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }

        public VideoSourceQueryBuilder Width()
        {
            base.InnerQuery.AddField("width");
            return this;
        }
    }
}