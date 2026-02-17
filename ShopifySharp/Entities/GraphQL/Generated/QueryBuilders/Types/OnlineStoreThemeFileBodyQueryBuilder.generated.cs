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
    public sealed class OnlineStoreThemeFileBodyQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFileBody, OnlineStoreThemeFileBodyQueryBuilder>
    {
        protected override OnlineStoreThemeFileBodyQueryBuilder Self => this;

        public OnlineStoreThemeFileBodyQueryBuilder() : this("onlineStoreThemeFileBody")
        {
        }

        public OnlineStoreThemeFileBodyQueryBuilder(string name) : base(new Query<OnlineStoreThemeFileBody>(name))
        {
        }

        public OnlineStoreThemeFileBodyQueryBuilder(IQuery<OnlineStoreThemeFileBody> query) : base(query)
        {
        }

        public OnlineStoreThemeFileBodyQueryBuilder OnlineStoreThemeFileBody(Action<OnlineStoreThemeFileBodyUnionCasesBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileBody>("onlineStoreThemeFileBody");
            var unionBuilder = new OnlineStoreThemeFileBodyUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}