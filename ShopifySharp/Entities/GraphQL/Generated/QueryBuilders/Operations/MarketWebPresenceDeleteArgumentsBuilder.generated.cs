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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class MarketWebPresenceDeleteArgumentsBuilder : ArgumentsBuilderBase<MarketWebPresenceDeletePayload, MarketWebPresenceDeleteArgumentsBuilder>
    {
        protected override MarketWebPresenceDeleteArgumentsBuilder Self => this;

        public MarketWebPresenceDeleteArgumentsBuilder(IQuery<MarketWebPresenceDeletePayload> query) : base(query)
        {
        }

        public MarketWebPresenceDeleteArgumentsBuilder WebPresenceId(string? webPresenceId)
        {
            base.InnerQuery.AddArgument("webPresenceId", webPresenceId);
            return this;
        }
    }
}