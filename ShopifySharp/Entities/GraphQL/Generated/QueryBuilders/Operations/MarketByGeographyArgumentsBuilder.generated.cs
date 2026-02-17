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
    public sealed class MarketByGeographyArgumentsBuilder : ArgumentsBuilderBase<Market, MarketByGeographyArgumentsBuilder>
    {
        protected override MarketByGeographyArgumentsBuilder Self => this;

        public MarketByGeographyArgumentsBuilder(IQuery<Market> query) : base(query)
        {
        }

        public MarketByGeographyArgumentsBuilder CountryCode(CountryCode? countryCode)
        {
            base.InnerQuery.AddArgument("countryCode", countryCode);
            return this;
        }
    }
}