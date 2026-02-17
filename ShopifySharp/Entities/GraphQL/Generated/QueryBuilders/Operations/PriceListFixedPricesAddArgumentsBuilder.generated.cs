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