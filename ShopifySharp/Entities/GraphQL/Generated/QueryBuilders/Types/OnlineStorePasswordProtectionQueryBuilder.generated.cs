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
    public sealed class OnlineStorePasswordProtectionQueryBuilder : FieldsQueryBuilderBase<OnlineStorePasswordProtection, OnlineStorePasswordProtectionQueryBuilder>
    {
        protected override OnlineStorePasswordProtectionQueryBuilder Self => this;

        public OnlineStorePasswordProtectionQueryBuilder() : this("onlineStorePasswordProtection")
        {
        }

        public OnlineStorePasswordProtectionQueryBuilder(string name) : base(new Query<OnlineStorePasswordProtection>(name))
        {
        }

        public OnlineStorePasswordProtectionQueryBuilder(IQuery<OnlineStorePasswordProtection> query) : base(query)
        {
        }

        public OnlineStorePasswordProtectionQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}