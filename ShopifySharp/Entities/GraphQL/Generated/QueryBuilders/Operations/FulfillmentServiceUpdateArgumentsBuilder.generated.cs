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
    public sealed class FulfillmentServiceUpdateArgumentsBuilder : ArgumentsBuilderBase<FulfillmentServiceUpdatePayload, FulfillmentServiceUpdateArgumentsBuilder>
    {
        protected override FulfillmentServiceUpdateArgumentsBuilder Self => this;

        public FulfillmentServiceUpdateArgumentsBuilder(IQuery<FulfillmentServiceUpdatePayload> query) : base(query)
        {
        }

        public FulfillmentServiceUpdateArgumentsBuilder CallbackUrl(string? callbackUrl)
        {
            base.InnerQuery.AddArgument("callbackUrl", callbackUrl);
            return this;
        }

        public FulfillmentServiceUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentServiceUpdateArgumentsBuilder InventoryManagement(bool? inventoryManagement)
        {
            base.InnerQuery.AddArgument("inventoryManagement", inventoryManagement);
            return this;
        }

        public FulfillmentServiceUpdateArgumentsBuilder Name(string? name)
        {
            base.InnerQuery.AddArgument("name", name);
            return this;
        }

        public FulfillmentServiceUpdateArgumentsBuilder RequiresShippingMethod(bool? requiresShippingMethod)
        {
            base.InnerQuery.AddArgument("requiresShippingMethod", requiresShippingMethod);
            return this;
        }

        public FulfillmentServiceUpdateArgumentsBuilder TrackingSupport(bool? trackingSupport)
        {
            base.InnerQuery.AddArgument("trackingSupport", trackingSupport);
            return this;
        }
    }
}