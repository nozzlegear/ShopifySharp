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
    public sealed class OnlineStoreThemeFileBodyUnionCasesBuilder : UnionCasesBuilderBase<OnlineStoreThemeFileBody, OnlineStoreThemeFileBodyUnionCasesBuilder>
    {
        protected override OnlineStoreThemeFileBodyUnionCasesBuilder Self => this;

        public OnlineStoreThemeFileBodyUnionCasesBuilder(string fieldName = "onlineStoreThemeFileBody") : this(new Query<OnlineStoreThemeFileBody>(fieldName))
        {
        }

        public OnlineStoreThemeFileBodyUnionCasesBuilder(IQuery<OnlineStoreThemeFileBody> query) : base(query)
        {
        }

        public OnlineStoreThemeFileBodyUnionCasesBuilder OnOnlineStoreThemeFileBodyBase64(Action<OnlineStoreThemeFileBodyBase64QueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileBodyBase64>("... on OnlineStoreThemeFileBodyBase64");
            var queryBuilder = new OnlineStoreThemeFileBodyBase64QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OnlineStoreThemeFileBodyUnionCasesBuilder OnOnlineStoreThemeFileBodyText(Action<OnlineStoreThemeFileBodyTextQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileBodyText>("... on OnlineStoreThemeFileBodyText");
            var queryBuilder = new OnlineStoreThemeFileBodyTextQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OnlineStoreThemeFileBodyUnionCasesBuilder OnOnlineStoreThemeFileBodyUrl(Action<OnlineStoreThemeFileBodyUrlQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileBodyUrl>("... on OnlineStoreThemeFileBodyUrl");
            var queryBuilder = new OnlineStoreThemeFileBodyUrlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}