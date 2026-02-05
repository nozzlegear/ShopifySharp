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
    public sealed class PriceListFixedPricesDeleteArgumentsBuilder : ArgumentsBuilderBase<PriceListFixedPricesDeletePayload, PriceListFixedPricesDeleteArgumentsBuilder>
    {
        protected override PriceListFixedPricesDeleteArgumentsBuilder Self => this;

        public PriceListFixedPricesDeleteArgumentsBuilder(IQuery<PriceListFixedPricesDeletePayload> query) : base(query)
        {
        }

        public PriceListFixedPricesDeleteArgumentsBuilder PriceListId(string? priceListId)
        {
            base.InnerQuery.AddArgument("priceListId", priceListId);
            return this;
        }

        public PriceListFixedPricesDeleteArgumentsBuilder VariantIds(ICollection<string>? variantIds)
        {
            base.InnerQuery.AddArgument("variantIds", variantIds);
            return this;
        }
    }
}