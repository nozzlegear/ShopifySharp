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
    public sealed class MarketLocalizationsRemoveArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizationsRemovePayload, MarketLocalizationsRemoveArgumentsBuilder>
    {
        protected override MarketLocalizationsRemoveArgumentsBuilder Self => this;

        public MarketLocalizationsRemoveArgumentsBuilder(IQuery<MarketLocalizationsRemovePayload> query) : base(query)
        {
        }

        public MarketLocalizationsRemoveArgumentsBuilder MarketIds(ICollection<string>? marketIds)
        {
            base.InnerQuery.AddArgument("marketIds", marketIds);
            return this;
        }

        public MarketLocalizationsRemoveArgumentsBuilder MarketLocalizationKeys(ICollection<string>? marketLocalizationKeys)
        {
            base.InnerQuery.AddArgument("marketLocalizationKeys", marketLocalizationKeys);
            return this;
        }

        public MarketLocalizationsRemoveArgumentsBuilder ResourceId(string? resourceId)
        {
            base.InnerQuery.AddArgument("resourceId", resourceId);
            return this;
        }
    }
}