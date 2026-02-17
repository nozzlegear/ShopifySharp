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