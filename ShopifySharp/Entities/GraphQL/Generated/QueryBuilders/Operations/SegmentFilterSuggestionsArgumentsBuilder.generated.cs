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
    public sealed class SegmentFilterSuggestionsArgumentsBuilder : ArgumentsBuilderBase<SegmentFilterConnection, SegmentFilterSuggestionsArgumentsBuilder>
    {
        protected override SegmentFilterSuggestionsArgumentsBuilder Self => this;

        public SegmentFilterSuggestionsArgumentsBuilder(IQuery<SegmentFilterConnection> query) : base(query)
        {
        }

        public SegmentFilterSuggestionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SegmentFilterSuggestionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SegmentFilterSuggestionsArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}