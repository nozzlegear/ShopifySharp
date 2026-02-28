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
    public sealed class LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder : ArgumentsBuilderBase<ReturnReasonDefinitionConnection?, LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder>
    {
        protected override LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder Self => this;

        public LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder(IQuery<ReturnReasonDefinitionConnection?> query) : base(query)
        {
        }

        public LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}