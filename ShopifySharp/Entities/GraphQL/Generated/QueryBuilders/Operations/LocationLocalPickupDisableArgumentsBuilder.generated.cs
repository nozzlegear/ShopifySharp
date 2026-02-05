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
    public sealed class LocationLocalPickupDisableArgumentsBuilder : ArgumentsBuilderBase<LocationLocalPickupDisablePayload, LocationLocalPickupDisableArgumentsBuilder>
    {
        protected override LocationLocalPickupDisableArgumentsBuilder Self => this;

        public LocationLocalPickupDisableArgumentsBuilder(IQuery<LocationLocalPickupDisablePayload> query) : base(query)
        {
        }

        public LocationLocalPickupDisableArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }
    }
}