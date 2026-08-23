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
    public sealed class OnlineStoreThemeFileBodyUnionCasesBuilder : UnionCasesBuilderBase<OnlineStoreThemeFileBody, OnlineStoreThemeFileBodyUnionCasesBuilder>
    {
        protected override OnlineStoreThemeFileBodyUnionCasesBuilder Self => this;

        public OnlineStoreThemeFileBodyUnionCasesBuilder(string fieldName = "onlineStoreThemeFileBody") : this(new Query<OnlineStoreThemeFileBody>(fieldName))
        {
        }

        public OnlineStoreThemeFileBodyUnionCasesBuilder(IQuery<OnlineStoreThemeFileBody> query) : base(query)
        {
        }

        public OnlineStoreThemeFileBodyUnionCasesBuilder OnOnlineStoreThemeFileBodyBase64(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileBodyBase64QueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileBodyBase64>("... on OnlineStoreThemeFileBodyBase64");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileBodyBase64QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OnlineStoreThemeFileBodyUnionCasesBuilder OnOnlineStoreThemeFileBodyText(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileBodyTextQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileBodyText>("... on OnlineStoreThemeFileBodyText");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileBodyTextQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OnlineStoreThemeFileBodyUnionCasesBuilder OnOnlineStoreThemeFileBodyUrl(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileBodyUrlQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileBodyUrl>("... on OnlineStoreThemeFileBodyUrl");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileBodyUrlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}