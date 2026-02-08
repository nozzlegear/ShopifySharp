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
    public sealed class DeliveryCustomizationCreateArgumentsBuilder : ArgumentsBuilderBase<DeliveryCustomizationCreatePayload, DeliveryCustomizationCreateArgumentsBuilder>
    {
        protected override DeliveryCustomizationCreateArgumentsBuilder Self => this;

        public DeliveryCustomizationCreateArgumentsBuilder(IQuery<DeliveryCustomizationCreatePayload> query) : base(query)
        {
        }

        public DeliveryCustomizationCreateArgumentsBuilder DeliveryCustomization(DeliveryCustomizationInput? deliveryCustomization)
        {
            base.InnerQuery.AddArgument("deliveryCustomization", deliveryCustomization);
            return this;
        }
    }
}