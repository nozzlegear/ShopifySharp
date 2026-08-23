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
    public sealed class CommentEventEmbedMetafieldsArgumentsBuilder : ArgumentsBuilderBase<MetafieldConnection?, CommentEventEmbedMetafieldsArgumentsBuilder>
    {
        protected override CommentEventEmbedMetafieldsArgumentsBuilder Self => this;

        public CommentEventEmbedMetafieldsArgumentsBuilder(IQuery<MetafieldConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedMetafieldsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedMetafieldsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedMetafieldsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedMetafieldsArgumentsBuilder Keys(ICollection<string>? keys)
        {
            base.InnerQuery.AddArgument("keys", keys);
            return this;
        }

        public CommentEventEmbedMetafieldsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedMetafieldsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public CommentEventEmbedMetafieldsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}