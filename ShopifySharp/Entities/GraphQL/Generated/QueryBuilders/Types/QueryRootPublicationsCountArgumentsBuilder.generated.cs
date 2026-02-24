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
    public sealed class QueryRootPublicationsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, QueryRootPublicationsCountArgumentsBuilder>
    {
        protected override QueryRootPublicationsCountArgumentsBuilder Self => this;

        public QueryRootPublicationsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public QueryRootPublicationsCountArgumentsBuilder CatalogType(CatalogType? catalogType)
        {
            base.InnerQuery.AddArgument("catalogType", catalogType);
            return this;
        }

        public QueryRootPublicationsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }
    }
}