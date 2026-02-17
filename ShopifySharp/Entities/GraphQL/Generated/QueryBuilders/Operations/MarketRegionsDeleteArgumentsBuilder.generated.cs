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