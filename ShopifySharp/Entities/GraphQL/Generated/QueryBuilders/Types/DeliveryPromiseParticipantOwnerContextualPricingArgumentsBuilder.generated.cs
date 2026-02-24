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
    public sealed class DeliveryPromiseParticipantOwnerContextualPricingArgumentsBuilder : ArgumentsBuilderBase<ProductVariantContextualPricing?, DeliveryPromiseParticipantOwnerContextualPricingArgumentsBuilder>
    {
        protected override DeliveryPromiseParticipantOwnerContextualPricingArgumentsBuilder Self => this;

        public DeliveryPromiseParticipantOwnerContextualPricingArgumentsBuilder(IQuery<ProductVariantContextualPricing?> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantOwnerContextualPricingArgumentsBuilder Context(ContextualPricingContext? context)
        {
            base.InnerQuery.AddArgument("context", context);
            return this;
        }
    }
}