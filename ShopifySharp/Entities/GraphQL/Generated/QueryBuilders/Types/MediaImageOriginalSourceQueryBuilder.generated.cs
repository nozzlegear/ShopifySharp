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