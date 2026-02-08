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
    public sealed class DeliveryCustomizationActivationArgumentsBuilder : ArgumentsBuilderBase<DeliveryCustomizationActivationPayload, DeliveryCustomizationActivationArgumentsBuilder>
    {
        protected override DeliveryCustomizationActivationArgumentsBuilder Self => this;

        public DeliveryCustomizationActivationArgumentsBuilder(IQuery<DeliveryCustomizationActivationPayload> query) : base(query)
        {
        }

        public DeliveryCustomizationActivationArgumentsBuilder Enabled(bool? enabled)
        {
            base.InnerQuery.AddArgument("enabled", enabled);
            return this;
        }

        public DeliveryCustomizationActivationArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }
    }
}