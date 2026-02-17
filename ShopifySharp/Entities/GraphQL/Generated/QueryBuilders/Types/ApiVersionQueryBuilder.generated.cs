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
    public sealed class ApiVersionQueryBuilder : FieldsQueryBuilderBase<ApiVersion, ApiVersionQueryBuilder>
    {
        protected override ApiVersionQueryBuilder Self => this;

        public ApiVersionQueryBuilder() : this("apiVersion")
        {
        }

        public ApiVersionQueryBuilder(string name) : base(new Query<ApiVersion>(name))
        {
        }

        public ApiVersionQueryBuilder(IQuery<ApiVersion> query) : base(query)
        {
        }

        public ApiVersionQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public ApiVersionQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ApiVersionQueryBuilder Supported()
        {
            base.InnerQuery.AddField("supported");
            return this;
        }
    }
}