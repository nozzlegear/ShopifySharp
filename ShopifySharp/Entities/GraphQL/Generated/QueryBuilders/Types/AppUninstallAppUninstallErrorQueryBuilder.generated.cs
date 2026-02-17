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
    public sealed class AppUninstallAppUninstallErrorQueryBuilder : FieldsQueryBuilderBase<AppUninstallAppUninstallError, AppUninstallAppUninstallErrorQueryBuilder>
    {
        protected override AppUninstallAppUninstallErrorQueryBuilder Self => this;

        public AppUninstallAppUninstallErrorQueryBuilder() : this("appUninstallAppUninstallError")
        {
        }

        public AppUninstallAppUninstallErrorQueryBuilder(string name) : base(new Query<AppUninstallAppUninstallError>(name))
        {
        }

        public AppUninstallAppUninstallErrorQueryBuilder(IQuery<AppUninstallAppUninstallError> query) : base(query)
        {
        }

        public AppUninstallAppUninstallErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public AppUninstallAppUninstallErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public AppUninstallAppUninstallErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}