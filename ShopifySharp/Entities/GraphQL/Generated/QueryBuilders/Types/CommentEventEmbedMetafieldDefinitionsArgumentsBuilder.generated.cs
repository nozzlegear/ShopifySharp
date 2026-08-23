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
    public sealed class CommentEventEmbedMetafieldDefinitionsArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionConnection?, CommentEventEmbedMetafieldDefinitionsArgumentsBuilder>
    {
        protected override CommentEventEmbedMetafieldDefinitionsArgumentsBuilder Self => this;

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder(IQuery<MetafieldDefinitionConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder PinnedStatus(MetafieldDefinitionPinnedStatus? pinnedStatus)
        {
            base.InnerQuery.AddArgument("pinnedStatus", pinnedStatus);
            return this;
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CommentEventEmbedMetafieldDefinitionsArgumentsBuilder SortKey(MetafieldDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}