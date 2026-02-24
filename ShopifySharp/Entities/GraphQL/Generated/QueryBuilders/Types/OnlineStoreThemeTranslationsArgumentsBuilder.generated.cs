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
    public sealed class OnlineStoreThemeTranslationsArgumentsBuilder : ArgumentsBuilderBase<Translation?, OnlineStoreThemeTranslationsArgumentsBuilder>
    {
        protected override OnlineStoreThemeTranslationsArgumentsBuilder Self => this;

        public OnlineStoreThemeTranslationsArgumentsBuilder(IQuery<Translation?> query) : base(query)
        {
        }

        public OnlineStoreThemeTranslationsArgumentsBuilder Locale(string? locale)
        {
            base.InnerQuery.AddArgument("locale", locale);
            return this;
        }

        public OnlineStoreThemeTranslationsArgumentsBuilder MarketId(string? marketId)
        {
            base.InnerQuery.AddArgument("marketId", marketId);
            return this;
        }
    }
}