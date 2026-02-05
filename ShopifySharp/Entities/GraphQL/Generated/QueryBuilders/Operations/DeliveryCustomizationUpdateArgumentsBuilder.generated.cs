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
    public sealed class DeliveryCustomizationUpdateArgumentsBuilder : ArgumentsBuilderBase<DeliveryCustomizationUpdatePayload, DeliveryCustomizationUpdateArgumentsBuilder>
    {
        protected override DeliveryCustomizationUpdateArgumentsBuilder Self => this;

        public DeliveryCustomizationUpdateArgumentsBuilder(IQuery<DeliveryCustomizationUpdatePayload> query) : base(query)
        {
        }

        public DeliveryCustomizationUpdateArgumentsBuilder DeliveryCustomization(DeliveryCustomizationInput? deliveryCustomization)
        {
            base.InnerQuery.AddArgument("deliveryCustomization", deliveryCustomization);
            return this;
        }

        public DeliveryCustomizationUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}