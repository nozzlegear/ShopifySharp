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
    public sealed class QueryRootReturnReasonDefinitionsArgumentsBuilder : ArgumentsBuilderBase<ReturnReasonDefinitionConnection?, QueryRootReturnReasonDefinitionsArgumentsBuilder>
    {
        protected override QueryRootReturnReasonDefinitionsArgumentsBuilder Self => this;

        public QueryRootReturnReasonDefinitionsArgumentsBuilder(IQuery<ReturnReasonDefinitionConnection?> query) : base(query)
        {
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder Handles(ICollection<string>? handles)
        {
            base.InnerQuery.AddArgument("handles", handles);
            return this;
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootReturnReasonDefinitionsArgumentsBuilder SortKey(ReturnReasonDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}