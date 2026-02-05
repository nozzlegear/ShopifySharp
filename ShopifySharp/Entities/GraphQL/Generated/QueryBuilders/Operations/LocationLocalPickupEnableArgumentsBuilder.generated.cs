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
    public sealed class LocationLocalPickupEnableArgumentsBuilder : ArgumentsBuilderBase<LocationLocalPickupEnablePayload, LocationLocalPickupEnableArgumentsBuilder>
    {
        protected override LocationLocalPickupEnableArgumentsBuilder Self => this;

        public LocationLocalPickupEnableArgumentsBuilder(IQuery<LocationLocalPickupEnablePayload> query) : base(query)
        {
        }

        public LocationLocalPickupEnableArgumentsBuilder LocalPickupSettings(DeliveryLocationLocalPickupEnableInput? localPickupSettings)
        {
            base.InnerQuery.AddArgument("localPickupSettings", localPickupSettings);
            return this;
        }
    }
}