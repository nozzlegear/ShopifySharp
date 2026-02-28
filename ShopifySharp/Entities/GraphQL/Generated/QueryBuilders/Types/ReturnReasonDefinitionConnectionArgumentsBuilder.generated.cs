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
    public sealed class ReturnReasonDefinitionConnectionArgumentsBuilder : ArgumentsBuilderBase<ReturnReasonDefinitionConnection, ReturnReasonDefinitionConnectionArgumentsBuilder>
    {
        protected override ReturnReasonDefinitionConnectionArgumentsBuilder Self => this;

        public ReturnReasonDefinitionConnectionArgumentsBuilder(IQuery<ReturnReasonDefinitionConnection> query) : base(query)
        {
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder Handles(ICollection<string>? handles)
        {
            base.InnerQuery.AddArgument("handles", handles);
            return this;
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ReturnReasonDefinitionConnectionArgumentsBuilder SortKey(ReturnReasonDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}