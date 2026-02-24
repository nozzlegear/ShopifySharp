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
    public sealed class MarketCatalogMarketsArgumentsBuilder : ArgumentsBuilderBase<MarketConnection?, MarketCatalogMarketsArgumentsBuilder>
    {
        protected override MarketCatalogMarketsArgumentsBuilder Self => this;

        public MarketCatalogMarketsArgumentsBuilder(IQuery<MarketConnection?> query) : base(query)
        {
        }

        public MarketCatalogMarketsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MarketCatalogMarketsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MarketCatalogMarketsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MarketCatalogMarketsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MarketCatalogMarketsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MarketCatalogMarketsArgumentsBuilder Status(MarketStatus? status)
        {
            base.InnerQuery.AddArgument("status", status);
            return this;
        }

        public MarketCatalogMarketsArgumentsBuilder Type(MarketType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}