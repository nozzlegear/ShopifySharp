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
    public sealed class DeliveryCustomizationArgumentsBuilder : ArgumentsBuilderBase<DeliveryCustomization, DeliveryCustomizationArgumentsBuilder>
    {
        protected override DeliveryCustomizationArgumentsBuilder Self => this;

        public DeliveryCustomizationArgumentsBuilder(IQuery<DeliveryCustomization> query) : base(query)
        {
        }

        public DeliveryCustomizationArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}