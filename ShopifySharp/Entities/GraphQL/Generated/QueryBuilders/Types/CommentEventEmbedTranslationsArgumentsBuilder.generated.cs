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
    public sealed class CommentEventEmbedTranslationsArgumentsBuilder : ArgumentsBuilderBase<Translation?, CommentEventEmbedTranslationsArgumentsBuilder>
    {
        protected override CommentEventEmbedTranslationsArgumentsBuilder Self => this;

        public CommentEventEmbedTranslationsArgumentsBuilder(IQuery<Translation?> query) : base(query)
        {
        }

        public CommentEventEmbedTranslationsArgumentsBuilder Locale(string? locale)
        {
            base.InnerQuery.AddArgument("locale", locale);
            return this;
        }

        public CommentEventEmbedTranslationsArgumentsBuilder MarketId(string? marketId)
        {
            base.InnerQuery.AddArgument("marketId", marketId);
            return this;
        }
    }
}