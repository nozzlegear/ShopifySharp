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