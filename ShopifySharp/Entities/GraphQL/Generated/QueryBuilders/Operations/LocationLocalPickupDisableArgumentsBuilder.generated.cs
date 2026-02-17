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