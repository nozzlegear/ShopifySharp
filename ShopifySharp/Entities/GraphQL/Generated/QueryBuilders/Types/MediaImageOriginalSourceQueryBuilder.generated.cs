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
    public sealed class MediaImageOriginalSourceQueryBuilder : FieldsQueryBuilderBase<MediaImageOriginalSource, MediaImageOriginalSourceQueryBuilder>
    {
        protected override MediaImageOriginalSourceQueryBuilder Self => this;

        public MediaImageOriginalSourceQueryBuilder() : this("mediaImageOriginalSource")
        {
        }

        public MediaImageOriginalSourceQueryBuilder(string name) : base(new Query<MediaImageOriginalSource>(name))
        {
        }

        public MediaImageOriginalSourceQueryBuilder(IQuery<MediaImageOriginalSource> query) : base(query)
        {
        }

        public MediaImageOriginalSourceQueryBuilder FileSize()
        {
            base.InnerQuery.AddField("fileSize");
            return this;
        }

        public MediaImageOriginalSourceQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}