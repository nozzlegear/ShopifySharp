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
    public sealed class CommentEventEmbedPublicationsArgumentsBuilder : ArgumentsBuilderBase<ProductPublicationConnection?, CommentEventEmbedPublicationsArgumentsBuilder>
    {
        protected override CommentEventEmbedPublicationsArgumentsBuilder Self => this;

        public CommentEventEmbedPublicationsArgumentsBuilder(IQuery<ProductPublicationConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedPublicationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedPublicationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedPublicationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedPublicationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedPublicationsArgumentsBuilder OnlyPublished(bool? onlyPublished)
        {
            base.InnerQuery.AddArgument("onlyPublished", onlyPublished);
            return this;
        }

        public CommentEventEmbedPublicationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}