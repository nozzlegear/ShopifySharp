#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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