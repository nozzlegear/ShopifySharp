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
    public sealed class MediaImageTranslationsArgumentsBuilder : ArgumentsBuilderBase<Translation?, MediaImageTranslationsArgumentsBuilder>
    {
        protected override MediaImageTranslationsArgumentsBuilder Self => this;

        public MediaImageTranslationsArgumentsBuilder(IQuery<Translation?> query) : base(query)
        {
        }

        public MediaImageTranslationsArgumentsBuilder Locale(string? locale)
        {
            base.InnerQuery.AddArgument("locale", locale);
            return this;
        }

        public MediaImageTranslationsArgumentsBuilder MarketId(string? marketId)
        {
            base.InnerQuery.AddArgument("marketId", marketId);
            return this;
        }
    }
}