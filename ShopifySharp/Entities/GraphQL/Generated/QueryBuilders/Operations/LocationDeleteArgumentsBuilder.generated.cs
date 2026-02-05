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
    public sealed class LocationDeleteArgumentsBuilder : ArgumentsBuilderBase<LocationDeletePayload, LocationDeleteArgumentsBuilder>
    {
        protected override LocationDeleteArgumentsBuilder Self => this;

        public LocationDeleteArgumentsBuilder(IQuery<LocationDeletePayload> query) : base(query)
        {
        }

        public LocationDeleteArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }
    }
}