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
    public sealed class OnlineStoreThemeFileBodyBase64QueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFileBodyBase64, OnlineStoreThemeFileBodyBase64QueryBuilder>
    {
        protected override OnlineStoreThemeFileBodyBase64QueryBuilder Self => this;

        public OnlineStoreThemeFileBodyBase64QueryBuilder() : this("onlineStoreThemeFileBodyBase64")
        {
        }

        public OnlineStoreThemeFileBodyBase64QueryBuilder(string name) : base(new Query<OnlineStoreThemeFileBodyBase64>(name))
        {
        }

        public OnlineStoreThemeFileBodyBase64QueryBuilder(IQuery<OnlineStoreThemeFileBodyBase64> query) : base(query)
        {
        }

        public OnlineStoreThemeFileBodyBase64QueryBuilder ContentBase64()
        {
            base.InnerQuery.AddField("contentBase64");
            return this;
        }
    }
}