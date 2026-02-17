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
    public sealed class OnlineStoreQueryBuilder : FieldsQueryBuilderBase<OnlineStore, OnlineStoreQueryBuilder>
    {
        protected override OnlineStoreQueryBuilder Self => this;

        public OnlineStoreQueryBuilder() : this("onlineStore")
        {
        }

        public OnlineStoreQueryBuilder(string name) : base(new Query<OnlineStore>(name))
        {
        }

        public OnlineStoreQueryBuilder(IQuery<OnlineStore> query) : base(query)
        {
        }

        public OnlineStoreQueryBuilder PasswordProtection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStorePasswordProtectionQueryBuilder> build)
        {
            var query = new Query<OnlineStorePasswordProtection>("passwordProtection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStorePasswordProtectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStorePasswordProtection>(query);
            return this;
        }
    }
}