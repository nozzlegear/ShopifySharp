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