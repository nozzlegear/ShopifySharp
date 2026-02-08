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
    public sealed class FulfillmentServiceCreateArgumentsBuilder : ArgumentsBuilderBase<FulfillmentServiceCreatePayload, FulfillmentServiceCreateArgumentsBuilder>
    {
        protected override FulfillmentServiceCreateArgumentsBuilder Self => this;

        public FulfillmentServiceCreateArgumentsBuilder(IQuery<FulfillmentServiceCreatePayload> query) : base(query)
        {
        }

        public FulfillmentServiceCreateArgumentsBuilder CallbackUrl(string? callbackUrl)
        {
            base.InnerQuery.AddArgument("callbackUrl", callbackUrl);
            return this;
        }

        public FulfillmentServiceCreateArgumentsBuilder InventoryManagement(bool? inventoryManagement)
        {
            base.InnerQuery.AddArgument("inventoryManagement", inventoryManagement);
            return this;
        }

        public FulfillmentServiceCreateArgumentsBuilder Name(string? name)
        {
            base.InnerQuery.AddArgument("name", name);
            return this;
        }

        public FulfillmentServiceCreateArgumentsBuilder RequiresShippingMethod(bool? requiresShippingMethod)
        {
            base.InnerQuery.AddArgument("requiresShippingMethod", requiresShippingMethod);
            return this;
        }

        public FulfillmentServiceCreateArgumentsBuilder TrackingSupport(bool? trackingSupport)
        {
            base.InnerQuery.AddArgument("trackingSupport", trackingSupport);
            return this;
        }
    }
}