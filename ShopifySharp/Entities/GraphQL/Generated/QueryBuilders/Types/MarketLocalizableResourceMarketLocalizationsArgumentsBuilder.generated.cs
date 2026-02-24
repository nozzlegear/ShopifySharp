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
    public sealed class MarketLocalizableResourceMarketLocalizationsArgumentsBuilder : ArgumentsBuilderBase<MarketLocalization?, MarketLocalizableResourceMarketLocalizationsArgumentsBuilder>
    {
        protected override MarketLocalizableResourceMarketLocalizationsArgumentsBuilder Self => this;

        public MarketLocalizableResourceMarketLocalizationsArgumentsBuilder(IQuery<MarketLocalization?> query) : base(query)
        {
        }

        public MarketLocalizableResourceMarketLocalizationsArgumentsBuilder MarketId(string? marketId)
        {
            base.InnerQuery.AddArgument("marketId", marketId);
            return this;
        }
    }
}