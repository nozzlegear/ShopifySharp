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
    public sealed class QueryRootSegmentFilterSuggestionsArgumentsBuilder : ArgumentsBuilderBase<SegmentFilterConnection?, QueryRootSegmentFilterSuggestionsArgumentsBuilder>
    {
        protected override QueryRootSegmentFilterSuggestionsArgumentsBuilder Self => this;

        public QueryRootSegmentFilterSuggestionsArgumentsBuilder(IQuery<SegmentFilterConnection?> query) : base(query)
        {
        }

        public QueryRootSegmentFilterSuggestionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootSegmentFilterSuggestionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootSegmentFilterSuggestionsArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}