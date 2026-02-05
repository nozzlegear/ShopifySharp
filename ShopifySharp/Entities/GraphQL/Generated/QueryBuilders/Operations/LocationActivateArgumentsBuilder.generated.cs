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
    public sealed class LocationActivateArgumentsBuilder : ArgumentsBuilderBase<LocationActivatePayload, LocationActivateArgumentsBuilder>
    {
        protected override LocationActivateArgumentsBuilder Self => this;

        public LocationActivateArgumentsBuilder(IQuery<LocationActivatePayload> query) : base(query)
        {
        }

        public LocationActivateArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }
    }
}