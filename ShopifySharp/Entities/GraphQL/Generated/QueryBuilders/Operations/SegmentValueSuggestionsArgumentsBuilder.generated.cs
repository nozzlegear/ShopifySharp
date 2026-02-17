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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class SegmentValueSuggestionsArgumentsBuilder : ArgumentsBuilderBase<SegmentValueConnection, SegmentValueSuggestionsArgumentsBuilder>
    {
        protected override SegmentValueSuggestionsArgumentsBuilder Self => this;

        public SegmentValueSuggestionsArgumentsBuilder(IQuery<SegmentValueConnection> query) : base(query)
        {
        }

        public SegmentValueSuggestionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SegmentValueSuggestionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SegmentValueSuggestionsArgumentsBuilder FilterQueryName(string? filterQueryName)
        {
            base.InnerQuery.AddArgument("filterQueryName", filterQueryName);
            return this;
        }

        public SegmentValueSuggestionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SegmentValueSuggestionsArgumentsBuilder FunctionParameterQueryName(string? functionParameterQueryName)
        {
            base.InnerQuery.AddArgument("functionParameterQueryName", functionParameterQueryName);
            return this;
        }

        public SegmentValueSuggestionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SegmentValueSuggestionsArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}