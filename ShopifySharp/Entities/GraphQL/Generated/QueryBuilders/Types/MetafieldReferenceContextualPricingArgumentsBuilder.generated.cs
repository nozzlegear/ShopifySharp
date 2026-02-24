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
    public sealed class MetafieldReferenceContextualPricingArgumentsBuilder : ArgumentsBuilderBase<ProductVariantContextualPricing?, MetafieldReferenceContextualPricingArgumentsBuilder>
    {
        protected override MetafieldReferenceContextualPricingArgumentsBuilder Self => this;

        public MetafieldReferenceContextualPricingArgumentsBuilder(IQuery<ProductVariantContextualPricing?> query) : base(query)
        {
        }

        public MetafieldReferenceContextualPricingArgumentsBuilder Context(ContextualPricingContext? context)
        {
            base.InnerQuery.AddArgument("context", context);
            return this;
        }
    }
}