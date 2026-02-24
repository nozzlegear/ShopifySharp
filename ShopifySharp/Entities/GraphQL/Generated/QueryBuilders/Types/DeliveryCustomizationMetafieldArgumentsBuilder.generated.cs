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
    public sealed class DeliveryCustomizationMetafieldArgumentsBuilder : ArgumentsBuilderBase<Metafield?, DeliveryCustomizationMetafieldArgumentsBuilder>
    {
        protected override DeliveryCustomizationMetafieldArgumentsBuilder Self => this;

        public DeliveryCustomizationMetafieldArgumentsBuilder(IQuery<Metafield?> query) : base(query)
        {
        }

        public DeliveryCustomizationMetafieldArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public DeliveryCustomizationMetafieldArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }
    }
}