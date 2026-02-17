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
    public sealed class DeliveryPromiseProviderArgumentsBuilder : ArgumentsBuilderBase<DeliveryPromiseProvider, DeliveryPromiseProviderArgumentsBuilder>
    {
        protected override DeliveryPromiseProviderArgumentsBuilder Self => this;

        public DeliveryPromiseProviderArgumentsBuilder(IQuery<DeliveryPromiseProvider> query) : base(query)
        {
        }

        public DeliveryPromiseProviderArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }
    }
}