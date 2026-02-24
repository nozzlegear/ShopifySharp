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
    public sealed class QueryRootCatalogsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, QueryRootCatalogsCountArgumentsBuilder>
    {
        protected override QueryRootCatalogsCountArgumentsBuilder Self => this;

        public QueryRootCatalogsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public QueryRootCatalogsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public QueryRootCatalogsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootCatalogsCountArgumentsBuilder Type(CatalogType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}