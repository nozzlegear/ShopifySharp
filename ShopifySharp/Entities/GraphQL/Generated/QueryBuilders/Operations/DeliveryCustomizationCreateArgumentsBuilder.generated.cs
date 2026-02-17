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