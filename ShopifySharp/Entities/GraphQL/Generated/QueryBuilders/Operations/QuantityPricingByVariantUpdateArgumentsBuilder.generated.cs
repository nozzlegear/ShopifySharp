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
    public sealed class QuantityPricingByVariantUpdateArgumentsBuilder : ArgumentsBuilderBase<QuantityPricingByVariantUpdatePayload, QuantityPricingByVariantUpdateArgumentsBuilder>
    {
        protected override QuantityPricingByVariantUpdateArgumentsBuilder Self => this;

        public QuantityPricingByVariantUpdateArgumentsBuilder(IQuery<QuantityPricingByVariantUpdatePayload> query) : base(query)
        {
        }

        public QuantityPricingByVariantUpdateArgumentsBuilder Input(QuantityPricingByVariantUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public QuantityPricingByVariantUpdateArgumentsBuilder PriceListId(string? priceListId)
        {
            base.InnerQuery.AddArgument("priceListId", priceListId);
            return this;
        }
    }
}