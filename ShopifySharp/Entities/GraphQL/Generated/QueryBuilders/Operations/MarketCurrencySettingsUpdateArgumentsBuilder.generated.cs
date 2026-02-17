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
    public sealed class MarketCurrencySettingsUpdateArgumentsBuilder : ArgumentsBuilderBase<MarketCurrencySettingsUpdatePayload, MarketCurrencySettingsUpdateArgumentsBuilder>
    {
        protected override MarketCurrencySettingsUpdateArgumentsBuilder Self => this;

        public MarketCurrencySettingsUpdateArgumentsBuilder(IQuery<MarketCurrencySettingsUpdatePayload> query) : base(query)
        {
        }

        public MarketCurrencySettingsUpdateArgumentsBuilder Input(MarketCurrencySettingsUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public MarketCurrencySettingsUpdateArgumentsBuilder MarketId(string? marketId)
        {
            base.InnerQuery.AddArgument("marketId", marketId);
            return this;
        }
    }
}