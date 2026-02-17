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
    public sealed class DeliveryPromiseProviderUpsertArgumentsBuilder : ArgumentsBuilderBase<DeliveryPromiseProviderUpsertPayload, DeliveryPromiseProviderUpsertArgumentsBuilder>
    {
        protected override DeliveryPromiseProviderUpsertArgumentsBuilder Self => this;

        public DeliveryPromiseProviderUpsertArgumentsBuilder(IQuery<DeliveryPromiseProviderUpsertPayload> query) : base(query)
        {
        }

        public DeliveryPromiseProviderUpsertArgumentsBuilder Active(bool? active)
        {
            base.InnerQuery.AddArgument("active", active);
            return this;
        }

        public DeliveryPromiseProviderUpsertArgumentsBuilder FulfillmentDelay(int? fulfillmentDelay)
        {
            base.InnerQuery.AddArgument("fulfillmentDelay", fulfillmentDelay);
            return this;
        }

        public DeliveryPromiseProviderUpsertArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public DeliveryPromiseProviderUpsertArgumentsBuilder TimeZone(string? timeZone)
        {
            base.InnerQuery.AddArgument("timeZone", timeZone);
            return this;
        }
    }
}