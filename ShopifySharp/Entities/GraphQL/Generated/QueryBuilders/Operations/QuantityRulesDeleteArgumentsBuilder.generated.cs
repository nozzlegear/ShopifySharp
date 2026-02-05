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
    public sealed class QuantityRulesDeleteArgumentsBuilder : ArgumentsBuilderBase<QuantityRulesDeletePayload, QuantityRulesDeleteArgumentsBuilder>
    {
        protected override QuantityRulesDeleteArgumentsBuilder Self => this;

        public QuantityRulesDeleteArgumentsBuilder(IQuery<QuantityRulesDeletePayload> query) : base(query)
        {
        }

        public QuantityRulesDeleteArgumentsBuilder PriceListId(string? priceListId)
        {
            base.InnerQuery.AddArgument("priceListId", priceListId);
            return this;
        }

        public QuantityRulesDeleteArgumentsBuilder VariantIds(ICollection<string>? variantIds)
        {
            base.InnerQuery.AddArgument("variantIds", variantIds);
            return this;
        }
    }
}