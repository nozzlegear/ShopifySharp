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
    public sealed class QueryRootProductVariantsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, QueryRootProductVariantsCountArgumentsBuilder>
    {
        protected override QueryRootProductVariantsCountArgumentsBuilder Self => this;

        public QueryRootProductVariantsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public QueryRootProductVariantsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public QueryRootProductVariantsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}