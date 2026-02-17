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
    public sealed class OnlineStoreThemeFileBodyTextQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFileBodyText, OnlineStoreThemeFileBodyTextQueryBuilder>
    {
        protected override OnlineStoreThemeFileBodyTextQueryBuilder Self => this;

        public OnlineStoreThemeFileBodyTextQueryBuilder() : this("onlineStoreThemeFileBodyText")
        {
        }

        public OnlineStoreThemeFileBodyTextQueryBuilder(string name) : base(new Query<OnlineStoreThemeFileBodyText>(name))
        {
        }

        public OnlineStoreThemeFileBodyTextQueryBuilder(IQuery<OnlineStoreThemeFileBodyText> query) : base(query)
        {
        }

        public OnlineStoreThemeFileBodyTextQueryBuilder Content()
        {
            base.InnerQuery.AddField("content");
            return this;
        }
    }
}