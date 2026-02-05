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
    public sealed class PriceListFixedPricesUpdateArgumentsBuilder : ArgumentsBuilderBase<PriceListFixedPricesUpdatePayload, PriceListFixedPricesUpdateArgumentsBuilder>
    {
        protected override PriceListFixedPricesUpdateArgumentsBuilder Self => this;

        public PriceListFixedPricesUpdateArgumentsBuilder(IQuery<PriceListFixedPricesUpdatePayload> query) : base(query)
        {
        }

        public PriceListFixedPricesUpdateArgumentsBuilder PriceListId(string? priceListId)
        {
            base.InnerQuery.AddArgument("priceListId", priceListId);
            return this;
        }

        public PriceListFixedPricesUpdateArgumentsBuilder PricesToAdd(ICollection<PriceListPriceInput>? pricesToAdd)
        {
            base.InnerQuery.AddArgument("pricesToAdd", pricesToAdd);
            return this;
        }

        public PriceListFixedPricesUpdateArgumentsBuilder VariantIdsToDelete(ICollection<string>? variantIdsToDelete)
        {
            base.InnerQuery.AddArgument("variantIdsToDelete", variantIdsToDelete);
            return this;
        }
    }
}