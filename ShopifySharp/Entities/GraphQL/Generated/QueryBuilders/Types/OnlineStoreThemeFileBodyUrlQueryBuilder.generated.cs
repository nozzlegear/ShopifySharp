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
    public sealed class OnlineStoreThemeFileBodyUrlQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFileBodyUrl, OnlineStoreThemeFileBodyUrlQueryBuilder>
    {
        protected override OnlineStoreThemeFileBodyUrlQueryBuilder Self => this;

        public OnlineStoreThemeFileBodyUrlQueryBuilder() : this("onlineStoreThemeFileBodyUrl")
        {
        }

        public OnlineStoreThemeFileBodyUrlQueryBuilder(string name) : base(new Query<OnlineStoreThemeFileBodyUrl>(name))
        {
        }

        public OnlineStoreThemeFileBodyUrlQueryBuilder(IQuery<OnlineStoreThemeFileBodyUrl> query) : base(query)
        {
        }

        public OnlineStoreThemeFileBodyUrlQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}