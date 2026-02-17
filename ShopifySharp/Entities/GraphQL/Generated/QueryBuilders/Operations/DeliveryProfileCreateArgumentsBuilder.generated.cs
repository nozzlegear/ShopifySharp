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
    public sealed class DeliveryProfileCreateArgumentsBuilder : ArgumentsBuilderBase<DeliveryProfileCreatePayload, DeliveryProfileCreateArgumentsBuilder>
    {
        protected override DeliveryProfileCreateArgumentsBuilder Self => this;

        public DeliveryProfileCreateArgumentsBuilder(IQuery<DeliveryProfileCreatePayload> query) : base(query)
        {
        }

        public DeliveryProfileCreateArgumentsBuilder Profile(DeliveryProfileInput? profile)
        {
            base.InnerQuery.AddArgument("profile", profile);
            return this;
        }
    }
}