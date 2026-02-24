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
    public sealed class SegmentValueConnectionArgumentsBuilder : ArgumentsBuilderBase<SegmentValueConnection, SegmentValueConnectionArgumentsBuilder>
    {
        protected override SegmentValueConnectionArgumentsBuilder Self => this;

        public SegmentValueConnectionArgumentsBuilder(IQuery<SegmentValueConnection> query) : base(query)
        {
        }

        public SegmentValueConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SegmentValueConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SegmentValueConnectionArgumentsBuilder FilterQueryName(string? filterQueryName)
        {
            base.InnerQuery.AddArgument("filterQueryName", filterQueryName);
            return this;
        }

        public SegmentValueConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SegmentValueConnectionArgumentsBuilder FunctionParameterQueryName(string? functionParameterQueryName)
        {
            base.InnerQuery.AddArgument("functionParameterQueryName", functionParameterQueryName);
            return this;
        }

        public SegmentValueConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SegmentValueConnectionArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}