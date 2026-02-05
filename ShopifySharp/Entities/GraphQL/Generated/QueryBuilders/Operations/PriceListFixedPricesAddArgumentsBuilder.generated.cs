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
    public sealed class PriceListFixedPricesAddArgumentsBuilder : ArgumentsBuilderBase<PriceListFixedPricesAddPayload, PriceListFixedPricesAddArgumentsBuilder>
    {
        protected override PriceListFixedPricesAddArgumentsBuilder Self => this;

        public PriceListFixedPricesAddArgumentsBuilder(IQuery<PriceListFixedPricesAddPayload> query) : base(query)
        {
        }

        public PriceListFixedPricesAddArgumentsBuilder PriceListId(string? priceListId)
        {
            base.InnerQuery.AddArgument("priceListId", priceListId);
            return this;
        }

        public PriceListFixedPricesAddArgumentsBuilder Prices(ICollection<PriceListPriceInput>? prices)
        {
            base.InnerQuery.AddArgument("prices", prices);
            return this;
        }
    }
}