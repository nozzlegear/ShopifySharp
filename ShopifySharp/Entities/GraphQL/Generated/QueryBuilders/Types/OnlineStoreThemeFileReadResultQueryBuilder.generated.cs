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
    public sealed class OnlineStoreThemeFileReadResultQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFileReadResult, OnlineStoreThemeFileReadResultQueryBuilder>
    {
        protected override OnlineStoreThemeFileReadResultQueryBuilder Self => this;

        public OnlineStoreThemeFileReadResultQueryBuilder() : this("onlineStoreThemeFileReadResult")
        {
        }

        public OnlineStoreThemeFileReadResultQueryBuilder(string name) : base(new Query<OnlineStoreThemeFileReadResult>(name))
        {
        }

        public OnlineStoreThemeFileReadResultQueryBuilder(IQuery<OnlineStoreThemeFileReadResult> query) : base(query)
        {
        }

        public OnlineStoreThemeFileReadResultQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OnlineStoreThemeFileReadResultQueryBuilder Filename()
        {
            base.InnerQuery.AddField("filename");
            return this;
        }
    }
}