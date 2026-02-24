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
    public sealed class QueryRootSegmentValueSuggestionsArgumentsBuilder : ArgumentsBuilderBase<SegmentValueConnection?, QueryRootSegmentValueSuggestionsArgumentsBuilder>
    {
        protected override QueryRootSegmentValueSuggestionsArgumentsBuilder Self => this;

        public QueryRootSegmentValueSuggestionsArgumentsBuilder(IQuery<SegmentValueConnection?> query) : base(query)
        {
        }

        public QueryRootSegmentValueSuggestionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootSegmentValueSuggestionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootSegmentValueSuggestionsArgumentsBuilder FilterQueryName(string? filterQueryName)
        {
            base.InnerQuery.AddArgument("filterQueryName", filterQueryName);
            return this;
        }

        public QueryRootSegmentValueSuggestionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootSegmentValueSuggestionsArgumentsBuilder FunctionParameterQueryName(string? functionParameterQueryName)
        {
            base.InnerQuery.AddArgument("functionParameterQueryName", functionParameterQueryName);
            return this;
        }

        public QueryRootSegmentValueSuggestionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootSegmentValueSuggestionsArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}