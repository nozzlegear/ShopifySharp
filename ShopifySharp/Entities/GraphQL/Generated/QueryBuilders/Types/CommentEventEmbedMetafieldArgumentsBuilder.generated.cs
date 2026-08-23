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
    public sealed class CommentEventEmbedMetafieldArgumentsBuilder : ArgumentsBuilderBase<Metafield?, CommentEventEmbedMetafieldArgumentsBuilder>
    {
        protected override CommentEventEmbedMetafieldArgumentsBuilder Self => this;

        public CommentEventEmbedMetafieldArgumentsBuilder(IQuery<Metafield?> query) : base(query)
        {
        }

        public CommentEventEmbedMetafieldArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public CommentEventEmbedMetafieldArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }
    }
}