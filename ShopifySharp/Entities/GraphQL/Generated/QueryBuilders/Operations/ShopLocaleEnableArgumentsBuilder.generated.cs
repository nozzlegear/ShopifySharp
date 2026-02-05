#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ShopLocaleEnableArgumentsBuilder : ArgumentsBuilderBase<ShopLocaleEnablePayload, ShopLocaleEnableArgumentsBuilder>
    {
        protected override ShopLocaleEnableArgumentsBuilder Self => this;

        public ShopLocaleEnableArgumentsBuilder(IQuery<ShopLocaleEnablePayload> query) : base(query)
        {
        }

        public ShopLocaleEnableArgumentsBuilder Locale(string? locale)
        {
            base.InnerQuery.AddArgument("locale", locale);
            return this;
        }

        public ShopLocaleEnableArgumentsBuilder MarketWebPresenceIds(ICollection<string>? marketWebPresenceIds)
        {
            base.InnerQuery.AddArgument("marketWebPresenceIds", marketWebPresenceIds);
            return this;
        }
    }
}