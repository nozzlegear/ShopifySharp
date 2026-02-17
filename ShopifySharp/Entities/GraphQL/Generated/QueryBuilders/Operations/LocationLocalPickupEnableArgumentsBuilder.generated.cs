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