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
    public sealed class MarketArgumentsBuilder : ArgumentsBuilderBase<Market, MarketArgumentsBuilder>
    {
        protected override MarketArgumentsBuilder Self => this;

        public MarketArgumentsBuilder(IQuery<Market> query) : base(query)
        {
        }

        public MarketArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public MarketArgumentsBuilder CountryCode(CountryCode? countryCode)
        {
            base.InnerQuery.AddArgument("countryCode", countryCode);
            return this;
        }
    }
}