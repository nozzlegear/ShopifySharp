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
    public sealed class CommentEventEmbedResourcePublicationsV2ArgumentsBuilder : ArgumentsBuilderBase<ResourcePublicationV2Connection?, CommentEventEmbedResourcePublicationsV2ArgumentsBuilder>
    {
        protected override CommentEventEmbedResourcePublicationsV2ArgumentsBuilder Self => this;

        public CommentEventEmbedResourcePublicationsV2ArgumentsBuilder(IQuery<ResourcePublicationV2Connection?> query) : base(query)
        {
        }

        public CommentEventEmbedResourcePublicationsV2ArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedResourcePublicationsV2ArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedResourcePublicationsV2ArgumentsBuilder CatalogType(CatalogType? catalogType)
        {
            base.InnerQuery.AddArgument("catalogType", catalogType);
            return this;
        }

        public CommentEventEmbedResourcePublicationsV2ArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedResourcePublicationsV2ArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedResourcePublicationsV2ArgumentsBuilder OnlyPublished(bool? onlyPublished)
        {
            base.InnerQuery.AddArgument("onlyPublished", onlyPublished);
            return this;
        }

        public CommentEventEmbedResourcePublicationsV2ArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}