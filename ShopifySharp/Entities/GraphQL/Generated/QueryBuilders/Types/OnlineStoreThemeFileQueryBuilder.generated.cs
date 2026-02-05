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
    public sealed class OnlineStoreThemeFileQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFile, OnlineStoreThemeFileQueryBuilder>
    {
        protected override OnlineStoreThemeFileQueryBuilder Self => this;

        public OnlineStoreThemeFileQueryBuilder() : this("onlineStoreThemeFile")
        {
        }

        public OnlineStoreThemeFileQueryBuilder(string name) : base(new Query<OnlineStoreThemeFile>(name))
        {
        }

        public OnlineStoreThemeFileQueryBuilder(IQuery<OnlineStoreThemeFile> query) : base(query)
        {
        }

        public OnlineStoreThemeFileQueryBuilder ChecksumMd5()
        {
            base.InnerQuery.AddField("checksumMd5");
            return this;
        }

        public OnlineStoreThemeFileQueryBuilder ContentType()
        {
            base.InnerQuery.AddField("contentType");
            return this;
        }

        public OnlineStoreThemeFileQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public OnlineStoreThemeFileQueryBuilder Filename()
        {
            base.InnerQuery.AddField("filename");
            return this;
        }

        public OnlineStoreThemeFileQueryBuilder Size()
        {
            base.InnerQuery.AddField("size");
            return this;
        }

        public OnlineStoreThemeFileQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public OnlineStoreThemeFileQueryBuilder Body(Action<OnlineStoreThemeFileBodyUnionCasesBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileBody>("body");
            var unionBuilder = new OnlineStoreThemeFileBodyUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}