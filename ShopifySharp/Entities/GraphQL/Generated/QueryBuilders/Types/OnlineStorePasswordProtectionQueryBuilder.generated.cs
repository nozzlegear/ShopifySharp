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