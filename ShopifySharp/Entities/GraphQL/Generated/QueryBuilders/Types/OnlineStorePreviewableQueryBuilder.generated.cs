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
    public sealed class OnlineStorePreviewableQueryBuilder : FieldsQueryBuilderBase<IOnlineStorePreviewable, OnlineStorePreviewableQueryBuilder>
    {
        protected override OnlineStorePreviewableQueryBuilder Self => this;

        public OnlineStorePreviewableQueryBuilder() : this("onlineStorePreviewable")
        {
        }

        public OnlineStorePreviewableQueryBuilder(string name) : base(new Query<IOnlineStorePreviewable>(name))
        {
        }

        public OnlineStorePreviewableQueryBuilder(IQuery<IOnlineStorePreviewable> query) : base(query)
        {
        }

        public OnlineStorePreviewableQueryBuilder OnlineStorePreviewUrl()
        {
            base.InnerQuery.AddField("onlineStorePreviewUrl");
            return this;
        }
    }
}