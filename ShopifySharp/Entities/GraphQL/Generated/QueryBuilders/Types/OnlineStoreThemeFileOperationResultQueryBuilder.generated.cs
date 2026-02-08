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
    public sealed class OnlineStoreThemeFileOperationResultQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFileOperationResult, OnlineStoreThemeFileOperationResultQueryBuilder>
    {
        protected override OnlineStoreThemeFileOperationResultQueryBuilder Self => this;

        public OnlineStoreThemeFileOperationResultQueryBuilder() : this("onlineStoreThemeFileOperationResult")
        {
        }

        public OnlineStoreThemeFileOperationResultQueryBuilder(string name) : base(new Query<OnlineStoreThemeFileOperationResult>(name))
        {
        }

        public OnlineStoreThemeFileOperationResultQueryBuilder(IQuery<OnlineStoreThemeFileOperationResult> query) : base(query)
        {
        }

        public OnlineStoreThemeFileOperationResultQueryBuilder ChecksumMd5()
        {
            base.InnerQuery.AddField("checksumMd5");
            return this;
        }

        public OnlineStoreThemeFileOperationResultQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public OnlineStoreThemeFileOperationResultQueryBuilder Filename()
        {
            base.InnerQuery.AddField("filename");
            return this;
        }

        public OnlineStoreThemeFileOperationResultQueryBuilder Size()
        {
            base.InnerQuery.AddField("size");
            return this;
        }

        public OnlineStoreThemeFileOperationResultQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}