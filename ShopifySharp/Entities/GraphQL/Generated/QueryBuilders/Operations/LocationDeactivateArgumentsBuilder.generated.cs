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
    public sealed class LocationDeactivateArgumentsBuilder : ArgumentsBuilderBase<LocationDeactivatePayload, LocationDeactivateArgumentsBuilder>
    {
        protected override LocationDeactivateArgumentsBuilder Self => this;

        public LocationDeactivateArgumentsBuilder(IQuery<LocationDeactivatePayload> query) : base(query)
        {
        }

        public LocationDeactivateArgumentsBuilder DestinationLocationId(string? destinationLocationId)
        {
            base.InnerQuery.AddArgument("destinationLocationId", destinationLocationId);
            return this;
        }

        public LocationDeactivateArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }
    }
}