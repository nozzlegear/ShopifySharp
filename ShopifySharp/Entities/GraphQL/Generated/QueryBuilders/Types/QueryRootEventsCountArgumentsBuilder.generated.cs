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
    public sealed class QueryRootEventsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, QueryRootEventsCountArgumentsBuilder>
    {
        protected override QueryRootEventsCountArgumentsBuilder Self => this;

        public QueryRootEventsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public QueryRootEventsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}