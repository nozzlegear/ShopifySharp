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
    public sealed class PageMetafieldDefinitionsArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionConnection?, PageMetafieldDefinitionsArgumentsBuilder>
    {
        protected override PageMetafieldDefinitionsArgumentsBuilder Self => this;

        public PageMetafieldDefinitionsArgumentsBuilder(IQuery<MetafieldDefinitionConnection?> query) : base(query)
        {
        }

        public PageMetafieldDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PageMetafieldDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PageMetafieldDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PageMetafieldDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PageMetafieldDefinitionsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public PageMetafieldDefinitionsArgumentsBuilder PinnedStatus(MetafieldDefinitionPinnedStatus? pinnedStatus)
        {
            base.InnerQuery.AddArgument("pinnedStatus", pinnedStatus);
            return this;
        }

        public PageMetafieldDefinitionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public PageMetafieldDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public PageMetafieldDefinitionsArgumentsBuilder SortKey(MetafieldDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}