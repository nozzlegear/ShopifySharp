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
    public sealed class CommentEventEmbedResourcePublicationsArgumentsBuilder : ArgumentsBuilderBase<ResourcePublicationConnection?, CommentEventEmbedResourcePublicationsArgumentsBuilder>
    {
        protected override CommentEventEmbedResourcePublicationsArgumentsBuilder Self => this;

        public CommentEventEmbedResourcePublicationsArgumentsBuilder(IQuery<ResourcePublicationConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedResourcePublicationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedResourcePublicationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedResourcePublicationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedResourcePublicationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedResourcePublicationsArgumentsBuilder OnlyPublished(bool? onlyPublished)
        {
            base.InnerQuery.AddArgument("onlyPublished", onlyPublished);
            return this;
        }

        public CommentEventEmbedResourcePublicationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}