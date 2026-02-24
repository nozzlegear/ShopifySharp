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
    public sealed class QueryRootMarketByGeographyArgumentsBuilder : ArgumentsBuilderBase<Market?, QueryRootMarketByGeographyArgumentsBuilder>
    {
        protected override QueryRootMarketByGeographyArgumentsBuilder Self => this;

        public QueryRootMarketByGeographyArgumentsBuilder(IQuery<Market?> query) : base(query)
        {
        }

        public QueryRootMarketByGeographyArgumentsBuilder CountryCode(CountryCode? countryCode)
        {
            base.InnerQuery.AddArgument("countryCode", countryCode);
            return this;
        }
    }
}