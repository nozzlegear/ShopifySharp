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
    public sealed class MarketRegionsDeleteArgumentsBuilder : ArgumentsBuilderBase<MarketRegionsDeletePayload, MarketRegionsDeleteArgumentsBuilder>
    {
        protected override MarketRegionsDeleteArgumentsBuilder Self => this;

        public MarketRegionsDeleteArgumentsBuilder(IQuery<MarketRegionsDeletePayload> query) : base(query)
        {
        }

        public MarketRegionsDeleteArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }
    }
}