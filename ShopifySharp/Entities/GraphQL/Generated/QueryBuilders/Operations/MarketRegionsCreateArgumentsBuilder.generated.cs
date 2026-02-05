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
    public sealed class MarketRegionsCreateArgumentsBuilder : ArgumentsBuilderBase<MarketRegionsCreatePayload, MarketRegionsCreateArgumentsBuilder>
    {
        protected override MarketRegionsCreateArgumentsBuilder Self => this;

        public MarketRegionsCreateArgumentsBuilder(IQuery<MarketRegionsCreatePayload> query) : base(query)
        {
        }

        public MarketRegionsCreateArgumentsBuilder MarketId(string? marketId)
        {
            base.InnerQuery.AddArgument("marketId", marketId);
            return this;
        }

        public MarketRegionsCreateArgumentsBuilder Regions(ICollection<MarketRegionCreateInput>? regions)
        {
            base.InnerQuery.AddArgument("regions", regions);
            return this;
        }
    }
}