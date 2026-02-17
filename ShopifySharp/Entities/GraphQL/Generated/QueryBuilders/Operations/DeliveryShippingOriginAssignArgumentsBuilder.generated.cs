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
    public sealed class DeliveryShippingOriginAssignArgumentsBuilder : ArgumentsBuilderBase<DeliveryShippingOriginAssignPayload, DeliveryShippingOriginAssignArgumentsBuilder>
    {
        protected override DeliveryShippingOriginAssignArgumentsBuilder Self => this;

        public DeliveryShippingOriginAssignArgumentsBuilder(IQuery<DeliveryShippingOriginAssignPayload> query) : base(query)
        {
        }

        public DeliveryShippingOriginAssignArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }
    }
}