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
    public sealed class MarketCatalogMarketsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, MarketCatalogMarketsCountArgumentsBuilder>
    {
        protected override MarketCatalogMarketsCountArgumentsBuilder Self => this;

        public MarketCatalogMarketsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public MarketCatalogMarketsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public MarketCatalogMarketsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MarketCatalogMarketsCountArgumentsBuilder Status(MarketStatus? status)
        {
            base.InnerQuery.AddArgument("status", status);
            return this;
        }

        public MarketCatalogMarketsCountArgumentsBuilder Type(MarketType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}