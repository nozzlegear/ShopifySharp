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
    public sealed class PriceListFixedPricesByProductUpdateArgumentsBuilder : ArgumentsBuilderBase<PriceListFixedPricesByProductUpdatePayload, PriceListFixedPricesByProductUpdateArgumentsBuilder>
    {
        protected override PriceListFixedPricesByProductUpdateArgumentsBuilder Self => this;

        public PriceListFixedPricesByProductUpdateArgumentsBuilder(IQuery<PriceListFixedPricesByProductUpdatePayload> query) : base(query)
        {
        }

        public PriceListFixedPricesByProductUpdateArgumentsBuilder PriceListId(string? priceListId)
        {
            base.InnerQuery.AddArgument("priceListId", priceListId);
            return this;
        }

        public PriceListFixedPricesByProductUpdateArgumentsBuilder PricesToAdd(ICollection<PriceListProductPriceInput>? pricesToAdd)
        {
            base.InnerQuery.AddArgument("pricesToAdd", pricesToAdd);
            return this;
        }

        public PriceListFixedPricesByProductUpdateArgumentsBuilder PricesToDeleteByProductIds(ICollection<string>? pricesToDeleteByProductIds)
        {
            base.InnerQuery.AddArgument("pricesToDeleteByProductIds", pricesToDeleteByProductIds);
            return this;
        }
    }
}